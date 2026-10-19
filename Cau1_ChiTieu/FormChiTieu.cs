using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Cau1_ChiTieu.Models;

namespace Cau1_ChiTieu
{
    public partial class FormChiTieu : Form
    {
        private int _selectedMaCT = 0;

        public FormChiTieu()
        {
            InitializeComponent();
        }

        private async void FormChiTieu_Load(object sender, EventArgs e)
        {
            try
            {
                cboLoaiChi.SelectedIndex = 0;
                cboTimLoaiChi.SelectedIndex = 0;

                var now = DateTime.Today;
                dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
                dtpDenNgay.Value = now;
                dtpNgayChi.Value = now;

                await LoadDataAsync();
                lblStatus.Text = "Đã tải dữ liệu thành công.";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi tải dữ liệu form chi tiêu ban đầu.");
                MessageBox.Show("Không thể tải danh sách chi tiêu. Vui lòng kiểm tra kết nối CSDL trong appsettings.json.",
                    "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Lỗi kết nối CSDL.";
            }
        }

        private async Task LoadDataAsync(string? noiDung = null, string? loaiChi = null, DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            try
            {
                using var context = new QLChiTieuDbContext();
                var query = context.ChiTieus.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(noiDung))
                {
                    query = query.Where(c => c.NoiDung.Contains(noiDung));
                }

                if (!string.IsNullOrWhiteSpace(loaiChi) && loaiChi != "Tất cả")
                {
                    query = query.Where(c => c.LoaiChi == loaiChi);
                }

                if (tuNgay.HasValue)
                {
                    var from = tuNgay.Value.Date;
                    query = query.Where(c => c.NgayChi >= from);
                }

                if (denNgay.HasValue)
                {
                    var to = denNgay.Value.Date;
                    query = query.Where(c => c.NgayChi <= to);
                }

                var list = await query.OrderByDescending(c => c.NgayChi).ThenByDescending(c => c.MaCT).ToListAsync();

                dgvChiTieu.DataSource = list.Select(c => new
                {
                    MaCT = c.MaCT,
                    NgayChi = c.NgayChi.ToString("dd/MM/yyyy"),
                    NoiDung = c.NoiDung,
                    LoaiChi = c.LoaiChi,
                    SoTien = c.SoTien,
                    GhiChu = c.GhiChu
                }).ToList();

                if (dgvChiTieu.Columns["MaCT"] != null)
                {
                    dgvChiTieu.Columns["MaCT"].HeaderText = "Mã";
                    dgvChiTieu.Columns["MaCT"].Width = 60;
                }
                if (dgvChiTieu.Columns["NgayChi"] != null)
                {
                    dgvChiTieu.Columns["NgayChi"].HeaderText = "Ngày chi";
                    dgvChiTieu.Columns["NgayChi"].Width = 100;
                }
                if (dgvChiTieu.Columns["NoiDung"] != null)
                {
                    dgvChiTieu.Columns["NoiDung"].HeaderText = "Nội dung";
                }
                if (dgvChiTieu.Columns["LoaiChi"] != null)
                {
                    dgvChiTieu.Columns["LoaiChi"].HeaderText = "Loại chi";
                    dgvChiTieu.Columns["LoaiChi"].Width = 110;
                }
                if (dgvChiTieu.Columns["SoTien"] != null)
                {
                    dgvChiTieu.Columns["SoTien"].HeaderText = "Số tiền (đ)";
                    dgvChiTieu.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                    dgvChiTieu.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvChiTieu.Columns["SoTien"].Width = 120;
                }
                if (dgvChiTieu.Columns["GhiChu"] != null)
                {
                    dgvChiTieu.Columns["GhiChu"].HeaderText = "Ghi chú";
                }

                decimal tongTien = list.Sum(c => c.SoTien);
                lblTongChi.Text = $"Tổng chi: {tongTien:N0} đ";
                lblStatus.Text = $"Hiển thị {list.Count} khoản chi.";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi truy vấn danh sách khoản chi.");
                MessageBox.Show("Có lỗi xảy ra khi đọc dữ liệu từ CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Lỗi truy vấn CSDL.";
            }
        }

        private void dgvChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvChiTieu.Rows.Count) return;

            var row = dgvChiTieu.Rows[e.RowIndex];
            _selectedMaCT = Convert.ToInt32(row.Cells["MaCT"].Value);

