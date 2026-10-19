namespace Cau4_TraSua
{
    partial class FormBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.grpChonMon = new System.Windows.Forms.GroupBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lstMon = new System.Windows.Forms.ListBox();
            this.lblSoLy = new System.Windows.Forms.Label();
            this.nudSoLy = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            this.btnMoThucDon = new System.Windows.Forms.Button();
            this.grpDonHienTai = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnChuyenKhoan = new System.Windows.Forms.Button();
            this.btnTienMat = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblInfoNganHang = new System.Windows.Forms.Label();
            this.lblSoTienQR = new System.Windows.Forms.Label();
            this.lblNoiDungQR = new System.Windows.Forms.Label();
            this.btnDaNhanTien = new System.Windows.Forms.Button();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.pnlLocHD = new System.Windows.Forms.Panel();
            this.lblLocNgay = new System.Windows.Forms.Label();
            this.dtpLocNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.lblDoanhThuNgay = new System.Windows.Forms.Label();
            this.splitContainerHD = new System.Windows.Forms.SplitContainer();
            this.grpDSHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.grpChiTietHD = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain.SuspendLayout();
            this.tabBanHang.SuspendLayout();
            this.grpChonMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).BeginInit();
            this.grpDonHienTai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.tabHoaDon.SuspendLayout();
            this.pnlLocHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHD)).BeginInit();
            this.splitContainerHD.Panel1.SuspendLayout();
            this.splitContainerHD.Panel2.SuspendLayout();
            this.splitContainerHD.SuspendLayout();
            this.grpDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grpChiTietHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.tabMain.Controls.Add(this.tabBanHang);
            this.tabMain.Controls.Add(this.tabHoaDon);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1008, 659);
            this.tabMain.TabIndex = 0;

            this.tabBanHang.Controls.Add(this.grpChonMon);
            this.tabBanHang.Controls.Add(this.grpDonHienTai);
            this.tabBanHang.Controls.Add(this.grpThanhToan);
            this.tabBanHang.Location = new System.Drawing.Point(4, 26);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanHang.Size = new System.Drawing.Size(1000, 629);
            this.tabBanHang.TabIndex = 0;
            this.tabBanHang.Text = "Bán hàng (POS)";
            this.tabBanHang.UseVisualStyleBackColor = true;

            this.grpChonMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpChonMon.Controls.Add(this.lblDanhMuc);
            this.grpChonMon.Controls.Add(this.cboDanhMuc);
            this.grpChonMon.Controls.Add(this.lstMon);
            this.grpChonMon.Controls.Add(this.lblSoLy);
            this.grpChonMon.Controls.Add(this.nudSoLy);
            this.grpChonMon.Controls.Add(this.btnThemVaoDon);
            this.grpChonMon.Controls.Add(this.btnMoThucDon);
            this.grpChonMon.Location = new System.Drawing.Point(8, 6);
            this.grpChonMon.Name = "grpChonMon";
            this.grpChonMon.Size = new System.Drawing.Size(260, 617);
            this.grpChonMon.TabIndex = 0;
            this.grpChonMon.TabStop = false;
            this.grpChonMon.Text = "Chọn món";

            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(10, 25);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(70, 17);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục:";

            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(10, 48);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(240, 24);
            this.cboDanhMuc.TabIndex = 1;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);

            this.lstMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMon.FormattingEnabled = true;
            this.lstMon.ItemHeight = 17;
            this.lstMon.Location = new System.Drawing.Point(10, 80);
            this.lstMon.Name = "lstMon";
            this.lstMon.Size = new System.Drawing.Size(240, 412);
            this.lstMon.TabIndex = 2;

            this.lblSoLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoLy.AutoSize = true;
            this.lblSoLy.Location = new System.Drawing.Point(10, 508);
            this.lblSoLy.Name = "lblSoLy";
            this.lblSoLy.Size = new System.Drawing.Size(40, 17);
            this.lblSoLy.TabIndex = 3;
            this.lblSoLy.Text = "Số ly:";

            this.nudSoLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSoLy.Location = new System.Drawing.Point(55, 505);
            this.nudSoLy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLy.Name = "nudSoLy";
            this.nudSoLy.Size = new System.Drawing.Size(65, 24);
            this.nudSoLy.TabIndex = 4;
            this.nudSoLy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            this.btnThemVaoDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemVaoDon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemVaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemVaoDon.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoDon.Location = new System.Drawing.Point(10, 538);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(240, 36);
            this.btnThemVaoDon.TabIndex = 5;
            this.btnThemVaoDon.Text = "Thêm vào đơn";
            this.btnThemVaoDon.UseVisualStyleBackColor = false;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);

            this.btnMoThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoThucDon.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMoThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoThucDon.ForeColor = System.Drawing.Color.White;
            this.btnMoThucDon.Location = new System.Drawing.Point(10, 580);
            this.btnMoThucDon.Name = "btnMoThucDon";
            this.btnMoThucDon.Size = new System.Drawing.Size(240, 28);
            this.btnMoThucDon.TabIndex = 6;
            this.btnMoThucDon.Text = "Quản lý thực đơn";
            this.btnMoThucDon.UseVisualStyleBackColor = false;
            this.btnMoThucDon.Click += new System.EventHandler(this.btnMoThucDon_Click);

            this.grpDonHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDonHienTai.Controls.Add(this.dgvGioHang);
            this.grpDonHienTai.Controls.Add(this.btnXoaDong);
            this.grpDonHienTai.Controls.Add(this.btnHuyDon);
            this.grpDonHienTai.Controls.Add(this.lblTongTien);
            this.grpDonHienTai.Location = new System.Drawing.Point(274, 6);
            this.grpDonHienTai.Name = "grpDonHienTai";
            this.grpDonHienTai.Size = new System.Drawing.Size(430, 617);
            this.grpDonHienTai.TabIndex = 1;
            this.grpDonHienTai.TabStop = false;
            this.grpDonHienTai.Text = "Đơn hiện tại";

            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(10, 25);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowTemplate.Height = 26;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(410, 500);
            this.dgvGioHang.TabIndex = 0;

            this.btnXoaDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaDong.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoaDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaDong.Location = new System.Drawing.Point(10, 538);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(100, 32);
            this.btnXoaDong.TabIndex = 1;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = false;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);

            this.btnHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyDon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Location = new System.Drawing.Point(116, 538);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(100, 32);
            this.btnHuyDon.TabIndex = 2;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);

            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongTien.Location = new System.Drawing.Point(10, 575);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(410, 35);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.grpThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThanhToan.Controls.Add(this.btnChuyenKhoan);
            this.grpThanhToan.Controls.Add(this.btnTienMat);
            this.grpThanhToan.Controls.Add(this.picQR);
            this.grpThanhToan.Controls.Add(this.lblInfoNganHang);
            this.grpThanhToan.Controls.Add(this.lblSoTienQR);
            this.grpThanhToan.Controls.Add(this.lblNoiDungQR);
            this.grpThanhToan.Controls.Add(this.btnDaNhanTien);
            this.grpThanhToan.Location = new System.Drawing.Point(710, 6);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(282, 617);
            this.grpThanhToan.TabIndex = 2;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh toán";

            this.btnChuyenKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenKhoan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnChuyenKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenKhoan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChuyenKhoan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenKhoan.Location = new System.Drawing.Point(12, 24);
            this.btnChuyenKhoan.Name = "btnChuyenKhoan";
            this.btnChuyenKhoan.Size = new System.Drawing.Size(260, 36);
            this.btnChuyenKhoan.TabIndex = 0;
            this.btnChuyenKhoan.Text = "Thanh toán chuyển khoản";
            this.btnChuyenKhoan.UseVisualStyleBackColor = false;
            this.btnChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click);

            this.btnTienMat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTienMat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTienMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienMat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTienMat.ForeColor = System.Drawing.Color.White;
            this.btnTienMat.Location = new System.Drawing.Point(12, 66);
            this.btnTienMat.Name = "btnTienMat";
            this.btnTienMat.Size = new System.Drawing.Size(260, 36);
            this.btnTienMat.TabIndex = 1;
            this.btnTienMat.Text = "Thanh toán tiền mặt";
            this.btnTienMat.UseVisualStyleBackColor = false;
            this.btnTienMat.Click += new System.EventHandler(this.btnTienMat_Click);

            this.picQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(12, 110);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(260, 260);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;

            this.lblInfoNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoNganHang.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoNganHang.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoNganHang.Location = new System.Drawing.Point(12, 380);
            this.lblInfoNganHang.Name = "lblInfoNganHang";
            this.lblInfoNganHang.Size = new System.Drawing.Size(260, 50);
            this.lblInfoNganHang.TabIndex = 3;
            this.lblInfoNganHang.Text = "Ngân hàng: VIETCOMBANK\r\nSTK: 1234567890\r\nChủ TK: NGUYEN VAN QUAN";
            this.lblInfoNganHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSoTienQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoTienQR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoTienQR.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSoTienQR.Location = new System.Drawing.Point(12, 435);
            this.lblSoTienQR.Name = "lblSoTienQR";
            this.lblSoTienQR.Size = new System.Drawing.Size(260, 22);
            this.lblSoTienQR.TabIndex = 4;
            this.lblSoTienQR.Text = "Số tiền: 0 đ";
            this.lblSoTienQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNoiDungQR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiDungQR.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoiDungQR.Location = new System.Drawing.Point(12, 462);
            this.lblNoiDungQR.Name = "lblNoiDungQR";
            this.lblNoiDungQR.Size = new System.Drawing.Size(260, 40);
            this.lblNoiDungQR.TabIndex = 5;
            this.lblNoiDungQR.Text = "Nội dung: TRASUA";
            this.lblNoiDungQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnDaNhanTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaNhanTien.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDaNhanTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaNhanTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDaNhanTien.ForeColor = System.Drawing.Color.White;
            this.btnDaNhanTien.Location = new System.Drawing.Point(12, 538);
            this.btnDaNhanTien.Name = "btnDaNhanTien";
            this.btnDaNhanTien.Size = new System.Drawing.Size(260, 50);
            this.btnDaNhanTien.TabIndex = 6;
            this.btnDaNhanTien.Text = "Đã nhận tiền";
            this.btnDaNhanTien.UseVisualStyleBackColor = false;
            this.btnDaNhanTien.Click += new System.EventHandler(this.btnDaNhanTien_Click);

            this.tabHoaDon.Controls.Add(this.splitContainerHD);
            this.tabHoaDon.Controls.Add(this.pnlLocHD);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 26);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1000, 629);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "Danh sách hóa đơn & Doanh thu";
            this.tabHoaDon.UseVisualStyleBackColor = true;

            this.pnlLocHD.Controls.Add(this.lblLocNgay);
            this.pnlLocHD.Controls.Add(this.dtpLocNgay);
            this.pnlLocHD.Controls.Add(this.btnXemDoanhThu);
            this.pnlLocHD.Controls.Add(this.lblDoanhThuNgay);
            this.pnlLocHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocHD.Location = new System.Drawing.Point(3, 3);
            this.pnlLocHD.Name = "pnlLocHD";
            this.pnlLocHD.Size = new System.Drawing.Size(994, 50);
            this.pnlLocHD.TabIndex = 0;

            this.lblLocNgay.AutoSize = true;
            this.lblLocNgay.Location = new System.Drawing.Point(10, 16);
            this.lblLocNgay.Name = "lblLocNgay";
            this.lblLocNgay.Size = new System.Drawing.Size(65, 17);
            this.lblLocNgay.TabIndex = 0;
            this.lblLocNgay.Text = "Xem ngày:";

            this.dtpLocNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpLocNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocNgay.Location = new System.Drawing.Point(85, 13);
            this.dtpLocNgay.Name = "dtpLocNgay";
            this.dtpLocNgay.Size = new System.Drawing.Size(130, 24);
            this.dtpLocNgay.TabIndex = 1;
            this.dtpLocNgay.ValueChanged += new System.EventHandler(this.dtpLocNgay_ValueChanged);

            this.btnXemDoanhThu.Location = new System.Drawing.Point(225, 10);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(95, 30);
            this.btnXemDoanhThu.TabIndex = 2;
            this.btnXemDoanhThu.Text = "Làm mới";
            this.btnXemDoanhThu.UseVisualStyleBackColor = true;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);

            this.lblDoanhThuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoanhThuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThuNgay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDoanhThuNgay.Location = new System.Drawing.Point(580, 13);
            this.lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            this.lblDoanhThuNgay.Size = new System.Drawing.Size(400, 25);
            this.lblDoanhThuNgay.TabIndex = 3;
            this.lblDoanhThuNgay.Text = "Doanh thu ngày: 0 đ";
            this.lblDoanhThuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.splitContainerHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHD.Location = new System.Drawing.Point(3, 53);
            this.splitContainerHD.Name = "splitContainerHD";

            this.splitContainerHD.Panel1.Controls.Add(this.grpDSHoaDon);
            this.splitContainerHD.Panel2.Controls.Add(this.grpChiTietHD);
            this.splitContainerHD.Size = new System.Drawing.Size(994, 573);
            this.splitContainerHD.SplitterDistance = 530;
            this.splitContainerHD.TabIndex = 1;

            this.grpDSHoaDon.Controls.Add(this.dgvHoaDon);
            this.grpDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSHoaDon.Location = new System.Drawing.Point(0, 0);
            this.grpDSHoaDon.Name = "grpDSHoaDon";
            this.grpDSHoaDon.Size = new System.Drawing.Size(530, 573);
            this.grpDSHoaDon.TabIndex = 0;
            this.grpDSHoaDon.TabStop = false;
            this.grpDSHoaDon.Text = "Hóa đơn trong ngày";

            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 20);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 26;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(524, 550);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);

            this.grpChiTietHD.Controls.Add(this.dgvChiTietHD);
            this.grpChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTietHD.Location = new System.Drawing.Point(0, 0);
            this.grpChiTietHD.Name = "grpChiTietHD";
            this.grpChiTietHD.Size = new System.Drawing.Size(460, 573);
            this.grpChiTietHD.TabIndex = 0;
            this.grpChiTietHD.TabStop = false;
            this.grpChiTietHD.Text = "Chi tiết các món";

            this.dgvChiTietHD.AllowUserToAddRows = false;
            this.dgvChiTietHD.AllowUserToDeleteRows = false;
            this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHD.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTietHD.MultiSelect = false;
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.RowHeadersVisible = false;
            this.dgvChiTietHD.RowTemplate.Height = 26;
            this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHD.Size = new System.Drawing.Size(454, 550);
            this.dgvChiTietHD.TabIndex = 0;

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Sẵn sàng";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng - Quán trà sữa";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.tabMain.ResumeLayout(false);
            this.tabBanHang.ResumeLayout(false);
            this.grpChonMon.ResumeLayout(false);
            this.grpChonMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).EndInit();
            this.grpDonHienTai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.tabHoaDon.ResumeLayout(false);
            this.pnlLocHD.ResumeLayout(false);
            this.pnlLocHD.PerformLayout();
            this.splitContainerHD.Panel1.ResumeLayout(false);
            this.splitContainerHD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHD)).EndInit();
            this.splitContainerHD.ResumeLayout(false);
            this.grpDSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grpChiTietHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.GroupBox grpChonMon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.ListBox lstMon;
        private System.Windows.Forms.Label lblSoLy;
        private System.Windows.Forms.NumericUpDown nudSoLy;
        private System.Windows.Forms.Button btnThemVaoDon;
        private System.Windows.Forms.Button btnMoThucDon;
        private System.Windows.Forms.GroupBox grpDonHienTai;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Button btnChuyenKhoan;
        private System.Windows.Forms.Button btnTienMat;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblInfoNganHang;
        private System.Windows.Forms.Label lblSoTienQR;
        private System.Windows.Forms.Label lblNoiDungQR;
        private System.Windows.Forms.Button btnDaNhanTien;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.Panel pnlLocHD;
        private System.Windows.Forms.Label lblLocNgay;
        private System.Windows.Forms.DateTimePicker dtpLocNgay;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuNgay;
        private System.Windows.Forms.SplitContainer splitContainerHD;
        private System.Windows.Forms.GroupBox grpDSHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grpChiTietHD;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
