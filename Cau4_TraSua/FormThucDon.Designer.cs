namespace Cau4_TraSua
{
    partial class FormThucDon
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.chkDangBan = new System.Windows.Forms.CheckBox();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimTen = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.lblLocDM = new System.Windows.Forms.Label();
            this.cboLocDM = new System.Windows.Forms.ComboBox();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();

            this.grpThongTin.Controls.Add(this.lblTenMon);
            this.grpThongTin.Controls.Add(this.txtTenMon);
            this.grpThongTin.Controls.Add(this.lblDanhMuc);
            this.grpThongTin.Controls.Add(this.cboDanhMuc);
            this.grpThongTin.Controls.Add(this.lblGiaBan);
            this.grpThongTin.Controls.Add(this.nudGiaBan);
            this.grpThongTin.Controls.Add(this.chkDangBan);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(370, 185);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin món uống";

            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(15, 30);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(62, 17);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên món:";

            this.txtTenMon.Location = new System.Drawing.Point(90, 27);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(260, 24);
            this.txtTenMon.TabIndex = 1;

            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(15, 68);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(70, 17);
            this.lblDanhMuc.TabIndex = 2;
            this.lblDanhMuc.Text = "Danh mục:";

            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(90, 65);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(260, 24);
            this.cboDanhMuc.TabIndex = 3;

            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(15, 108);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(55, 17);
            this.lblGiaBan.TabIndex = 4;
            this.lblGiaBan.Text = "Giá bán:";

            this.nudGiaBan.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiaBan.Location = new System.Drawing.Point(90, 106);
            this.nudGiaBan.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.Size = new System.Drawing.Size(150, 24);
            this.nudGiaBan.TabIndex = 5;
            this.nudGiaBan.ThousandsSeparator = true;

            this.chkDangBan.AutoSize = true;
            this.chkDangBan.Checked = true;
            this.chkDangBan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDangBan.Location = new System.Drawing.Point(90, 145);
            this.chkDangBan.Name = "chkDangBan";
            this.chkDangBan.Size = new System.Drawing.Size(83, 21);
            this.chkDangBan.TabIndex = 6;
            this.chkDangBan.Text = "Đang bán";
            this.chkDangBan.UseVisualStyleBackColor = true;

            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(12, 203);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(370, 42);
            this.pnlButtons.TabIndex = 1;

            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(89, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(175, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(261, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblTimTen);
            this.grpTimKiem.Controls.Add(this.txtTimTen);
            this.grpTimKiem.Controls.Add(this.lblLocDM);
            this.grpTimKiem.Controls.Add(this.cboLocDM);
            this.grpTimKiem.Controls.Add(this.btnBoLoc);
            this.grpTimKiem.Location = new System.Drawing.Point(395, 12);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(437, 75);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm & Lọc";

            this.lblTimTen.AutoSize = true;
            this.lblTimTen.Location = new System.Drawing.Point(12, 30);
            this.lblTimTen.Name = "lblTimTen";
            this.lblTimTen.Size = new System.Drawing.Size(61, 17);
            this.lblTimTen.TabIndex = 0;
            this.lblTimTen.Text = "Tìm món:";

            this.txtTimTen.Location = new System.Drawing.Point(75, 27);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(120, 24);
            this.txtTimTen.TabIndex = 1;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);

            this.lblLocDM.AutoSize = true;
            this.lblLocDM.Location = new System.Drawing.Point(205, 30);
            this.lblLocDM.Name = "lblLocDM";
            this.lblLocDM.Size = new System.Drawing.Size(70, 17);
            this.lblLocDM.TabIndex = 2;
            this.lblLocDM.Text = "Danh mục:";

            this.cboLocDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocDM.FormattingEnabled = true;
            this.cboLocDM.Location = new System.Drawing.Point(275, 27);
            this.cboLocDM.Name = "cboLocDM";
            this.cboLocDM.Size = new System.Drawing.Size(95, 24);
            this.cboLocDM.TabIndex = 3;
            this.cboLocDM.SelectedIndexChanged += new System.EventHandler(this.cboLocDM_SelectedIndexChanged);

            this.btnBoLoc.Location = new System.Drawing.Point(375, 24);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(55, 29);
            this.btnBoLoc.TabIndex = 4;
            this.btnBoLoc.Text = "Xóa";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);

            this.dgvMon.AllowUserToAddRows = false;
            this.dgvMon.AllowUserToDeleteRows = false;
            this.dgvMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Location = new System.Drawing.Point(395, 93);
            this.dgvMon.MultiSelect = false;
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersVisible = false;
            this.dgvMon.RowTemplate.Height = 26;
            this.dgvMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMon.Size = new System.Drawing.Size(437, 360);
            this.dgvMon.TabIndex = 3;
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 465);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thực đơn quán trà sữa";
            this.Load += new System.EventHandler(this.FormThucDon_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.CheckBox chkDangBan;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimTen;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label lblLocDM;
        private System.Windows.Forms.ComboBox cboLocDM;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvMon;
    }
}
