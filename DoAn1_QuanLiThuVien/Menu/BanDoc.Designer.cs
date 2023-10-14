namespace Menu
{
    partial class BanDoc
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.showInfromationdataGridView = new System.Windows.Forms.DataGridView();
            this.MaBanDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBanDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbDiaChi = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaBanDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showInfromationdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(238, 617);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(357, 24);
            this.txtTimKiem.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 623);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Thông tin tìm kiếm";
            // 
            // showInfromationdataGridView
            // 
            this.showInfromationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInfromationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBanDoc,
            this.TenBanDoc,
            this.DiaChi});
            this.showInfromationdataGridView.Location = new System.Drawing.Point(68, 311);
            this.showInfromationdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.showInfromationdataGridView.Name = "showInfromationdataGridView";
            this.showInfromationdataGridView.Size = new System.Drawing.Size(527, 263);
            this.showInfromationdataGridView.TabIndex = 38;
            this.showInfromationdataGridView.SelectionChanged += new System.EventHandler(this.showInfromationdataGridView_SelectionChanged);
            // 
            // MaBanDoc
            // 
            this.MaBanDoc.DataPropertyName = "MaBanDoc";
            this.MaBanDoc.HeaderText = "Mã bạn đọc";
            this.MaBanDoc.Name = "MaBanDoc";
            this.MaBanDoc.Width = 120;
            // 
            // TenBanDoc
            // 
            this.TenBanDoc.DataPropertyName = "TenBanDoc";
            this.TenBanDoc.HeaderText = "Họ tên";
            this.TenBanDoc.Name = "TenBanDoc";
            this.TenBanDoc.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 175;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(487, 227);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 48);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa bạn đọc";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(269, 227);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 48);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 227);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 48);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm bạn đọc";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbDiaChi
            // 
            this.cmbDiaChi.FormattingEnabled = true;
            this.cmbDiaChi.Items.AddRange(new object[] {
            "An Giang",
            "",
            "Bà Rịa-Vũng Tàu",
            "",
            "Bạc Liêu",
            "",
            "Bắc Kạn",
            "",
            "Bắc Giang\t",
            "",
            "Bắc Ninh",
            "",
            "Bến Tre",
            "",
            "Bình Dương",
            "",
            "Bình Định",
            "",
            "Bình Phước",
            "",
            "Bình Thuận",
            "",
            "Cà Mau",
            "",
            "Cao Bằng",
            "",
            "Thành phố Cần Thơ  ",
            "",
            "Thành phố Đà Nẵng \t",
            "",
            "Đắk Lắk ",
            "Đắk Nông",
            "",
            "Điện Biên\t",
            "",
            "Đồng Nai\t",
            "",
            "Đồng Tháp",
            "",
            "Gia Lai",
            "",
            "Hà Giang\t",
            "",
            "Hà Nam",
            "",
            "Thành phố Hà Nội ",
            " ",
            "Hà Tĩnh",
            "",
            "Hải Dương",
            "",
            "Hải Phòng  ",
            "",
            "Hòa Bình",
            "",
            "Thành phố Hồ Chí Minh",
            " ",
            "Hậu Giang",
            "",
            "Hưng Yên",
            "",
            "Khánh Hòa",
            "",
            "Kiên Giang",
            "",
            "Kon Tum",
            " ",
            "Lai Châu",
            "",
            "Lào Cai",
            "",
            "Lạng Sơn",
            "",
            "Lâm Đồng",
            "",
            "Long An",
            "",
            "Nam Định\t",
            "",
            "Nghệ An",
            "",
            "Ninh Bình",
            "",
            "Ninh Thuận",
            "",
            "Phú Thọ"});
            this.cmbDiaChi.Location = new System.Drawing.Point(196, 178);
            this.cmbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiaChi.Name = "cmbDiaChi";
            this.cmbDiaChi.Size = new System.Drawing.Size(399, 26);
            this.cmbDiaChi.TabIndex = 34;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(196, 131);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(399, 24);
            this.txtHoTen.TabIndex = 33;
            // 
            // txtMaBanDoc
            // 
            this.txtMaBanDoc.Location = new System.Drawing.Point(196, 84);
            this.txtMaBanDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBanDoc.Name = "txtMaBanDoc";
            this.txtMaBanDoc.Size = new System.Drawing.Size(399, 24);
            this.txtMaBanDoc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên bạn đọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã bạn đọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÍ BẠN ĐỌC";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(269, 669);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 38);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(444, 669);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(101, 38);
            this.btnLamMoi.TabIndex = 42;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // BanDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(659, 733);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showInfromationdataGridView);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaBanDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanDoc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BanDoc_FormClosed);
            this.Load += new System.EventHandler(this.BanDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInfromationdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView showInfromationdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBanDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaBanDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
    }
}