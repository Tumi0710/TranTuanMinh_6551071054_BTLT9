using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Cau4_TraSua.Models;

namespace Cau4_TraSua
{
    public partial class FormThucDon : Form
    {
        private int _selectedMaMon = 0;

        public FormThucDon()
        {
            InitializeComponent();
        }

        private async void FormThucDon_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
            await LoadDataAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            try
            {
                using var context = new QLTraSuaDbContext();
                var categories = await context.DanhMucMons.AsNoTracking().ToListAsync();

                cboDanhMuc.Items.Clear();
                cboLocDM.Items.Clear();
                cboLocDM.Items.Add("Tất cả");

                foreach (var c in categories)
                {
                    cboDanhMuc.Items.Add(c);
                    cboLocDM.Items.Add(c.TenDM);
                }

                if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;
                cboLocDM.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh mục.");
            }
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using var context = new QLTraSuaDbContext();
                var query = context.MonUongs.Include(m => m.DanhMucMon).AsNoTracking().AsQueryable();

                string keyword = txtTimTen.Text.Trim();
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query = query.Where(m => m.TenMon.Contains(keyword));
                }

                string locDM = cboLocDM.SelectedItem?.ToString() ?? "Tất cả";
                if (locDM != "Tất cả")
                {
                    query = query.Where(m => m.DanhMucMon != null && m.DanhMucMon.TenDM == locDM);
                }

                var list = await query.ToListAsync();

                dgvMon.Columns.Clear();
                dgvMon.AutoGenerateColumns = false;

                dgvMon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaMon", HeaderText = "Mã", Name = "MaMon", Width = 50 });
                dgvMon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenMon", HeaderText = "Tên món", Name = "TenMon", Width = 150 });
                dgvMon.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDM", HeaderText = "Danh mục", Name = "TenDM", Width = 100 });
                dgvMon.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GiaBan",
                    HeaderText = "Giá bán",
                    Name = "GiaBan",
                    Width = 90,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
                });
                dgvMon.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "DangBan", HeaderText = "Đang bán", Name = "DangBan", Width = 70 });

                dgvMon.DataSource = list.Select(m => new
                {
                    MaMon = m.MaMon,
                    TenMon = m.TenMon,
                    TenDM = m.DanhMucMon?.TenDM ?? "",
                    GiaBan = m.GiaBan,
                    DangBan = m.DangBan
                }).ToList();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp dữ liệu món uống.");
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvMon.Rows.Count) return;

            var row = dgvMon.Rows[e.RowIndex];
            _selectedMaMon = Convert.ToInt32(row.Cells["MaMon"].Value);
            txtTenMon.Text = row.Cells["TenMon"].Value?.ToString() ?? "";
            string dm = row.Cells["TenDM"].Value?.ToString() ?? "";
            for (int i = 0; i < cboDanhMuc.Items.Count; i++)
            {
                if (cboDanhMuc.Items[i] is DanhMucMon cat && cat.TenDM == dm)
                {
                    cboDanhMuc.SelectedIndex = i;
                    break;
                }
            }

            nudGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value);
            chkDangBan.Checked = Convert.ToBoolean(row.Cells["DangBan"].Value);
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDanhMuc.SelectedItem is not DanhMucMon cat) return;

            try
            {
                var mon = new MonUong
                {
                    TenMon = txtTenMon.Text.Trim(),
                    GiaBan = nudGiaBan.Value,
                    DangBan = chkDangBan.Checked,
                    MaDM = cat.MaDM
                };

                using var context = new QLTraSuaDbContext();
                context.MonUongs.Add(mon);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm món mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi thêm món.");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaMon <= 0)
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDanhMuc.SelectedItem is not DanhMucMon cat) return;

            try
            {
                using var context = new QLTraSuaDbContext();
                var mon = await context.MonUongs.FindAsync(_selectedMaMon);
                if (mon != null)
                {
                    mon.TenMon = txtTenMon.Text.Trim();
                    mon.GiaBan = nudGiaBan.Value;
                    mon.DangBan = chkDangBan.Checked;
                    mon.MaDM = cat.MaDM;
                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi cập nhật món.");
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaMon <= 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa món '{txtTenMon.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var context = new QLTraSuaDbContext();
                var mon = await context.MonUongs.FindAsync(_selectedMaMon);
                if (mon != null)
                {
                    context.MonUongs.Remove(mon);
                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Đã xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa món.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            _selectedMaMon = 0;
            txtTenMon.Clear();
            nudGiaBan.Value = 25000;
            chkDangBan.Checked = true;
            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;
        }

        private async void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void cboLocDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimTen.Clear();
            cboLocDM.SelectedIndex = 0;
            await LoadDataAsync();
        }
    }
}
