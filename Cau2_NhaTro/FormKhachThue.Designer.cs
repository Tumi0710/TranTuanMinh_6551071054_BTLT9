namespace Cau2_NhaTro
{
    partial class FormKhachThue
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblTinhThanh = new System.Windows.Forms.Label();
            this.cboTinhThanh = new System.Windows.Forms.ComboBox();
            this.lblPhuongXa = new System.Windows.Forms.Label();
            this.cboPhuongXa = new System.Windows.Forms.ComboBox();
            this.chkTamTru = new System.Windows.Forms.CheckBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimText = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTimPhong = new System.Windows.Forms.Label();
            this.cboTimPhong = new System.Windows.Forms.ComboBox();
            this.lblTimTinh = new System.Windows.Forms.Label();
            this.cboTimTinh = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnGayLoi = new System.Windows.Forms.Button();
            this.dgvKhachThue = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpThongTin.SuspendLayout();
            this.grpGioiTinh.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.grpGioiTinh);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblSDT);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.cboPhong);
            this.grpThongTin.Controls.Add(this.lblTinhThanh);
            this.grpThongTin.Controls.Add(this.cboTinhThanh);
            this.grpThongTin.Controls.Add(this.lblPhuongXa);
            this.grpThongTin.Controls.Add(this.cboPhuongXa);
            this.grpThongTin.Controls.Add(this.chkTamTru);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(430, 290);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin khách thuê";

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";

            this.txtHoTen.Location = new System.Drawing.Point(100, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(315, 24);
            this.txtHoTen.TabIndex = 1;

            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(100, 52);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(315, 40);
            this.grpGioiTinh.TabIndex = 2;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";

            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(40, 15);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(54, 21);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;

            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(160, 15);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(44, 21);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(12, 103);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh:";

            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 98);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 24);
            this.dtpNgaySinh.TabIndex = 4;

            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(12, 137);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số điện thoại:";

            this.txtSDT.Location = new System.Drawing.Point(100, 134);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(315, 24);
            this.txtSDT.TabIndex = 6;

            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(12, 171);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(48, 17);
            this.lblPhong.TabIndex = 7;
            this.lblPhong.Text = "Phòng:";

            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(100, 168);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(315, 24);
            this.cboPhong.TabIndex = 8;

            this.lblTinhThanh.AutoSize = true;
            this.lblTinhThanh.Location = new System.Drawing.Point(12, 206);
            this.lblTinhThanh.Name = "lblTinhThanh";
            this.lblTinhThanh.Size = new System.Drawing.Size(73, 17);
            this.lblTinhThanh.TabIndex = 9;
            this.lblTinhThanh.Text = "Tỉnh/Thành:";

            this.cboTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhThanh.FormattingEnabled = true;
            this.cboTinhThanh.Location = new System.Drawing.Point(100, 202);
            this.cboTinhThanh.Name = "cboTinhThanh";
            this.cboTinhThanh.Size = new System.Drawing.Size(315, 24);
            this.cboTinhThanh.TabIndex = 10;
            this.cboTinhThanh.SelectedIndexChanged += new System.EventHandler(this.cboTinhThanh_SelectedIndexChanged);

            this.lblPhuongXa.AutoSize = true;
            this.lblPhuongXa.Location = new System.Drawing.Point(12, 240);
            this.lblPhuongXa.Name = "lblPhuongXa";
            this.lblPhuongXa.Size = new System.Drawing.Size(76, 17);
            this.lblPhuongXa.TabIndex = 11;
            this.lblPhuongXa.Text = "Phường/Xã:";

            this.cboPhuongXa.FormattingEnabled = true;
            this.cboPhuongXa.Location = new System.Drawing.Point(100, 237);
            this.cboPhuongXa.Name = "cboPhuongXa";
            this.cboPhuongXa.Size = new System.Drawing.Size(315, 24);
            this.cboPhuongXa.TabIndex = 12;

            this.chkTamTru.AutoSize = true;
            this.chkTamTru.Location = new System.Drawing.Point(100, 267);
            this.chkTamTru.Name = "chkTamTru";
            this.chkTamTru.Size = new System.Drawing.Size(147, 21);
            this.chkTamTru.TabIndex = 13;
            this.chkTamTru.Text = "Đã đăng ký tạm trú";
            this.chkTamTru.UseVisualStyleBackColor = true;

            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblTimText);
            this.grpTimKiem.Controls.Add(this.txtTim);
            this.grpTimKiem.Controls.Add(this.lblTimPhong);
            this.grpTimKiem.Controls.Add(this.cboTimPhong);
            this.grpTimKiem.Controls.Add(this.lblTimTinh);
            this.grpTimKiem.Controls.Add(this.cboTimTinh);
            this.grpTimKiem.Controls.Add(this.btnTim);
            this.grpTimKiem.Controls.Add(this.btnBoLoc);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTimKiem.Location = new System.Drawing.Point(455, 12);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(467, 190);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm & Lọc";

            this.lblTimText.AutoSize = true;
            this.lblTimText.Location = new System.Drawing.Point(15, 27);
            this.lblTimText.Name = "lblTimText";
            this.lblTimText.Size = new System.Drawing.Size(142, 17);
            this.lblTimText.TabIndex = 0;
            this.lblTimText.Text = "Tìm theo tên hoặc SĐT:";

            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(165, 24);
            this.txtTim.Name = "txtTim";
            this.txtTim.PlaceholderText = "Nhập tên hoặc số điện thoại...";
            this.txtTim.Size = new System.Drawing.Size(285, 24);
            this.txtTim.TabIndex = 1;

            this.lblTimPhong.AutoSize = true;
            this.lblTimPhong.Location = new System.Drawing.Point(15, 66);
            this.lblTimPhong.Name = "lblTimPhong";
            this.lblTimPhong.Size = new System.Drawing.Size(73, 17);
            this.lblTimPhong.TabIndex = 2;
            this.lblTimPhong.Text = "Lọc phòng:";

            this.cboTimPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimPhong.FormattingEnabled = true;
            this.cboTimPhong.Location = new System.Drawing.Point(165, 63);
            this.cboTimPhong.Name = "cboTimPhong";
            this.cboTimPhong.Size = new System.Drawing.Size(285, 24);
            this.cboTimPhong.TabIndex = 3;

            this.lblTimTinh.AutoSize = true;
            this.lblTimTinh.Location = new System.Drawing.Point(15, 105);
            this.lblTimTinh.Name = "lblTimTinh";
            this.lblTimTinh.Size = new System.Drawing.Size(59, 17);
            this.lblTimTinh.TabIndex = 4;
            this.lblTimTinh.Text = "Lọc tỉnh:";

            this.cboTimTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTinh.FormattingEnabled = true;
            this.cboTimTinh.Location = new System.Drawing.Point(165, 102);
            this.cboTimTinh.Name = "cboTimTinh";
            this.cboTimTinh.Size = new System.Drawing.Size(285, 24);
            this.cboTimTinh.TabIndex = 5;

            this.btnTim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(165, 142);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 35);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.btnBoLoc.BackColor = System.Drawing.Color.LightGray;
            this.btnBoLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoLoc.Location = new System.Drawing.Point(280, 142);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(100, 35);
            this.btnBoLoc.TabIndex = 7;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = false;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);

            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnGayLoi);
            this.pnlButtons.Location = new System.Drawing.Point(12, 310);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(430, 42);
            this.pnlButtons.TabIndex = 2;

            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(84, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(165, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(246, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.btnGayLoi.BackColor = System.Drawing.Color.Gray;
            this.btnGayLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGayLoi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGayLoi.ForeColor = System.Drawing.Color.White;
            this.btnGayLoi.Location = new System.Drawing.Point(332, 3);
            this.btnGayLoi.Name = "btnGayLoi";
            this.btnGayLoi.Size = new System.Drawing.Size(85, 35);
            this.btnGayLoi.TabIndex = 4;
            this.btnGayLoi.Text = "Gây lỗi thử";
            this.btnGayLoi.UseVisualStyleBackColor = false;
            this.btnGayLoi.Click += new System.EventHandler(this.btnGayLoi_Click);

            this.dgvKhachThue.AllowUserToAddRows = false;
            this.dgvKhachThue.AllowUserToDeleteRows = false;
            this.dgvKhachThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachThue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachThue.Location = new System.Drawing.Point(12, 360);
            this.dgvKhachThue.MultiSelect = false;
            this.dgvKhachThue.Name = "dgvKhachThue";
            this.dgvKhachThue.ReadOnly = true;
            this.dgvKhachThue.RowHeadersVisible = false;
            this.dgvKhachThue.RowTemplate.Height = 26;
            this.dgvKhachThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachThue.Size = new System.Drawing.Size(910, 250);
            this.dgvKhachThue.TabIndex = 3;
            this.dgvKhachThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachThue_CellClick);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Sẵn sàng";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvKhachThue);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 680);
            this.Name = "FormKhachThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà trọ - Khách thuê";
            this.Load += new System.EventHandler(this.FormKhachThue_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblTinhThanh;
        private System.Windows.Forms.ComboBox cboTinhThanh;
        private System.Windows.Forms.Label lblPhuongXa;
        private System.Windows.Forms.ComboBox cboPhuongXa;
        private System.Windows.Forms.CheckBox chkTamTru;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimText;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblTimPhong;
        private System.Windows.Forms.ComboBox cboTimPhong;
        private System.Windows.Forms.Label lblTimTinh;
        private System.Windows.Forms.ComboBox cboTimTinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnGayLoi;
        private System.Windows.Forms.DataGridView dgvKhachThue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
