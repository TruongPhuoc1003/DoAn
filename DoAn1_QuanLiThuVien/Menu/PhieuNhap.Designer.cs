namespace Menu
{
    partial class PhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHienThiThongTinPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cmbHoTenNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(493, 633);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(129, 34);
            this.btnLamMoi.TabIndex = 34;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(249, 633);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 34);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(209, 586);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(452, 24);
            this.txtTimKiem.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Thông tin tìm kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(532, 283);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 34);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(291, 283);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 34);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 283);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 34);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm phiếu nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHienThiThongTinPhieuNhap
            // 
            this.dgvHienThiThongTinPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiThongTinPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.MaNhaCungCap,
            this.MaNhanVien,
            this.NgayLap});
            this.dgvHienThiThongTinPhieuNhap.Location = new System.Drawing.Point(47, 348);
            this.dgvHienThiThongTinPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHienThiThongTinPhieuNhap.Name = "dgvHienThiThongTinPhieuNhap";
            this.dgvHienThiThongTinPhieuNhap.Size = new System.Drawing.Size(614, 208);
            this.dgvHienThiThongTinPhieuNhap.TabIndex = 27;
            this.dgvHienThiThongTinPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvHienThiThongTinPhieuNhap_SelectionChanged);
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.Width = 130;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Width = 150;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã  nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 190;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(209, 227);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(452, 24);
            this.dtpNgayLap.TabIndex = 26;
            // 
            // cmbHoTenNhanVien
            // 
            this.cmbHoTenNhanVien.FormattingEnabled = true;
            this.cmbHoTenNhanVien.Location = new System.Drawing.Point(209, 182);
            this.cmbHoTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoTenNhanVien.Name = "cmbHoTenNhanVien";
            this.cmbHoTenNhanVien.Size = new System.Drawing.Size(452, 26);
            this.cmbHoTenNhanVien.TabIndex = 25;
            // 
            // cmbMaNhaCungCap
            // 
            this.cmbMaNhaCungCap.FormattingEnabled = true;
            this.cmbMaNhaCungCap.Location = new System.Drawing.Point(209, 132);
            this.cmbMaNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaNhaCungCap.Name = "cmbMaNhaCungCap";
            this.cmbMaNhaCungCap.Size = new System.Drawing.Size(452, 26);
            this.cmbMaNhaCungCap.TabIndex = 24;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(209, 88);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(452, 24);
            this.txtMaPhieuNhap.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "PHIẾU NHẬP";
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(709, 692);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHienThiThongTinPhieuNhap);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.cmbHoTenNhanVien);
            this.Controls.Add(this.cmbMaNhaCungCap);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhieuNhap_FormClosed);
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHienThiThongTinPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cmbHoTenNhanVien;
        private System.Windows.Forms.ComboBox cmbMaNhaCungCap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}