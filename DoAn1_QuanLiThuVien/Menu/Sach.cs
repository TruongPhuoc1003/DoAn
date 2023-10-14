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
    public partial class Sach : Form
    {
        SqlConnection con;
        public Sach()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
         }

        public void HienThiThongTinSach()
        {
            SqlCommand cmd = new SqlCommand("select * from Sach", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showThongTinSach.DataSource = dt;
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            HienThiThongTinSach();
        }
        private void Sach_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
           if(txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đầu đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Sach(MaSach, TenSach) values(@MaSach, @TenSach)", con);

                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTinSach();
                }

                catch
                {
                    MessageBox.Show("Mã sách đã tồn tại, vui lòng nhập mã sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void showThongTinSach_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = showThongTinSach.CurrentRow.Index;
            txtMaSach.Text = showThongTinSach.Rows[dongchon].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = showThongTinSach.Rows[dongchon].Cells["TenSach"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int dongchon = showThongTinSach.CurrentRow.Index;

            if (txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầu đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update Sach set MaSach = @MaSach, TenSach = @TenSach where MaSach = @MaSachCu", con);
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                    cmd.Parameters.AddWithValue("@MaSachCu", showThongTinSach.Rows[dongchon].Cells["MaSach"].Value.ToString());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa thông tin sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTinSach();
                }
                catch
                {
                    MessageBox.Show("Sách có mã này đang được cho mượn hoặc đang được nhập về nên không thể thay đổi thông tin được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           try
            {
                int dongchon = showThongTinSach.CurrentRow.Index;
                SqlCommand cmd = new SqlCommand("delete from Sach where MaSach = @MaSach", con);
                cmd.Parameters.AddWithValue("@MaSach", showThongTinSach.Rows[dongchon].Cells["MaSach"].Value.ToString());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiThongTinSach();
            }
            catch
            {
                MessageBox.Show("Sách có mã này đang được cho mượn hoặc đang được nhập về nên không thể thay đổi thông tin được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Sach where MaSach like N'%" + txtTimKiem.Text + "%'" +
                                           " or TenSach like N'%" + txtTimKiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            showThongTinSach.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Sach_Load(sender, e);
        }
    }
}



