namespace Cau1_ChiTieu
{
    partial class FormChiTieu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblNgayChi = new System.Windows.Forms.Label();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.lblLoaiChi = new System.Windows.Forms.Label();
            this.cboLoaiChi = new System.Windows.Forms.ComboBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimNoiDung = new System.Windows.Forms.Label();
            this.txtTimNoiDung = new System.Windows.Forms.TextBox();
            this.lblTimLoaiChi = new System.Windows.Forms.Label();
            this.cboTimLoaiChi = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnDatLaiTimKiem = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvChiTieu = new System.Windows.Forms.DataGridView();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.grpThongTin.Controls.Add(this.lblNgayChi);
            this.grpThongTin.Controls.Add(this.dtpNgayChi);
            this.grpThongTin.Controls.Add(this.lblLoaiChi);
            this.grpThongTin.Controls.Add(this.cboLoaiChi);
            this.grpThongTin.Controls.Add(this.lblNoiDung);
            this.grpThongTin.Controls.Add(this.txtNoiDung);
            this.grpThongTin.Controls.Add(this.lblSoTien);
            this.grpThongTin.Controls.Add(this.nudSoTien);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(430, 205);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin khoản chi";

            this.lblNgayChi.AutoSize = true;
            this.lblNgayChi.Location = new System.Drawing.Point(15, 27);
            this.lblNgayChi.Name = "lblNgayChi";
            this.lblNgayChi.Size = new System.Drawing.Size(63, 17);
            this.lblNgayChi.TabIndex = 0;
            this.lblNgayChi.Text = "Ngày chi:";

            this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChi.Location = new System.Drawing.Point(85, 24);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(125, 24);
            this.dtpNgayChi.TabIndex = 1;

            this.lblLoaiChi.AutoSize = true;
            this.lblLoaiChi.Location = new System.Drawing.Point(220, 27);
            this.lblLoaiChi.Name = "lblLoaiChi";
            this.lblLoaiChi.Size = new System.Drawing.Size(56, 17);
            this.lblLoaiChi.TabIndex = 2;
            this.lblLoaiChi.Text = "Loại chi:";

