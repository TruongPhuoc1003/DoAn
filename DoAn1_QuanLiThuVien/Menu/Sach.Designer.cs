namespace Menu
{
    partial class Sach
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
            this.label3 = new System.Windows.Forms.Label();
            this.showThongTinSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showThongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(430, 557);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(6);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 43);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(256, 557);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 43);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(178, 512);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(421, 24);
            this.txtTimKiem.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Thông tin tìm kiếm: ";
            // 
            // showThongTinSach
            // 
            this.showThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showThongTinSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach});
            this.showThongTinSach.Location = new System.Drawing.Point(39, 269);
            this.showThongTinSach.Margin = new System.Windows.Forms.Padding(6);
            this.showThongTinSach.Name = "showThongTinSach";
            this.showThongTinSach.Size = new System.Drawing.Size(558, 213);
            this.showThongTinSach.TabIndex = 34;
            this.showThongTinSach.SelectionChanged += new System.EventHandler(this.showThongTinSach_SelectionChanged);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 150;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 365;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(452, 202);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 37);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa thông tin sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(255, 202);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 37);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(39, 202);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 37);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(202, 143);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(396, 24);
            this.txtTenSach.TabIndex = 30;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(202, 90);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(396, 24);
            this.txtMaSach.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "QUẢN LÍ SÁCH";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(632, 633);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showThongTinSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sach";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sach_FormClosed);
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showThongTinSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView showThongTinSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}