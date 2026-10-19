using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Cau4_TraSua.Models;

namespace Cau4_TraSua
{
    public partial class FormBanHang : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        private List<CartItem> _cart = new List<CartItem>();
        private string _hinhThucThanhToan = "Tiền mặt";
        private int _currentTempInvoiceId = 1000;

        public FormBanHang()
        {
            InitializeComponent();
        }

        private async void FormBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                var cfg = AppConfig.Instance.Payment;
                lblInfoNganHang.Text = $"Quán: {cfg.TenQuan}\r\nNgân hàng: {cfg.BankId.ToUpper()}\r\nSTK: {cfg.AccountNo}\r\nChủ TK: {cfg.AccountName}";

                dtpLocNgay.Value = DateTime.Today;

                await LoadCategoriesAsync();
                SetupCartGrid();
                await LoadInvoicesAsync();
                UpdateCartDisplay();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp dữ liệu ban đầu FormBanHang.");
            }
        }

        private async Task LoadCategoriesAsync()
        {
            try
            {
                using var context = new QLTraSuaDbContext();
                var categories = await context.DanhMucMons.AsNoTracking().ToListAsync();

                cboDanhMuc.Items.Clear();
                foreach (var c in categories)
                {
                    cboDanhMuc.Items.Add(c);
                }

                if (cboDanhMuc.Items.Count > 0)
                {
                    cboDanhMuc.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi tải danh mục.");
            }
        }

        private async void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedItem is not DanhMucMon cat) return;

            try
            {
                using var context = new QLTraSuaDbContext();
                var mons = await context.MonUongs
                    .Where(m => m.MaDM == cat.MaDM && m.DangBan)
                    .AsNoTracking()
                    .ToListAsync();

                lstMon.Items.Clear();
                foreach (var m in mons)
                {
                    lstMon.Items.Add(m);
                }

                if (lstMon.Items.Count > 0)
                {
                    lstMon.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh sách món uống.");
            }
        }

        private void SetupCartGrid()
        {
            dgvGioHang.Columns.Clear();
            dgvGioHang.AutoGenerateColumns = false;

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenMon",
                HeaderText = "Tên món",
                Name = "TenMon",
                Width = 160
            });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLy",
                HeaderText = "SL",
                Name = "SoLy",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGia",
                HeaderText = "Đơn giá",
                Name = "DonGia",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành tiền",
                Name = "ThanhTien",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            if (lstMon.SelectedItem is not MonUong mon)
            {
                MessageBox.Show("Vui lòng chọn món để thêm vào đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int soLy = (int)nudSoLy.Value;
            var item = _cart.FirstOrDefault(c => c.MaMon == mon.MaMon);
            if (item != null)
            {
                item.SoLy += soLy;
            }
            else
            {
                _cart.Add(new CartItem
                {
                    MaMon = mon.MaMon,
                    TenMon = mon.TenMon,
                    SoLy = soLy,
                    DonGia = mon.GiaBan
                });
            }

            UpdateCartDisplay();
            nudSoLy.Value = 1;
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            int idx = dgvGioHang.CurrentRow.Index;
            if (idx >= 0 && idx < _cart.Count)
            {
                _cart.RemoveAt(idx);
                UpdateCartDisplay();
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này?", "Hủy đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _cart.Clear();
                UpdateCartDisplay();
                ResetQR();
            }
        }

        private void UpdateCartDisplay()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _cart.ToList();

            decimal total = _cart.Sum(c => c.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {total:N0} đ";
            lblStatus.Text = $"Đơn hàng có {_cart.Count} món, tổng cộng: {total:N0} đ";
        }

        private void ResetQR()
        {
            if (picQR.Image != null)
            {
                picQR.Image.Dispose();
                picQR.Image = null;
            }
            lblSoTienQR.Text = "Số tiền: 0 đ";
            lblNoiDungQR.Text = "Nội dung: TRASUA";
        }

        private async void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            decimal total = _cart.Sum(c => c.ThanhTien);
            if (total <= 0)
            {
                MessageBox.Show("Vui lòng thêm món vào đơn trước khi thanh toán!", "Đơn trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _hinhThucThanhToan = "Chuyển khoản";
            btnChuyenKhoan.Enabled = false;
            lblStatus.Text = "Đang tạo mã VietQR...";

            try
            {
                int nextId = await GetNextInvoiceIdAsync();
                var payment = AppConfig.Instance.Payment;
                string noiDung = $"TRASUA HD{nextId}";

                lblSoTienQR.Text = $"Số tiền: {total:N0} đ";
                lblNoiDungQR.Text = $"Nội dung: {noiDung}";

                string encodedBank = Uri.EscapeDataString(payment.BankId);
                string encodedAcc = Uri.EscapeDataString(payment.AccountNo);
                string encodedTemplate = Uri.EscapeDataString(payment.Template);
                string encodedName = Uri.EscapeDataString(payment.AccountName);
                string encodedInfo = Uri.EscapeDataString(noiDung);

                string url = $"https://img.vietqr.io/image/{encodedBank}-{encodedAcc}-{encodedTemplate}.png?amount={(long)total}&addInfo={encodedInfo}&accountName={encodedName}";

                byte[] imgBytes = await _httpClient.GetByteArrayAsync(url);
                using var ms = new MemoryStream(imgBytes);
                if (picQR.Image != null) picQR.Image.Dispose();
                picQR.Image = Image.FromStream(ms);

                string maskedAcc = payment.AccountNo.Length > 4
                    ? new string('*', payment.AccountNo.Length - 4) + payment.AccountNo[^4..]
                    : "****";
                Log.Information("Tạo VietQR thành công: MaHD={MaHD}, TongTien={TongTien}, Bank={Bank}, STK={MaskedSTK}",
                    nextId, total, payment.BankId, maskedAcc);

                lblStatus.Text = "Đã tạo mã QR thành công. Mời khách quét mã!";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi tải ảnh VietQR từ img.vietqr.io.");
                MessageBox.Show("Không thể tải mã QR do lỗi kết nối mạng. Khách có thể chuyển khoản thủ công theo thông tin bên dưới hoặc chuyển sang thanh toán tiền mặt.",
                    "Lỗi tải VietQR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblStatus.Text = "Lỗi tải QR - Hỗ trợ chuyển khoản thủ công.";
            }
            finally
            {
                btnChuyenKhoan.Enabled = true;
            }
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            decimal total = _cart.Sum(c => c.ThanhTien);
            if (total <= 0)
            {
                MessageBox.Show("Vui lòng thêm món vào đơn!", "Đơn trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _hinhThucThanhToan = "Tiền mặt";
            ResetQR();
            lblStatus.Text = "Phương thức thanh toán: Tiền mặt. Bấm 'Đã nhận tiền' để hoàn tất.";
            MessageBox.Show($"Khách thanh toán tiền mặt: {total:N0} đ.\nBấm 'Đã nhận tiền' để hoàn tất đơn và in hóa đơn.",
                "Thanh toán tiền mặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnDaNhanTien_Click(object sender, EventArgs e)
        {
            decimal total = _cart.Sum(c => c.ThanhTien);
            if (total <= 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var hoaDon = new HoaDon
                {
                    NgayLap = DateTime.Now,
                    TongTien = total,
                    HinhThucTT = _hinhThucThanhToan,
                    DaThanhToan = true
                };

                foreach (var item in _cart)
                {
                    hoaDon.ChiTietHoaDons.Add(new ChiTietHoaDon
                    {
                        MaMon = item.MaMon,
                        SoLy = item.SoLy,
                        DonGia = item.DonGia
                    });
                }

                using var context = new QLTraSuaDbContext();
                context.HoaDons.Add(hoaDon);
                await context.SaveChangesAsync();

                Log.Information("Thanh toán thành công hóa đơn HD{MaHD}: TongTien={TongTien}, HinhThuc={HinhThuc}",
                    hoaDon.MaHD, hoaDon.TongTien, hoaDon.HinhThucTT);

                MessageBox.Show($"Thanh toán thành công đơn hàng HD{hoaDon.MaHD}!\nTổng tiền: {hoaDon.TongTien:N0} đ ({hoaDon.HinhThucTT})",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cart.Clear();
                UpdateCartDisplay();
                ResetQR();
                await LoadInvoicesAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi lưu hóa đơn vào CSDL.");
                MessageBox.Show("Có lỗi xảy ra khi lưu hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> GetNextInvoiceIdAsync()
        {
            try
            {
                using var context = new QLTraSuaDbContext();
                int maxId = await context.HoaDons.MaxAsync(h => (int?)h.MaHD) ?? 1000;
                return maxId + 1;
            }
            catch
            {
                return ++_currentTempInvoiceId;
            }
        }

        private async Task LoadInvoicesAsync()
        {
            try
            {
                DateTime date = dtpLocNgay.Value.Date;
                DateTime nextDate = date.AddDays(1);

                using var context = new QLTraSuaDbContext();
                var invoices = await context.HoaDons
                    .Where(h => h.NgayLap >= date && h.NgayLap < nextDate)
                    .OrderByDescending(h => h.NgayLap)
                    .AsNoTracking()
                    .ToListAsync();

                dgvHoaDon.Columns.Clear();
                dgvHoaDon.AutoGenerateColumns = false;

                dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaHD", HeaderText = "Mã HD", Name = "MaHD", Width = 70 });
                dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioLap", HeaderText = "Giờ lập", Name = "GioLap", Width = 90 });
                dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HinhThucTT", HeaderText = "Hình thức", Name = "HinhThucTT", Width = 110 });
                dgvHoaDon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TongTien",
                    HeaderText = "Tổng tiền",
                    Name = "TongTien",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
                });

                dgvHoaDon.DataSource = invoices.Select(h => new
                {
                    MaHD = $"HD{h.MaHD}",
                    RawMaHD = h.MaHD,
                    GioLap = h.NgayLap.ToString("HH:mm:ss"),
                    HinhThucTT = h.HinhThucTT,
                    TongTien = h.TongTien
                }).ToList();

                decimal totalDay = invoices.Sum(h => h.TongTien);
                lblDoanhThuNgay.Text = $"Doanh thu ngày ({date:dd/MM/yyyy}): {totalDay:N0} đ";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh sách hóa đơn.");
            }
        }

        private async void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHoaDon.Rows.Count) return;

            var row = dgvHoaDon.Rows[e.RowIndex];
            string maHDStr = row.Cells["MaHD"].Value?.ToString() ?? "";
            int maHD = int.Parse(maHDStr.Replace("HD", ""));

            try
            {
                using var context = new QLTraSuaDbContext();
                var details = await context.ChiTietHoaDons
                    .Where(c => c.MaHD == maHD)
                    .Include(c => c.MonUong)
                    .AsNoTracking()
                    .ToListAsync();

                dgvChiTietHD.Columns.Clear();
                dgvChiTietHD.AutoGenerateColumns = false;

                dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên món", Name = "TenMon", Width = 160 });
                dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLy", HeaderText = "SL", Name = "SoLy", Width = 50, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
                dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DonGia", HeaderText = "Đơn giá", Name = "DonGia", Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
                dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành tiền", Name = "ThanhTien", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });

                dgvChiTietHD.DataSource = details.Select(d => new
                {
                    TenMon = d.MonUong?.TenMon ?? "",
                    SoLy = d.SoLy,
                    DonGia = d.DonGia,
                    ThanhTien = d.SoLy * d.DonGia
                }).ToList();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi nạp chi tiết hóa đơn.");
            }
        }

        private async void dtpLocNgay_ValueChanged(object sender, EventArgs e)
        {
            await LoadInvoicesAsync();
        }

        private async void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            await LoadInvoicesAsync();
        }

        private void btnMoThucDon_Click(object sender, EventArgs e)
        {
            using var frm = new FormThucDon();
            frm.ShowDialog();
            _ = LoadCategoriesAsync();
        }

        private class CartItem
        {
            public int MaMon { get; set; }
            public string TenMon { get; set; } = string.Empty;
            public int SoLy { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLy * DonGia;
        }
    }
}
