namespace Menu
{
    partial class PhieuMuonTraSach
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvShowThongTin = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbMaSach = new System.Windows.Forms.ComboBox();
            this.cmbMaPhieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(392, 581);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 44);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(238, 581);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 44);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Tag = " ";
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(194, 533);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(342, 24);
            this.txtTimKiem.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 533);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thông tin tìm kiếm";
            // 
            // dgvShowThongTin
            // 
            this.dgvShowThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaSach,
            this.SoLuong});
            this.dgvShowThongTin.Location = new System.Drawing.Point(45, 312);
            this.dgvShowThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowThongTin.Name = "dgvShowThongTin";
            this.dgvShowThongTin.Size = new System.Drawing.Size(490, 194);
            this.dgvShowThongTin.TabIndex = 25;
            this.dgvShowThongTin.SelectionChanged += new System.EventHandler(this.dgvShowThongTin_SelectionChanged);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 130;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 170;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(421, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 44);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(237, 242);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 44);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa thông tin phiếu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 242);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 44);
            this.btnThem.TabIndex = 22;
            this.btnThem.Tag = " ";
            this.btnThem.Text = "Thêm phiếu mượn trả  sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(142, 173);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(390, 24);
            this.txtSoLuong.TabIndex = 21;
            // 
            // cmbMaSach
            // 
            this.cmbMaSach.FormattingEnabled = true;
            this.cmbMaSach.Location = new System.Drawing.Point(142, 119);
            this.cmbMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaSach.Name = "cmbMaSach";
            this.cmbMaSach.Size = new System.Drawing.Size(390, 26);
            this.cmbMaSach.TabIndex = 20;
            // 
            // cmbMaPhieu
            // 
            this.cmbMaPhieu.FormattingEnabled = true;
            this.cmbMaPhieu.Location = new System.Drawing.Point(142, 73);
            this.cmbMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaPhieu.Name = "cmbMaPhieu";
            this.cmbMaPhieu.Size = new System.Drawing.Size(390, 26);
            this.cmbMaPhieu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "PHIẾU MƯỢN TRẢ SÁCH";
            // 
            // PhieuMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(577, 659);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvShowThongTin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbMaSach);
            this.Controls.Add(this.cmbMaPhieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuMuonTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuMuonTraSach";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhieuMuonTraSach_FormClosed);
            this.Load += new System.EventHandler(this.PhieuMuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvShowThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbMaSach;
        private System.Windows.Forms.ComboBox cmbMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}