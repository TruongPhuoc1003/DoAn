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
using System.Diagnostics.Eventing.Reader;

namespace Menu
{
    public partial class NhanVien : Form
    {
        SqlConnection con;
        public NhanVien()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");

        }

        public void HienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTinNhanVien.DataSource = dt;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            HienThiThongTin();
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "" || txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầu đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("insert into NhanVien(MaNhanVien, TenNhanVien) values(@MaNhanVien, @TenNhanVien)", con);

                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }

                catch
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinNhanVien.CurrentRow.Index;

            if (txtMaNhanVien.Text.Trim() == "" || txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầu đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update NhanVien set MaNhanVien = @MaNhanVien, TenNhanVien = @TenNhanVien where MaNhanVien = @MaNhanViencu", con);

                    cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVienCu", dgvThongTinNhanVien.Rows[dongchon].Cells["MaNhanVien"].Value);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa thông tin nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }

                catch
                {
                    MessageBox.Show("Nhân viên có mã này đang quản lí nhập sách nên không thể thay đổi thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void dgvThongTinNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinNhanVien.CurrentRow.Index;

            txtMaNhanVien.Text = dgvThongTinNhanVien.Rows[dongchon].Cells["MaNhanVien"].Value.ToString();
            txtTenNhanVien.Text = dgvThongTinNhanVien.Rows[dongchon].Cells["TenNhanVien"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không? Nếu đồng ý bấm OK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {
                int dongchon = dgvThongTinNhanVien.CurrentRow.Index;

                SqlCommand cmd = new SqlCommand("delete from NhanVien where MaNhanVien = @MaNhanVien", con);
                cmd.Parameters.AddWithValue("@MaNhanVien", dgvThongTinNhanVien.Rows[dongchon].Cells["MaNhanVien"].Value);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Xóa thông tin nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiThongTin();
            }
            catch
            {
                MessageBox.Show("Nhân viên này đang trong quá trình quản lí việc nhập sách nên không thể xóa khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNhanVien like N'%" + txtTimKiem.Text + "%'" +
                                           "or TenNhanVien like N'%" + txtTimKiem.Text + "%'", con);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTinNhanVien.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
        }
    }
}
