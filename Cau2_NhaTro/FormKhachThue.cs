using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Cau2_NhaTro.Models;

namespace Cau2_NhaTro
{
    public partial class FormKhachThue : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        private int _selectedMaKhach = 0;
        private List<ProvinceItem> _provinces = new List<ProvinceItem>();

        public FormKhachThue()
        {
            InitializeComponent();
        }

        private async void FormKhachThue_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadRoomsAsync();
                await LoadDataGridAsync();
                await LoadProvincesApiAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi khởi động form khách thuê.");
            }
        }

        private async Task LoadRoomsAsync()
        {
            try
            {
                using var context = new QLNhaTroDbContext();
                var rooms = await context.PhongTros.AsNoTracking().ToListAsync();

                cboPhong.Items.Clear();
                foreach (var r in rooms)
                {
                    cboPhong.Items.Add(new RoomDisplayItem
                    {
                        MaPhong = r.MaPhong,
                        TenPhong = r.TenPhong,
                        GiaThue = r.GiaThue,
                        TinhTrang = r.TinhTrang
                    });
                }

                if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;

                cboTimPhong.Items.Clear();
                cboTimPhong.Items.Add("Tất cả");
                foreach (var r in rooms)
                {
                    cboTimPhong.Items.Add(r.TenPhong);
                }
                cboTimPhong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi tải danh sách phòng.");
            }
        }

        private async Task LoadProvincesApiAsync()
        {
            lblStatus.Text = "Đang tải danh sách tỉnh/thành...";
            cboTinhThanh.Enabled = false;
            cboTinhThanh.Items.Clear();
            cboTinhThanh.Items.Add("Đang tải...");
            cboTinhThanh.SelectedIndex = 0;

            try
            {
                string json = await _httpClient.GetStringAsync("https://provinces.open-api.vn/api/v2/");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var provinces = JsonSerializer.Deserialize<List<ProvinceItem>>(json, options);

                if (provinces != null && provinces.Count > 0)
                {
                    _provinces = provinces;
                    cboTinhThanh.Items.Clear();
                    cboTimTinh.Items.Clear();
                    cboTimTinh.Items.Add("Tất cả");

                    foreach (var p in _provinces)
                    {
                        cboTinhThanh.Items.Add(p);
                        cboTimTinh.Items.Add(p.Name);
                    }

                    cboTinhThanh.DisplayMember = "Name";
                    cboTinhThanh.ValueMember = "Code";
                    cboTinhThanh.SelectedIndex = 0;
                    cboTimTinh.SelectedIndex = 0;

                    lblStatus.Text = $"Đã tải {_provinces.Count} tỉnh/thành từ provinces.open-api.vn";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Không thể kết nối đến API provinces.open-api.vn. Chuyển sang chế độ nhập địa chỉ thủ công.");
                MessageBox.Show("Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng. Bạn có thể tự gõ tên Tỉnh và Phường/Xã.",
                    "Lỗi kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboTinhThanh.DropDownStyle = ComboBoxStyle.DropDown;
                cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
                cboTinhThanh.Items.Clear();
                cboTinhThanh.Text = "Thành phố Hà Nội";
                lblStatus.Text = "Mất kết nối API địa chỉ - Chế độ gõ tay.";
            }
            finally
            {
                cboTinhThanh.Enabled = true;
            }
        }

        private async void cboTinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinhThanh.SelectedItem is ProvinceItem selectedProvince)
            {
                await LoadWardsApiAsync(selectedProvince.Code);
            }
        }

        private async Task LoadWardsApiAsync(int provinceCode)
        {
            lblStatus.Text = "Đang tải danh sách xã/phường...";
            cboPhuongXa.Enabled = false;
            cboPhuongXa.Items.Clear();
            cboPhuongXa.Items.Add("Đang tải...");
            cboPhuongXa.SelectedIndex = 0;

            try
            {
                string url = $"https://provinces.open-api.vn/api/v2/p/{provinceCode}?depth=2";
                string json = await _httpClient.GetStringAsync(url);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var provinceDetail = JsonSerializer.Deserialize<ProvinceItem>(json, options);

                cboPhuongXa.Items.Clear();
                var wardList = new List<WardItem>();

                if (provinceDetail?.Wards != null && provinceDetail.Wards.Count > 0)
                {
                    wardList.AddRange(provinceDetail.Wards);
                }
                else if (provinceDetail?.Districts != null)
                {
                    foreach (var d in provinceDetail.Districts)
                    {
                        if (d.Wards != null && d.Wards.Count > 0)
                        {
                            wardList.AddRange(d.Wards);
                        }
                        else
                        {
                            wardList.Add(new WardItem { Code = d.Code, Name = d.Name });
                        }
                    }
                }

                if (wardList.Count > 0)
                {
                    foreach (var w in wardList)
                    {
                        cboPhuongXa.Items.Add(w);
                    }
                    cboPhuongXa.DisplayMember = "Name";
                    cboPhuongXa.ValueMember = "Code";
                    cboPhuongXa.SelectedIndex = 0;
                    lblStatus.Text = $"Đã nạp {wardList.Count} phường/xã.";
                }
                else
                {
                    cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
                    cboPhuongXa.Text = "Phường/Xã trung tâm";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Lỗi nạp phường/xã từ API.");
                cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
                cboPhuongXa.Items.Clear();
                cboPhuongXa.Text = "Nhập phường/xã";
            }
            finally
            {
                cboPhuongXa.Enabled = true;
            }
        }

        private async Task LoadDataGridAsync(string? search = null, string? phong = null, string? tinh = null)
        {
            try
            {
                using var context = new QLNhaTroDbContext();
                var query = context.KhachThues.Include(k => k.PhongTro).AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(k => k.HoTen.Contains(search) || k.SoDienThoai.Contains(search));
                }

                if (!string.IsNullOrWhiteSpace(phong) && phong != "Tất cả")
                {
                    query = query.Where(k => k.PhongTro != null && k.PhongTro.TenPhong == phong);
                }

                if (!string.IsNullOrWhiteSpace(tinh) && tinh != "Tất cả")
                {
                    query = query.Where(k => k.TenTinh.Contains(tinh));
                }

                var list = await query.ToListAsync();

                dgvKhachThue.Columns.Clear();
                dgvKhachThue.AutoGenerateColumns = false;

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaKhach",
                    HeaderText = "Mã",
                    Name = "MaKhach",
                    Visible = false
                });

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "HoTen",
                    HeaderText = "Họ tên",
                    Name = "HoTen",
                    Width = 160
                });

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoDienThoai",
                    HeaderText = "SĐT",
                    Name = "SoDienThoai",
                    Width = 110
                });

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenPhong",
                    HeaderText = "Phòng",
                    Name = "TenPhong",
                    Width = 80
                });

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GiaThue",
                    HeaderText = "Giá thuê",
                    Name = "GiaThue",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N0",
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    }
                });

                dgvKhachThue.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "QueQuan",
                    HeaderText = "Quê quán",
                    Name = "QueQuan",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                dgvKhachThue.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    DataPropertyName = "DaDangKyTamTru",
                    HeaderText = "Tạm trú",
                    Name = "DaDangKyTamTru",
                    Width = 80
                });

                dgvKhachThue.DataSource = list.Select(k => new
                {
                    MaKhach = k.MaKhach,
                    HoTen = k.HoTen,
                    SoDienThoai = k.SoDienThoai,
                    TenPhong = k.PhongTro?.TenPhong ?? "",
                    GiaThue = k.PhongTro?.GiaThue ?? 0,
                    QueQuan = $"{k.TenPhuongXa} – {k.TenTinh}",
                    DaDangKyTamTru = k.DaDangKyTamTru
                }).ToList();

                lblStatus.Text = $"Danh sách có {list.Count} khách thuê.";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi truy vấn danh sách khách thuê.");
                MessageBox.Show("Có lỗi xảy ra khi đọc dữ liệu khách thuê.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvKhachThue.Rows.Count) return;

            var row = dgvKhachThue.Rows[e.RowIndex];
            _selectedMaKhach = Convert.ToInt32(row.Cells["MaKhach"].Value);

            try
            {
                using var context = new QLNhaTroDbContext();
                var khach = await context.KhachThues.Include(k => k.PhongTro).FirstOrDefaultAsync(k => k.MaKhach == _selectedMaKhach);
                if (khach != null)
                {
                    txtHoTen.Text = khach.HoTen;
                    if (khach.GioiTinh == "Nữ") radNu.Checked = true;
                    else radNam.Checked = true;

                    dtpNgaySinh.Value = khach.NgaySinh;
                    txtSDT.Text = khach.SoDienThoai;
                    chkTamTru.Checked = khach.DaDangKyTamTru;

                    for (int i = 0; i < cboPhong.Items.Count; i++)
                    {
                        if (cboPhong.Items[i] is RoomDisplayItem r && r.MaPhong == khach.MaPhong)
                        {
                            cboPhong.SelectedIndex = i;
                            break;
                        }
                    }

                    cboTinhThanh.Text = khach.TenTinh;
                    cboPhuongXa.Text = khach.TenPhuongXa;
                    lblStatus.Text = $"Đang chọn khách hàng: {khach.HoTen}";
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi hiển thị thông tin khách thuê.");
            }
        }

        private bool ValidateGuest()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách thuê!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            if (cboPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng trọ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateGuest()) return;

            try
            {
                var selectedRoom = (RoomDisplayItem)cboPhong.SelectedItem!;

                int maTinh = 0;
                string tenTinh = cboTinhThanh.Text.Trim();
                if (cboTinhThanh.SelectedItem is ProvinceItem p)
                {
                    maTinh = p.Code;
                    tenTinh = p.Name;
                }

                int maPhuongXa = 0;
                string tenPhuongXa = cboPhuongXa.Text.Trim();
                if (cboPhuongXa.SelectedItem is WardItem w)
                {
                    maPhuongXa = w.Code;
                    tenPhuongXa = w.Name;
                }

                var khach = new KhachThue
                {
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = radNu.Checked ? "Nữ" : "Nam",
                    NgaySinh = dtpNgaySinh.Value.Date,
                    SoDienThoai = txtSDT.Text.Trim(),
                    MaPhong = selectedRoom.MaPhong,
                    MaTinh = maTinh,
                    TenTinh = tenTinh,
                    MaPhuongXa = maPhuongXa,
                    TenPhuongXa = tenPhuongXa,
                    DaDangKyTamTru = chkTamTru.Checked
                };

                using var context = new QLNhaTroDbContext();
                context.KhachThues.Add(khach);

                var phong = await context.PhongTros.FindAsync(selectedRoom.MaPhong);
                if (phong != null)
                {
                    phong.TinhTrang = "Đang thuê";
                }

                await context.SaveChangesAsync();

                Log.Information("Thêm mới khách thuê: MaKhach={MaKhach}, HoTen={HoTen}, Phong={Phong}",
                    khach.MaKhach, khach.HoTen, selectedRoom.TenPhong);

                MessageBox.Show("Thêm khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                await LoadRoomsAsync();
                await LoadDataGridAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm khách thuê.");
                MessageBox.Show("Có lỗi xảy ra khi lưu khách thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaKhach <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần sửa trong bảng!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateGuest()) return;

            try
            {
                using var context = new QLNhaTroDbContext();
                var khach = await context.KhachThues.FindAsync(_selectedMaKhach);
                if (khach == null)
                {
                    MessageBox.Show("Khách thuê không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRoom = (RoomDisplayItem)cboPhong.SelectedItem!;
                int oldMaPhong = khach.MaPhong;

                khach.HoTen = txtHoTen.Text.Trim();
                khach.GioiTinh = radNu.Checked ? "Nữ" : "Nam";
                khach.NgaySinh = dtpNgaySinh.Value.Date;
                khach.SoDienThoai = txtSDT.Text.Trim();
                khach.MaPhong = selectedRoom.MaPhong;

                if (cboTinhThanh.SelectedItem is ProvinceItem p)
                {
                    khach.MaTinh = p.Code;
                    khach.TenTinh = p.Name;
                }
                else
                {
                    khach.TenTinh = cboTinhThanh.Text.Trim();
                }

                if (cboPhuongXa.SelectedItem is WardItem w)
                {
                    khach.MaPhuongXa = w.Code;
                    khach.TenPhuongXa = w.Name;
                }
                else
                {
                    khach.TenPhuongXa = cboPhuongXa.Text.Trim();
                }

                khach.DaDangKyTamTru = chkTamTru.Checked;

                if (oldMaPhong != selectedRoom.MaPhong)
                {
                    var newRoom = await context.PhongTros.FindAsync(selectedRoom.MaPhong);
                    if (newRoom != null) newRoom.TinhTrang = "Đang thuê";

                    int remainInOld = await context.KhachThues.CountAsync(k => k.MaPhong == oldMaPhong && k.MaKhach != _selectedMaKhach);
                    if (remainInOld == 0)
                    {
                        var oldRoom = await context.PhongTros.FindAsync(oldMaPhong);
                        if (oldRoom != null) oldRoom.TinhTrang = "Trống";
                    }
                }

                await context.SaveChangesAsync();

                Log.Information("Cập nhật khách thuê MaKhach={MaKhach}: HoTen={HoTen}", _selectedMaKhach, khach.HoTen);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadRoomsAsync();
                await LoadDataGridAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi cập nhật khách thuê MaKhach={MaKhach}", _selectedMaKhach);
                MessageBox.Show("Có lỗi xảy ra khi cập nhật khách thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaKhach <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần xóa trong bảng!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách thuê {txtHoTen.Text}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var context = new QLNhaTroDbContext();
                var khach = await context.KhachThues.FindAsync(_selectedMaKhach);
                if (khach != null)
                {
                    int maPhong = khach.MaPhong;
                    context.KhachThues.Remove(khach);
                    await context.SaveChangesAsync();

                    int remain = await context.KhachThues.CountAsync(k => k.MaPhong == maPhong);
                    if (remain == 0)
                    {
                        var room = await context.PhongTros.FindAsync(maPhong);
                        if (room != null)
                        {
                            room.TinhTrang = "Trống";
                            await context.SaveChangesAsync();
                        }
                    }

                    Log.Information("Đã xóa khách thuê MaKhach={MaKhach}", _selectedMaKhach);
                }

                MessageBox.Show("Xóa khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                await LoadRoomsAsync();
                await LoadDataGridAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa khách thuê MaKhach={MaKhach}", _selectedMaKhach);
                MessageBox.Show("Có lỗi xảy ra khi xóa khách thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            _selectedMaKhach = 0;
            txtHoTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            txtSDT.Clear();
            chkTamTru.Checked = false;
            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
            lblStatus.Text = "Đã làm mới form.";
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            string search = txtTim.Text.Trim();
            string phong = cboTimPhong.SelectedItem?.ToString() ?? "Tất cả";
            string tinh = cboTimTinh.SelectedItem?.ToString() ?? "Tất cả";
            await LoadDataGridAsync(search, phong, tinh);
        }

        private async void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            cboTimPhong.SelectedIndex = 0;
            cboTimTinh.SelectedIndex = 0;
            await LoadDataGridAsync();
        }

        private void btnGayLoi_Click(object sender, EventArgs e)
        {
            throw new InvalidOperationException("Đây là ngoại lệ thử nghiệm hệ thống xử lý lỗi toàn cục!");
        }

        private class RoomDisplayItem
        {
            public int MaPhong { get; set; }
            public string TenPhong { get; set; } = string.Empty;
            public decimal GiaThue { get; set; }
            public string TinhTrang { get; set; } = "Trống";

            public override string ToString()
            {
                return $"{TenPhong} - {GiaThue:N0} đ ({TinhTrang})";
            }
        }
    }
}
