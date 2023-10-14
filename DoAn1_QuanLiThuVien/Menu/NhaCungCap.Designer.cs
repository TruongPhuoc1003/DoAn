namespace Menu
{
    partial class NhaCungCap
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongTinNhaCungCap = new System.Windows.Forms.DataGridView();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(354, 506);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 42);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(231, 506);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 42);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(222, 454);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(232, 24);
            this.txtTimKiem.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Thông tin tìm kiếm";
            // 
            // dgvThongTinNhaCungCap
            // 
            this.dgvThongTinNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap});
            this.dgvThongTinNhaCungCap.Location = new System.Drawing.Point(31, 283);
            this.dgvThongTinNhaCungCap.Name = "dgvThongTinNhaCungCap";
            this.dgvThongTinNhaCungCap.Size = new System.Drawing.Size(444, 150);
            this.dgvThongTinNhaCungCap.TabIndex = 34;
            this.dgvThongTinNhaCungCap.SelectionChanged += new System.EventHandler(this.dgvThongTinNhaCungCap_SelectionChanged);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Width = 160;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.Width = 350;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(366, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 58);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa thông tin nhà cung cấp";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(191, 192);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 58);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa thông tin nhà cung cấp";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 58);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm nhà cung cấp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(191, 132);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(284, 24);
            this.txtTenNhaCungCap.TabIndex = 30;
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(191, 92);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(284, 24);
            this.txtMaNhaCungCap.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(504, 579);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvThongTinNhaCungCap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.txtMaNhaCungCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhaCungCap_FormClosed);
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThongTinNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}