            this.cboLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiChi.FormattingEnabled = true;
            this.cboLoaiChi.Items.AddRange(new object[] {
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
            this.cboLoaiChi.Location = new System.Drawing.Point(282, 24);
            this.cboLoaiChi.Name = "cboLoaiChi";
            this.cboLoaiChi.Size = new System.Drawing.Size(135, 24);
            this.cboLoaiChi.TabIndex = 3;

            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(15, 62);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(66, 17);
            this.lblNoiDung.TabIndex = 4;
            this.lblNoiDung.Text = "Nội dung:";

            this.txtNoiDung.Location = new System.Drawing.Point(85, 59);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(125, 24);
            this.txtNoiDung.TabIndex = 5;

            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(220, 62);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(51, 17);
            this.lblSoTien.TabIndex = 6;
            this.lblSoTien.Text = "Số tiền:";

            this.nudSoTien.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoTien.Location = new System.Drawing.Point(282, 59);
            this.nudSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(135, 24);
            this.nudSoTien.TabIndex = 7;
            this.nudSoTien.ThousandsSeparator = true;

            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 99);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú:";

            this.txtGhiChu.Location = new System.Drawing.Point(85, 96);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(332, 95);
            this.txtGhiChu.TabIndex = 9;

            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblTimNoiDung);
            this.grpTimKiem.Controls.Add(this.txtTimNoiDung);
            this.grpTimKiem.Controls.Add(this.lblTimLoaiChi);
            this.grpTimKiem.Controls.Add(this.cboTimLoaiChi);
            this.grpTimKiem.Controls.Add(this.lblTuNgay);
            this.grpTimKiem.Controls.Add(this.dtpTuNgay);
            this.grpTimKiem.Controls.Add(this.lblDenNgay);
            this.grpTimKiem.Controls.Add(this.dtpDenNgay);
            this.grpTimKiem.Controls.Add(this.btnTim);
            this.grpTimKiem.Controls.Add(this.btnDatLaiTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTimKiem.Location = new System.Drawing.Point(455, 12);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(437, 205);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm / Lọc";

            this.lblTimNoiDung.AutoSize = true;
            this.lblTimNoiDung.Location = new System.Drawing.Point(16, 27);
            this.lblTimNoiDung.Name = "lblTimNoiDung";
            this.lblTimNoiDung.Size = new System.Drawing.Size(66, 17);
            this.lblTimNoiDung.TabIndex = 0;
            this.lblTimNoiDung.Text = "Nội dung:";

            this.txtTimNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimNoiDung.Location = new System.Drawing.Point(88, 24);
            this.txtTimNoiDung.Name = "txtTimNoiDung";
            this.txtTimNoiDung.PlaceholderText = "Nhập nội dung cần tìm...";
            this.txtTimNoiDung.Size = new System.Drawing.Size(335, 24);
            this.txtTimNoiDung.TabIndex = 1;

            this.lblTimLoaiChi.AutoSize = true;
            this.lblTimLoaiChi.Location = new System.Drawing.Point(16, 62);
            this.lblTimLoaiChi.Name = "lblTimLoaiChi";
            this.lblTimLoaiChi.Size = new System.Drawing.Size(56, 17);
            this.lblTimLoaiChi.TabIndex = 2;
            this.lblTimLoaiChi.Text = "Loại chi:";

            this.cboTimLoaiChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimLoaiChi.FormattingEnabled = true;
            this.cboTimLoaiChi.Items.AddRange(new object[] {
            "Tất cả",
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
            this.cboTimLoaiChi.Location = new System.Drawing.Point(88, 59);
            this.cboTimLoaiChi.Name = "cboTimLoaiChi";
            this.cboTimLoaiChi.Size = new System.Drawing.Size(335, 24);
            this.cboTimLoaiChi.TabIndex = 3;

            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(16, 100);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(58, 17);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ ngày:";

            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(88, 97);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(130, 24);
            this.dtpTuNgay.TabIndex = 5;

            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(226, 100);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(66, 17);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";

            this.dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(298, 97);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(125, 24);
            this.dtpDenNgay.TabIndex = 7;

            this.btnTim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(88, 145);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 35);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.btnDatLaiTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.btnDatLaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiTimKiem.Location = new System.Drawing.Point(200, 145);
            this.btnDatLaiTimKiem.Name = "btnDatLaiTimKiem";
            this.btnDatLaiTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btnDatLaiTimKiem.TabIndex = 9;
            this.btnDatLaiTimKiem.Text = "Bỏ lọc";
            this.btnDatLaiTimKiem.UseVisualStyleBackColor = false;
            this.btnDatLaiTimKiem.Click += new System.EventHandler(this.btnDatLaiTimKiem_Click);

            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(12, 225);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(430, 42);
            this.pnlButtons.TabIndex = 2;

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
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(306, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.dgvChiTieu.AllowUserToAddRows = false;
            this.dgvChiTieu.AllowUserToDeleteRows = false;
            this.dgvChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTieu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTieu.Location = new System.Drawing.Point(12, 275);
            this.dgvChiTieu.MultiSelect = false;
            this.dgvChiTieu.Name = "dgvChiTieu";
            this.dgvChiTieu.ReadOnly = true;
            this.dgvChiTieu.RowHeadersVisible = false;
            this.dgvChiTieu.RowTemplate.Height = 26;
            this.dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTieu.Size = new System.Drawing.Size(880, 260);
            this.dgvChiTieu.TabIndex = 3;
            this.dgvChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieu_CellClick);

            this.lblTongChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongChi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongChi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongChi.Location = new System.Drawing.Point(455, 542);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(437, 30);
            this.lblTongChi.TabIndex = 4;
            this.lblTongChi.Text = "Tổng chi: 0 đ";
            this.lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.Text = "Sẵn sàng";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTongChi);
            this.Controls.Add(this.dgvChiTieu);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(920, 638);
            this.Name = "FormChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ chi tiêu cá nhân";
            this.Load += new System.EventHandler(this.FormChiTieu_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.Label lblLoaiChi;
        private System.Windows.Forms.ComboBox cboLoaiChi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimNoiDung;
        private System.Windows.Forms.TextBox txtTimNoiDung;
        private System.Windows.Forms.Label lblTimLoaiChi;
        private System.Windows.Forms.ComboBox cboTimLoaiChi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDatLaiTimKiem;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
