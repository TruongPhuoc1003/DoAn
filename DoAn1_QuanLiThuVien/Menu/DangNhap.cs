using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu
{
    public partial class DangNhap : Form
    {
        SqlConnection con;
        public DangNhap()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

      

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlCommand cmd = new SqlCommand("select phanquyen from tblDangNhap where username = @username and password = @password", con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            object result = cmd.ExecuteScalar();
            if(result != null &&(bool)result)
            {
                MenuAdmin menuadmin = new MenuAdmin();
                menuadmin.Tag = username;
                menuadmin.Show();
                this.Hide();
            }

           else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