            if (DateTime.TryParseExact(row.Cells["NgayChi"].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime d))
            {
                dtpNgayChi.Value = d;
            }

            txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString() ?? string.Empty;
            string loaiChi = row.Cells["LoaiChi"].Value?.ToString() ?? "Khác";
            if (cboLoaiChi.Items.Contains(loaiChi))
            {
                cboLoaiChi.SelectedItem = loaiChi;
            }

            if (decimal.TryParse(row.Cells["SoTien"].Value?.ToString(), out decimal soTien))
            {
                nudSoTien.Value = Math.Min(nudSoTien.Maximum, Math.Max(nudSoTien.Minimum, soTien));
            }

            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? string.Empty;
            lblStatus.Text = $"Đang chọn khoản chi #{_selectedMaCT}";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung chi tiêu!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return false;
            }

            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền chi tiêu phải lớn hơn 0!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoTien.Focus();
                return false;
            }

            if (dtpNgayChi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày chi không được lớn hơn ngày hiện tại!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayChi.Focus();
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var ct = new ChiTieu
                {
                    NgayChi = dtpNgayChi.Value.Date,
                    NoiDung = txtNoiDung.Text.Trim(),
                    LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác",
                    SoTien = nudSoTien.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                using var context = new QLChiTieuDbContext();
                context.ChiTieus.Add(ct);
                await context.SaveChangesAsync();

                Log.Information("Đã thêm mới khoản chi thành công: MaCT={MaCT}, NoiDung='{NoiDung}', SoTien={SoTien}",
                    ct.MaCT, ct.NoiDung, ct.SoTien);

                MessageBox.Show("Thêm khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm mới khoản chi vào CSDL.");
                MessageBox.Show("Không thể lưu khoản chi. Lỗi truy cập CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaCT <= 0)
            {
                MessageBox.Show("Vui lòng chọn khoản chi cần sửa trong danh sách!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                using var context = new QLChiTieuDbContext();
                var ct = await context.ChiTieus.FindAsync(_selectedMaCT);
                if (ct == null)
                {
                    MessageBox.Show("Khoản chi không tồn tại hoặc đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ct.NgayChi = dtpNgayChi.Value.Date;
                ct.NoiDung = txtNoiDung.Text.Trim();
                ct.LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác";
                ct.SoTien = nudSoTien.Value;
                ct.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                await context.SaveChangesAsync();

                Log.Information("Đã cập nhật khoản chi: MaCT={MaCT}, NoiDung='{NoiDung}', SoTien={SoTien}",
                    ct.MaCT, ct.NoiDung, ct.SoTien);

                MessageBox.Show("Cập nhật khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi cập nhật khoản chi MaCT={MaCT}.", _selectedMaCT);
                MessageBox.Show("Không thể cập nhật khoản chi. Lỗi truy cập CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaCT <= 0)
            {
                MessageBox.Show("Vui lòng chọn khoản chi cần xóa trong danh sách!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoản chi #{_selectedMaCT} ({txtNoiDung.Text})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var context = new QLChiTieuDbContext();
                var ct = await context.ChiTieus.FindAsync(_selectedMaCT);
                if (ct != null)
                {
                    context.ChiTieus.Remove(ct);
                    await context.SaveChangesAsync();

                    Log.Information("Đã xóa khoản chi thành công: MaCT={MaCT}", _selectedMaCT);
                }

                MessageBox.Show("Xóa khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa khoản chi MaCT={MaCT}.", _selectedMaCT);
                MessageBox.Show("Không thể xóa khoản chi. Lỗi truy cập CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            _selectedMaCT = 0;
            dtpNgayChi.Value = DateTime.Today;
            txtNoiDung.Clear();
            cboLoaiChi.SelectedIndex = 0;
            nudSoTien.Value = 0;
            txtGhiChu.Clear();
            lblStatus.Text = "Đã làm mới form nhập.";
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimNoiDung.Text.Trim();
            string loaiChi = cboTimLoaiChi.SelectedItem?.ToString() ?? "Tất cả";
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn đến ngày!", "Khoảng thời gian không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await LoadDataAsync(keyword, loaiChi, tuNgay, denNgay);
        }

        private async void btnDatLaiTimKiem_Click(object sender, EventArgs e)
        {
            txtTimNoiDung.Clear();
            cboTimLoaiChi.SelectedIndex = 0;
            var now = DateTime.Today;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now;
            await LoadDataAsync();
        }
    }
}
