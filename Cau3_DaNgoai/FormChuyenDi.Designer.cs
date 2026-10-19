namespace Cau3_DaNgoai
{
    partial class FormChuyenDi
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenChuyen = new System.Windows.Forms.Label();
            this.txtTenChuyen = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.nudSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblNganSach = new System.Windows.Forms.Label();
            this.nudNganSach = new System.Windows.Forms.NumericUpDown();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.chkDaHoanThanh = new System.Windows.Forms.CheckBox();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlThoiTiet = new System.Windows.Forms.Panel();
            this.btnXemThoiTiet = new System.Windows.Forms.Button();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.lblTieuDeThoiTiet = new System.Windows.Forms.Label();
            this.lblIconThoiTiet = new System.Windows.Forms.Label();
            this.lblMoTaThoiTiet = new System.Windows.Forms.Label();
            this.lblNhietDo = new System.Windows.Forms.Label();
            this.lblKhaNangMua = new System.Windows.Forms.Label();
            this.pnlCanhBaoMua = new System.Windows.Forms.Panel();
            this.lblCanhBaoMua = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimDiaDiem = new System.Windows.Forms.TextBox();
            this.chkChiChuaHoanThanh = new System.Windows.Forms.CheckBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlThoiTiet.SuspendLayout();
            this.pnlCanhBaoMua.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.grpThongTin.Controls.Add(this.lblTenChuyen);
            this.grpThongTin.Controls.Add(this.txtTenChuyen);
            this.grpThongTin.Controls.Add(this.lblDiaDiem);
            this.grpThongTin.Controls.Add(this.txtDiaDiem);
            this.grpThongTin.Controls.Add(this.lblNgayDi);
            this.grpThongTin.Controls.Add(this.dtpNgayDi);
            this.grpThongTin.Controls.Add(this.lblSoNguoi);
            this.grpThongTin.Controls.Add(this.nudSoNguoi);
            this.grpThongTin.Controls.Add(this.lblNganSach);
            this.grpThongTin.Controls.Add(this.nudNganSach);
            this.grpThongTin.Controls.Add(this.lblPhuongTien);
            this.grpThongTin.Controls.Add(this.cboPhuongTien);
            this.grpThongTin.Controls.Add(this.chkDaHoanThanh);
            this.grpThongTin.Location = new System.Drawing.Point(12, 45);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(430, 245);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chuyến đi";

            this.lblTenChuyen.AutoSize = true;
            this.lblTenChuyen.Location = new System.Drawing.Point(15, 27);
            this.lblTenChuyen.Name = "lblTenChuyen";
            this.lblTenChuyen.Size = new System.Drawing.Size(77, 17);
            this.lblTenChuyen.TabIndex = 0;
            this.lblTenChuyen.Text = "Tên chuyến:";

            this.txtTenChuyen.Location = new System.Drawing.Point(110, 24);
            this.txtTenChuyen.Name = "txtTenChuyen";
            this.txtTenChuyen.Size = new System.Drawing.Size(305, 24);
            this.txtTenChuyen.TabIndex = 1;

            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(15, 62);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(63, 17);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm:";

            this.txtDiaDiem.Location = new System.Drawing.Point(110, 59);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(305, 24);
            this.txtDiaDiem.TabIndex = 3;

            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(15, 98);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(57, 17);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi:";

            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(110, 95);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(140, 24);
            this.dtpNgayDi.TabIndex = 5;

            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(15, 134);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(64, 17);
            this.lblSoNguoi.TabIndex = 6;
            this.lblSoNguoi.Text = "Số người:";

            this.nudSoNguoi.Location = new System.Drawing.Point(110, 132);
            this.nudSoNguoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoNguoi.Name = "nudSoNguoi";
            this.nudSoNguoi.Size = new System.Drawing.Size(140, 24);
            this.nudSoNguoi.TabIndex = 7;
            this.nudSoNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            this.lblNganSach.AutoSize = true;
            this.lblNganSach.Location = new System.Drawing.Point(15, 170);
            this.lblNganSach.Name = "lblNganSach";
            this.lblNganSach.Size = new System.Drawing.Size(73, 17);
            this.lblNganSach.TabIndex = 8;
            this.lblNganSach.Text = "Ngân sách:";

            this.nudNganSach.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNganSach.Location = new System.Drawing.Point(110, 168);
            this.nudNganSach.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNganSach.Name = "nudNganSach";
            this.nudNganSach.Size = new System.Drawing.Size(140, 24);
            this.nudNganSach.TabIndex = 9;
            this.nudNganSach.ThousandsSeparator = true;

            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Location = new System.Drawing.Point(15, 207);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(83, 17);
            this.lblPhuongTien.TabIndex = 10;
            this.lblPhuongTien.Text = "Phương tiện:";

            this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Items.AddRange(new object[] {
            "Xe máy",
            "Ô tô",
            "Xe khách",
            "Tàu hỏa",
            "Máy bay"});
            this.cboPhuongTien.Location = new System.Drawing.Point(110, 204);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(140, 24);
            this.cboPhuongTien.TabIndex = 11;

            this.chkDaHoanThanh.AutoSize = true;
            this.chkDaHoanThanh.Location = new System.Drawing.Point(270, 206);
            this.chkDaHoanThanh.Name = "chkDaHoanThanh";
            this.chkDaHoanThanh.Size = new System.Drawing.Size(111, 21);
            this.chkDaHoanThanh.TabIndex = 12;
            this.chkDaHoanThanh.Text = "Đã hoàn thành";
            this.chkDaHoanThanh.UseVisualStyleBackColor = true;

            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(12, 296);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(430, 42);
            this.pnlButtons.TabIndex = 1;

            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(104, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(205, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.Location = new System.Drawing.Point(306, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.pnlThoiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThoiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThoiTiet.Controls.Add(this.btnXemThoiTiet);
            this.pnlThoiTiet.Controls.Add(this.prgLoading);
            this.pnlThoiTiet.Controls.Add(this.lblTieuDeThoiTiet);
            this.pnlThoiTiet.Controls.Add(this.lblIconThoiTiet);
            this.pnlThoiTiet.Controls.Add(this.lblMoTaThoiTiet);
            this.pnlThoiTiet.Controls.Add(this.lblNhietDo);
            this.pnlThoiTiet.Controls.Add(this.lblKhaNangMua);
            this.pnlThoiTiet.Controls.Add(this.pnlCanhBaoMua);
            this.pnlThoiTiet.Location = new System.Drawing.Point(455, 52);
            this.pnlThoiTiet.Name = "pnlThoiTiet";
            this.pnlThoiTiet.Size = new System.Drawing.Size(467, 238);
            this.pnlThoiTiet.TabIndex = 2;

            this.btnXemThoiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemThoiTiet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXemThoiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThoiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemThoiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemThoiTiet.Location = new System.Drawing.Point(335, 8);
            this.btnXemThoiTiet.Name = "btnXemThoiTiet";
            this.btnXemThoiTiet.Size = new System.Drawing.Size(120, 32);
            this.btnXemThoiTiet.TabIndex = 0;
            this.btnXemThoiTiet.Text = "Xem thời tiết";
            this.btnXemThoiTiet.UseVisualStyleBackColor = false;
            this.btnXemThoiTiet.Click += new System.EventHandler(this.btnXemThoiTiet_Click);

            this.prgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgLoading.Location = new System.Drawing.Point(12, 45);
            this.prgLoading.MarqueeAnimationSpeed = 30;
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(443, 6);
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgLoading.TabIndex = 1;
            this.prgLoading.Visible = false;

            this.lblTieuDeThoiTiet.AutoSize = true;
            this.lblTieuDeThoiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDeThoiTiet.ForeColor = System.Drawing.Color.DimGray;
            this.lblTieuDeThoiTiet.Location = new System.Drawing.Point(10, 15);
            this.lblTieuDeThoiTiet.Name = "lblTieuDeThoiTiet";
            this.lblTieuDeThoiTiet.Size = new System.Drawing.Size(123, 19);
            this.lblTieuDeThoiTiet.TabIndex = 2;
            this.lblTieuDeThoiTiet.Text = "Dự báo thời tiết:";

            this.lblIconThoiTiet.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIconThoiTiet.Location = new System.Drawing.Point(15, 60);
            this.lblIconThoiTiet.Name = "lblIconThoiTiet";
            this.lblIconThoiTiet.Size = new System.Drawing.Size(100, 100);
            this.lblIconThoiTiet.TabIndex = 3;
            this.lblIconThoiTiet.Text = "⛅";
            this.lblIconThoiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblMoTaThoiTiet.AutoSize = true;
            this.lblMoTaThoiTiet.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoTaThoiTiet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMoTaThoiTiet.Location = new System.Drawing.Point(130, 68);
            this.lblMoTaThoiTiet.Name = "lblMoTaThoiTiet";
            this.lblMoTaThoiTiet.Size = new System.Drawing.Size(109, 25);
            this.lblMoTaThoiTiet.TabIndex = 4;
            this.lblMoTaThoiTiet.Text = "Trời quang";

            this.lblNhietDo.AutoSize = true;
            this.lblNhietDo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhietDo.Location = new System.Drawing.Point(130, 100);
            this.lblNhietDo.Name = "lblNhietDo";
            this.lblNhietDo.Size = new System.Drawing.Size(155, 19);
            this.lblNhietDo.TabIndex = 5;
            this.lblNhietDo.Text = "Nhiệt độ: 20°C - 28°C";

            this.lblKhaNangMua.AutoSize = true;
            this.lblKhaNangMua.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKhaNangMua.Location = new System.Drawing.Point(130, 128);
            this.lblKhaNangMua.Name = "lblKhaNangMua";
            this.lblKhaNangMua.Size = new System.Drawing.Size(130, 19);
            this.lblKhaNangMua.TabIndex = 6;
            this.lblKhaNangMua.Text = "Khả năng mưa: 20%";

            this.pnlCanhBaoMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanhBaoMua.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlCanhBaoMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanhBaoMua.Controls.Add(this.lblCanhBaoMua);
            this.pnlCanhBaoMua.Location = new System.Drawing.Point(12, 185);
            this.pnlCanhBaoMua.Name = "pnlCanhBaoMua";
            this.pnlCanhBaoMua.Size = new System.Drawing.Size(443, 40);
            this.pnlCanhBaoMua.TabIndex = 7;
            this.pnlCanhBaoMua.Visible = false;

            this.lblCanhBaoMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCanhBaoMua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanhBaoMua.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCanhBaoMua.Location = new System.Drawing.Point(0, 0);
            this.lblCanhBaoMua.Name = "lblCanhBaoMua";
            this.lblCanhBaoMua.Size = new System.Drawing.Size(441, 38);
            this.lblCanhBaoMua.TabIndex = 0;
            this.lblCanhBaoMua.Text = "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch";
            this.lblCanhBaoMua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.txtTimDiaDiem);
            this.grpTimKiem.Controls.Add(this.chkChiChuaHoanThanh);
            this.grpTimKiem.Controls.Add(this.lblTuNgay);
            this.grpTimKiem.Controls.Add(this.dtpTuNgay);
            this.grpTimKiem.Controls.Add(this.lblDenNgay);
            this.grpTimKiem.Controls.Add(this.dtpDenNgay);
            this.grpTimKiem.Controls.Add(this.btnTim);
            this.grpTimKiem.Controls.Add(this.btnBoLoc);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 344);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(910, 65);
            this.grpTimKiem.TabIndex = 3;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm / Lọc";

            this.txtTimDiaDiem.Location = new System.Drawing.Point(15, 26);
            this.txtTimDiaDiem.Name = "txtTimDiaDiem";
            this.txtTimDiaDiem.PlaceholderText = "Tìm theo tên hoặc địa điểm...";
            this.txtTimDiaDiem.Size = new System.Drawing.Size(180, 24);
            this.txtTimDiaDiem.TabIndex = 0;

            this.chkChiChuaHoanThanh.AutoSize = true;
            this.chkChiChuaHoanThanh.Location = new System.Drawing.Point(205, 28);
            this.chkChiChuaHoanThanh.Name = "chkChiChuaHoanThanh";
            this.chkChiChuaHoanThanh.Size = new System.Drawing.Size(193, 21);
            this.chkChiChuaHoanThanh.TabIndex = 1;
            this.chkChiChuaHoanThanh.Text = "Chỉ hiện chuyến chưa hoàn thành";
            this.chkChiChuaHoanThanh.UseVisualStyleBackColor = true;

            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(405, 29);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(26, 17);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ:";

            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(435, 26);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpTuNgay.TabIndex = 3;

            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(555, 29);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(34, 17);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến:";

            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(595, 26);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpDenNgay.TabIndex = 5;

            this.btnTim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(715, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(85, 32);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.btnBoLoc.BackColor = System.Drawing.Color.LightGray;
            this.btnBoLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoLoc.Location = new System.Drawing.Point(806, 22);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(85, 32);
            this.btnBoLoc.TabIndex = 7;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = false;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);

            this.dgvChuyenDi.AllowUserToAddRows = false;
            this.dgvChuyenDi.AllowUserToDeleteRows = false;
            this.dgvChuyenDi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Location = new System.Drawing.Point(12, 415);
            this.dgvChuyenDi.MultiSelect = false;
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.ReadOnly = true;
            this.dgvChuyenDi.RowHeadersVisible = false;
            this.dgvChuyenDi.RowTemplate.Height = 26;
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(910, 195);
            this.dgvChuyenDi.TabIndex = 4;
            this.dgvChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDi_CellClick);

            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblNgonNgu);
            this.pnlTopBar.Controls.Add(this.cboNgonNgu);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(934, 40);
            this.pnlTopBar.TabIndex = 5;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kế hoạch dã ngoại cuối tuần";

            this.lblNgonNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Location = new System.Drawing.Point(670, 12);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(71, 17);
            this.lblNgonNgu.TabIndex = 1;
            this.lblNgonNgu.Text = "Ngôn ngữ:";

            this.cboNgonNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgonNgu.FormattingEnabled = true;
            this.cboNgonNgu.Items.AddRange(new object[] {
            "Tiếng Việt",
            "English"});
            this.cboNgonNgu.Location = new System.Drawing.Point(747, 9);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(175, 24);
            this.cboNgonNgu.TabIndex = 2;
            this.cboNgonNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgonNgu_SelectedIndexChanged);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Sẵn sàng";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.pnlThoiTiet);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 680);
            this.Name = "FormChuyenDi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế hoạch dã ngoại";
            this.Load += new System.EventHandler(this.FormChuyenDi_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlThoiTiet.ResumeLayout(false);
            this.pnlThoiTiet.PerformLayout();
            this.pnlCanhBaoMua.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenChuyen;
        private System.Windows.Forms.TextBox txtTenChuyen;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown nudSoNguoi;
        private System.Windows.Forms.Label lblNganSach;
        private System.Windows.Forms.NumericUpDown nudNganSach;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.CheckBox chkDaHoanThanh;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlThoiTiet;
        private System.Windows.Forms.Button btnXemThoiTiet;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Label lblTieuDeThoiTiet;
        private System.Windows.Forms.Label lblIconThoiTiet;
        private System.Windows.Forms.Label lblMoTaThoiTiet;
        private System.Windows.Forms.Label lblNhietDo;
        private System.Windows.Forms.Label lblKhaNangMua;
        private System.Windows.Forms.Panel pnlCanhBaoMua;
        private System.Windows.Forms.Label lblCanhBaoMua;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtTimDiaDiem;
        private System.Windows.Forms.CheckBox chkChiChuaHoanThanh;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNgonNgu;
        private System.Windows.Forms.ComboBox cboNgonNgu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
