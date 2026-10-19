using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Cau3_DaNgoai.Models;

namespace Cau3_DaNgoai
{
    public partial class FormChuyenDi : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(8)
        };

        private int _selectedMaChuyen = 0;
        private string _currentLang = "vi-VN";
        private UserSettings _userSettings = new UserSettings();

        public FormChuyenDi()
        {
            InitializeComponent();
        }

        private async void FormChuyenDi_Load(object sender, EventArgs e)
        {
            try
            {
                _userSettings = UserSettings.Load();
                _currentLang = _userSettings.Language;
                cboNgonNgu.SelectedIndex = _currentLang == "en-US" ? 1 : 0;

                ApplyLanguage(_currentLang);

                cboPhuongTien.SelectedIndex = 1;

                var now = DateTime.Today;
                dtpTuNgay.Value = now.AddDays(-30);
                dtpDenNgay.Value = now.AddDays(60);
                dtpNgayDi.Value = now.AddDays(3);

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp dữ liệu FormChuyenDi ban đầu.");
            }
        }

        private void ApplyLanguage(string lang)
        {
            _currentLang = lang;
            bool isVi = lang == "vi-VN";

            this.Text = isVi ? "Kế hoạch dã ngoại" : "Picnic & Trip Planner";
            lblTitle.Text = isVi ? "Kế hoạch dã ngoại cuối tuần" : "Weekend Picnic & Trip Planner";
            lblNgonNgu.Text = isVi ? "Ngôn ngữ:" : "Language:";

            grpThongTin.Text = isVi ? "Thông tin chuyến đi" : "Trip Information";
            lblTenChuyen.Text = isVi ? "Tên chuyến:" : "Trip Name:";
            lblDiaDiem.Text = isVi ? "Địa điểm:" : "Destination:";
            lblNgayDi.Text = isVi ? "Ngày đi:" : "Departure:";
            lblSoNguoi.Text = isVi ? "Số người:" : "Members:";
            lblNganSach.Text = isVi ? "Ngân sách:" : "Budget:";
            lblPhuongTien.Text = isVi ? "Phương tiện:" : "Transport:";
            chkDaHoanThanh.Text = isVi ? "Đã hoàn thành" : "Completed";

            btnThem.Text = isVi ? "Thêm" : "Add";
            btnSua.Text = isVi ? "Sửa" : "Edit";
            btnXoa.Text = isVi ? "Xóa" : "Delete";
            btnLamMoi.Text = isVi ? "Làm mới" : "Refresh";

            lblTieuDeThoiTiet.Text = isVi ? "Dự báo thời tiết:" : "Weather Forecast:";
            btnXemThoiTiet.Text = isVi ? "Xem thời tiết" : "Check Weather";
            lblCanhBaoMua.Text = isVi ? "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch" : "⚠️ High rain probability: bring a raincoat or reschedule";

            grpTimKiem.Text = isVi ? "Tìm kiếm / Lọc" : "Search & Filter";
            txtTimDiaDiem.PlaceholderText = isVi ? "Tìm theo tên hoặc địa điểm..." : "Search trip or destination...";
            chkChiChuaHoanThanh.Text = isVi ? "Chỉ hiện chuyến chưa hoàn thành" : "Uncompleted trips only";
            lblTuNgay.Text = isVi ? "Từ:" : "From:";
            lblDenNgay.Text = isVi ? "Đến:" : "To:";
            btnTim.Text = isVi ? "Tìm" : "Search";
            btnBoLoc.Text = isVi ? "Bỏ lọc" : "Reset";

            lblStatus.Text = isVi ? "Sẵn sàng" : "Ready";

            if (dgvChuyenDi.Columns["MaChuyen"] != null)
                dgvChuyenDi.Columns["MaChuyen"].HeaderText = isVi ? "Mã" : "ID";
            if (dgvChuyenDi.Columns["TenChuyen"] != null)
                dgvChuyenDi.Columns["TenChuyen"].HeaderText = isVi ? "Tên chuyến" : "Trip Name";
            if (dgvChuyenDi.Columns["DiaDiem"] != null)
                dgvChuyenDi.Columns["DiaDiem"].HeaderText = isVi ? "Địa điểm" : "Destination";
            if (dgvChuyenDi.Columns["NgayDi"] != null)
                dgvChuyenDi.Columns["NgayDi"].HeaderText = isVi ? "Ngày đi" : "Departure";
            if (dgvChuyenDi.Columns["SoNguoi"] != null)
                dgvChuyenDi.Columns["SoNguoi"].HeaderText = isVi ? "Số người" : "Members";
            if (dgvChuyenDi.Columns["NganSach"] != null)
                dgvChuyenDi.Columns["NganSach"].HeaderText = isVi ? "Ngân sách" : "Budget";
            if (dgvChuyenDi.Columns["PhuongTien"] != null)
                dgvChuyenDi.Columns["PhuongTien"].HeaderText = isVi ? "Phương tiện" : "Transport";
            if (dgvChuyenDi.Columns["DaHoanThanh"] != null)
                dgvChuyenDi.Columns["DaHoanThanh"].HeaderText = isVi ? "Hoàn thành" : "Completed";
        }

        private async Task LoadDataAsync(string? keyword = null, bool uncompletedOnly = false, DateTime? from = null, DateTime? to = null)
        {
            try
            {
                using var context = new QLDaNgoaiDbContext();
                var query = context.ChuyenDis.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query = query.Where(c => c.TenChuyen.Contains(keyword) || c.DiaDiem.Contains(keyword));
                }

                if (uncompletedOnly)
                {
                    query = query.Where(c => !c.DaHoanThanh);
                }

                if (from.HasValue)
                {
                    var f = from.Value.Date;
                    query = query.Where(c => c.NgayDi >= f);
                }

                if (to.HasValue)
                {
                    var t = to.Value.Date;
                    query = query.Where(c => c.NgayDi <= t);
                }

                var list = await query.OrderBy(c => c.NgayDi).ToListAsync();

                bool isVi = _currentLang == "vi-VN";
                var culture = new CultureInfo(_currentLang);

                dgvChuyenDi.Columns.Clear();
                dgvChuyenDi.AutoGenerateColumns = false;

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaChuyen",
                    HeaderText = isVi ? "Mã" : "ID",
                    Name = "MaChuyen",
                    Width = 60
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenChuyen",
                    HeaderText = isVi ? "Tên chuyến" : "Trip Name",
                    Name = "TenChuyen",
                    Width = 180
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DiaDiem",
                    HeaderText = isVi ? "Địa điểm" : "Destination",
                    Name = "DiaDiem",
                    Width = 120
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NgayDiStr",
                    HeaderText = isVi ? "Ngày đi" : "Departure",
                    Name = "NgayDi",
                    Width = 110
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoNguoi",
                    HeaderText = isVi ? "Số người" : "Members",
                    Name = "SoNguoi",
                    Width = 80
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NganSachStr",
                    HeaderText = isVi ? "Ngân sách" : "Budget",
                    Name = "NganSach",
                    Width = 130,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    }
                });

                dgvChuyenDi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PhuongTien",
                    HeaderText = isVi ? "Phương tiện" : "Transport",
                    Name = "PhuongTien",
                    Width = 110
                });

                dgvChuyenDi.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    DataPropertyName = "DaHoanThanh",
                    HeaderText = isVi ? "Hoàn thành" : "Completed",
                    Name = "DaHoanThanh",
                    Width = 90
                });

                dgvChuyenDi.DataSource = list.Select(c => new
                {
                    MaChuyen = c.MaChuyen,
                    TenChuyen = c.TenChuyen,
                    DiaDiem = c.DiaDiem,
                    NgayDiStr = c.NgayDi.ToString("dd/MM/yyyy"),
                    SoNguoi = c.SoNguoi,
                    NganSachStr = isVi ? $"{c.NganSach:N0} đ" : $"${(c.NganSach / 25000):N1}",
                    PhuongTien = c.PhuongTien,
                    DaHoanThanh = c.DaHoanThanh
                }).ToList();

                lblStatus.Text = isVi ? $"Tìm thấy {list.Count} chuyến đi." : $"Found {list.Count} trips.";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh sách chuyến đi.");
            }
        }

        private void dgvChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvChuyenDi.Rows.Count) return;

            var row = dgvChuyenDi.Rows[e.RowIndex];
            _selectedMaChuyen = Convert.ToInt32(row.Cells["MaChuyen"].Value);

            txtTenChuyen.Text = row.Cells["TenChuyen"].Value?.ToString() ?? "";
            txtDiaDiem.Text = row.Cells["DiaDiem"].Value?.ToString() ?? "";

            if (DateTime.TryParseExact(row.Cells["NgayDi"].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime d))
            {
                dtpNgayDi.Value = d;
            }

            nudSoNguoi.Value = Convert.ToDecimal(row.Cells["SoNguoi"].Value);
            string pt = row.Cells["PhuongTien"].Value?.ToString() ?? "Xe máy";
            if (cboPhuongTien.Items.Contains(pt)) cboPhuongTien.SelectedItem = pt;

            chkDaHoanThanh.Checked = Convert.ToBoolean(row.Cells["DaHoanThanh"].Value);

            btnXemThoiTiet_Click(this, EventArgs.Empty);
        }

        private bool ValidateInput(bool isNew)
        {
            bool isVi = _currentLang == "vi-VN";

            if (string.IsNullOrWhiteSpace(txtTenChuyen.Text))
            {
                MessageBox.Show(isVi ? "Vui lòng nhập tên chuyến đi!" : "Please enter trip name!",
                    isVi ? "Cảnh báo" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaDiem.Text))
            {
                MessageBox.Show(isVi ? "Vui lòng nhập địa điểm dã ngoại!" : "Please enter destination!",
                    isVi ? "Cảnh báo" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaDiem.Focus();
                return false;
            }

            if (isNew && dtpNgayDi.Value.Date < DateTime.Today)
            {
                MessageBox.Show(isVi ? "Ngày đi không được nhỏ hơn ngày hôm nay khi thêm mới!" : "Departure date cannot be in the past for new trips!",
                    isVi ? "Cảnh báo" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayDi.Focus();
                return false;
            }

            if (nudSoNguoi.Value < 1)
            {
                MessageBox.Show(isVi ? "Số người tham gia phải ít nhất là 1!" : "Number of members must be at least 1!",
                    isVi ? "Cảnh báo" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoNguoi.Focus();
                return false;
            }

            if (nudNganSach.Value < 0)
            {
                MessageBox.Show(isVi ? "Ngân sách không được nhỏ hơn 0!" : "Budget must not be negative!",
                    isVi ? "Cảnh báo" : "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNganSach.Focus();
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            try
            {
                var chuyen = new ChuyenDi
                {
                    TenChuyen = txtTenChuyen.Text.Trim(),
                    DiaDiem = txtDiaDiem.Text.Trim(),
                    NgayDi = dtpNgayDi.Value.Date,
                    SoNguoi = (int)nudSoNguoi.Value,
                    NganSach = nudNganSach.Value,
                    PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Xe máy",
                    DaHoanThanh = chkDaHoanThanh.Checked
                };

                using var context = new QLDaNgoaiDbContext();
                context.ChuyenDis.Add(chuyen);
                await context.SaveChangesAsync();

                Log.Information("Thêm mới chuyến đi: MaChuyen={MaChuyen}, DiaDiem={DiaDiem}", chuyen.MaChuyen, chuyen.DiaDiem);

                bool isVi = _currentLang == "vi-VN";
                MessageBox.Show(isVi ? "Thêm chuyến đi thành công!" : "Trip added successfully!",
                    isVi ? "Thông báo" : "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LamMoi();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm chuyến đi.");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            bool isVi = _currentLang == "vi-VN";
            if (_selectedMaChuyen <= 0)
            {
                MessageBox.Show(isVi ? "Vui lòng chọn chuyến đi cần sửa trong danh sách!" : "Please select a trip to edit!",
                    isVi ? "Thông báo" : "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(false)) return;

            try
            {
                using var context = new QLDaNgoaiDbContext();
                var chuyen = await context.ChuyenDis.FindAsync(_selectedMaChuyen);
                if (chuyen == null) return;

                chuyen.TenChuyen = txtTenChuyen.Text.Trim();
                chuyen.DiaDiem = txtDiaDiem.Text.Trim();
                chuyen.NgayDi = dtpNgayDi.Value.Date;
                chuyen.SoNguoi = (int)nudSoNguoi.Value;
                chuyen.NganSach = nudNganSach.Value;
                chuyen.PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Xe máy";
                chuyen.DaHoanThanh = chkDaHoanThanh.Checked;

                await context.SaveChangesAsync();

                Log.Information("Cập nhật chuyến đi: MaChuyen={MaChuyen}", _selectedMaChuyen);
                MessageBox.Show(isVi ? "Cập nhật thành công!" : "Updated successfully!",
                    isVi ? "Thông báo" : "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi cập nhật chuyến đi.");
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            bool isVi = _currentLang == "vi-VN";
            if (_selectedMaChuyen <= 0)
            {
                MessageBox.Show(isVi ? "Vui lòng chọn chuyến đi cần xóa!" : "Please select a trip to delete!",
                    isVi ? "Thông báo" : "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(isVi ? $"Bạn có chắc muốn xóa chuyến đi '{txtTenChuyen.Text}'?" : $"Are you sure to delete '{txtTenChuyen.Text}'?",
                isVi ? "Xác nhận xóa" : "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var context = new QLDaNgoaiDbContext();
                var chuyen = await context.ChuyenDis.FindAsync(_selectedMaChuyen);
                if (chuyen != null)
                {
                    context.ChuyenDis.Remove(chuyen);
                    await context.SaveChangesAsync();
                    Log.Information("Xóa chuyến đi: MaChuyen={MaChuyen}", _selectedMaChuyen);
                }

                MessageBox.Show(isVi ? "Đã xóa chuyến đi thành công!" : "Trip deleted successfully!",
                    isVi ? "Thông báo" : "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LamMoi();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa chuyến đi.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            _selectedMaChuyen = 0;
            txtTenChuyen.Clear();
            txtDiaDiem.Clear();
            dtpNgayDi.Value = DateTime.Today.AddDays(1);
            nudSoNguoi.Value = 1;
            nudNganSach.Value = 0;
            cboPhuongTien.SelectedIndex = 1;
            chkDaHoanThanh.Checked = false;
            pnlCanhBaoMua.Visible = false;
        }

        private async void btnXemThoiTiet_Click(object sender, EventArgs e)
        {
            string diaDiem = txtDiaDiem.Text.Trim();
            bool isVi = _currentLang == "vi-VN";

            if (string.IsNullOrWhiteSpace(diaDiem))
            {
                MessageBox.Show(isVi ? "Vui lòng nhập địa điểm trước khi tra thời tiết!" : "Please enter destination first!",
                    isVi ? "Thông báo" : "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime ngayDi = dtpNgayDi.Value.Date;
            int daysDiff = (ngayDi - DateTime.Today).Days;

            if (daysDiff < 0)
            {
                lblMoTaThoiTiet.Text = isVi ? "Chuyến đi trong quá khứ" : "Past trip";
                lblNhietDo.Text = "--";
                lblKhaNangMua.Text = "--";
                pnlCanhBaoMua.Visible = false;
                return;
            }

            if (daysDiff >= 16)
            {
                lblMoTaThoiTiet.Text = isVi ? "Chưa có dữ liệu dự báo" : "No forecast data available";
                lblNhietDo.Text = isVi ? "Chỉ hỗ trợ tối đa 16 ngày tới" : "Only up to 16 days forecast";
                lblKhaNangMua.Text = "--";
                lblIconThoiTiet.Text = "❓";
                pnlCanhBaoMua.Visible = false;
                return;
            }

            btnXemThoiTiet.Enabled = false;
            prgLoading.Visible = true;
            lblTieuDeThoiTiet.Text = isVi ? $"Dự báo thời tiết ngày {ngayDi:dd/MM/yyyy} - {diaDiem}" : $"Weather Forecast on {ngayDi:dd/MM/yyyy} - {diaDiem}";

            try
            {
                string geoUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(diaDiem)}&count=1&language=vi";
                string geoJson = await _httpClient.GetStringAsync(geoUrl);
                var geoOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var geoResult = JsonSerializer.Deserialize<GeoSearchResult>(geoJson, geoOptions);

                double lat = 0, lon = 0;
                if (geoResult?.Results != null && geoResult.Results.Count > 0)
                {
                    lat = geoResult.Results[0].Latitude;
                    lon = geoResult.Results[0].Longitude;
                }
                else
                {
                    string noDiacritics = RemoveDiacritics(diaDiem);
                    string geoFallbackUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(noDiacritics)}&count=1&language=vi";
                    string fallbackJson = await _httpClient.GetStringAsync(geoFallbackUrl);
                    var fallbackResult = JsonSerializer.Deserialize<GeoSearchResult>(fallbackJson, geoOptions);

                    if (fallbackResult?.Results != null && fallbackResult.Results.Count > 0)
                    {
                        lat = fallbackResult.Results[0].Latitude;
                        lon = fallbackResult.Results[0].Longitude;
                    }
                    else
                    {
                        MessageBox.Show(isVi ? $"Không tìm thấy địa danh '{diaDiem}'. Gợi ý: Hãy thử nhập tên không dấu (ví dụ: 'Da Lat')." : $"Location '{diaDiem}' not found. Try without accents (e.g. 'Da Lat').",
                            isVi ? "Không tìm thấy địa điểm" : "Location Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string forecastUrl = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=auto&forecast_days=16";
                string forecastJson = await _httpClient.GetStringAsync(forecastUrl);
                var weatherData = JsonSerializer.Deserialize<WeatherForecastResponse>(forecastJson, geoOptions);

                if (weatherData?.Daily?.Time != null)
                {
                    string targetDateStr = ngayDi.ToString("yyyy-MM-dd");
                    int index = weatherData.Daily.Time.IndexOf(targetDateStr);

                    if (index >= 0)
                    {
                        int weatherCode = weatherData.Daily.WeatherCode?[index] ?? 0;
                        double tMax = weatherData.Daily.Temperature2mMax?[index] ?? 0;
                        double tMin = weatherData.Daily.Temperature2mMin?[index] ?? 0;
                        int rainProb = weatherData.Daily.PrecipitationProbabilityMax?[index] ?? 0;

                        var (icon, descVi, descEn) = ParseWeatherCode(weatherCode);

                        lblIconThoiTiet.Text = icon;
                        lblMoTaThoiTiet.Text = isVi ? descVi : descEn;
                        lblNhietDo.Text = isVi ? $"Nhiệt độ: {tMin:N0}°C - {tMax:N0}°C" : $"Temperature: {tMin:N0}°C - {tMax:N0}°C";
                        lblKhaNangMua.Text = isVi ? $"Khả năng mưa: {rainProb}%" : $"Rain chance: {rainProb}%";

                        if (rainProb >= 60)
                        {
                            pnlCanhBaoMua.Visible = true;
                            pnlCanhBaoMua.BackColor = Color.Orange;
                            lblCanhBaoMua.ForeColor = Color.DarkRed;
                        }
                        else
                        {
                            pnlCanhBaoMua.Visible = false;
                        }
                    }
                    else
                    {
                        lblMoTaThoiTiet.Text = isVi ? "Chưa có dữ liệu dự báo" : "No forecast data available";
                    }
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Lỗi kết nối khi gọi API thời tiết Open-Meteo.");
                MessageBox.Show(isVi ? "Lỗi kết nối mạng khi lấy dự báo thời tiết. Vui lòng kiểm tra lại đường truyền!" : "Network error fetching weather forecast. Please check your connection!",
                    isVi ? "Lỗi mạng" : "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi không xác định khi xem thời tiết.");
            }
            finally
            {
                btnXemThoiTiet.Enabled = true;
                prgLoading.Visible = false;
            }
        }

        private (string icon, string descVi, string descEn) ParseWeatherCode(int code)
        {
            if (code == 0) return ("☀️", "Trời quang", "Clear Sky");
            if (code >= 1 && code <= 3) return ("⛅", "Có mây", "Partly Cloudy");
            if (code == 45 || code == 48) return ("🌫️", "Sương mù", "Foggy");
            if ((code >= 51 && code <= 67) || (code >= 80 && code <= 82)) return ("🌧️", "Mưa", "Rainy");
            if (code >= 95 && code <= 99) return ("⛈️", "Dông bão", "Thunderstorm");
            return ("⛅", "Có mây rải rác", "Scattered Clouds");
        }

        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC).Replace("đ", "d").Replace("Đ", "D");
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newLang = cboNgonNgu.SelectedIndex == 1 ? "en-US" : "vi-VN";
            if (_currentLang != newLang)
            {
                _currentLang = newLang;
                _userSettings.Language = newLang;
                _userSettings.Save();
                ApplyLanguage(_currentLang);
                _ = LoadDataAsync();
            }
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            string kw = txtTimDiaDiem.Text.Trim();
            bool uncompleted = chkChiChuaHoanThanh.Checked;
            DateTime from = dtpTuNgay.Value.Date;
            DateTime to = dtpDenNgay.Value.Date;
            await LoadDataAsync(kw, uncompleted, from, to);
        }

        private async void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimDiaDiem.Clear();
            chkChiChuaHoanThanh.Checked = false;
            var now = DateTime.Today;
            dtpTuNgay.Value = now.AddDays(-30);
            dtpDenNgay.Value = now.AddDays(60);
            await LoadDataAsync();
        }
    }
}
