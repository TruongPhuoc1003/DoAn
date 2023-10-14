namespace Menu
{
    partial class PhieuMuonTra
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThongTinPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBanDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaBanDoc = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(488, 686);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(6);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 43);
            this.btnLamMoi.TabIndex = 52;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(293, 686);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 43);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(207, 628);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(478, 24);
            this.txtTimKiem.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 628);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Thông tin tìm kiếm: ";
            // 
            // dgvThongTinPhieuMuon
            // 
            this.dgvThongTinPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaBanDoc,
            this.NgayMuon,
            this.NgayTra});
            this.dgvThongTinPhieuMuon.Location = new System.Drawing.Point(53, 374);
            this.dgvThongTinPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinPhieuMuon.Name = "dgvThongTinPhieuMuon";
            this.dgvThongTinPhieuMuon.Size = new System.Drawing.Size(633, 222);
            this.dgvThongTinPhieuMuon.TabIndex = 48;
            this.dgvThongTinPhieuMuon.SelectionChanged += new System.EventHandler(this.dgvThongTinPhieuMuon_SelectionChanged);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            // 
            // MaBanDoc
            // 
            this.MaBanDoc.DataPropertyName = "MaBanDoc";
            this.MaBanDoc.HeaderText = "Mã bạn đọc";
            this.MaBanDoc.Name = "MaBanDoc";
            this.MaBanDoc.Width = 200;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 145;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 145;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(532, 302);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 44);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa phiếu mượn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(280, 302);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(174, 44);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa thông tin phiếu mượn";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(197, 228);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(489, 24);
            this.dtpNgayTra.TabIndex = 45;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(197, 182);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(489, 24);
            this.dtpNgayMuon.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ngày mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày trả";
            // 
            // cmbMaBanDoc
            // 
            this.cmbMaBanDoc.FormattingEnabled = true;
            this.cmbMaBanDoc.Location = new System.Drawing.Point(197, 140);
            this.cmbMaBanDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaBanDoc.Name = "cmbMaBanDoc";
            this.cmbMaBanDoc.Size = new System.Drawing.Size(489, 26);
            this.cmbMaBanDoc.TabIndex = 41;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 302);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 44);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm phiếu mượn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(197, 95);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(489, 24);
            this.txtMaPhieu.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã bạn đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "PHIẾU MƯỢN TRẢ";
            // 
            // PhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(728, 759);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvThongTinPhieuMuon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaBanDoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuMuonTra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhieuMuonTra_FormClosed);
            this.Load += new System.EventHandler(this.PhieuMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvThongTinPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaBanDoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}