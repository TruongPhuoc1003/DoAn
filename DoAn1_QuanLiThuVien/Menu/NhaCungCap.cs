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
    public partial class NhaCungCap : Form
    {
        SqlConnection con;
        public NhaCungCap()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        public void HienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvThongTinNhaCungCap.DataSource = dt;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            HienThiThongTin();
        }

        private void NhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

           if(txtMaNhaCungCap.Text.Trim() == ""|| txtTenNhaCungCap.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("insert into NhaCungCap(MaNhaCungCap, TenNhaCungCap) values( @MaNhaCungCap, @TenNhaCungCap)", con);

                    cmd.Parameters.AddWithValue("@MaNhaCungCap", txtMaNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", txtTenNhaCungCap.Text);

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
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại, vui lòng nhập mã sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinNhaCungCap.CurrentRow.Index;
            if (txtMaNhaCungCap.Text.Trim() == "" || txtTenNhaCungCap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            else

            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update NhaCungCap set MaNhaCungCap = @MaNhaCungCap, TenNhaCungCap = @TenNhaCungCap where MaNhaCungCap = @MaNhaCungCapCu", con);

                    cmd.Parameters.AddWithValue("@MaNhaCungCap", txtMaNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", txtTenNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@MaNhaCungCapCu", dgvThongTinNhaCungCap.Rows[dongchon].Cells["MaNhaCungCap"].Value);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa thông tin nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Nhà cung cấp có mã này chưa hoàn thành việc giao sách cho trung tâm như đơn đã đặt nên chưa thể xóa ra khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvThongTinNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinNhaCungCap.CurrentRow.Index;

            txtMaNhaCungCap.Text = dgvThongTinNhaCungCap.Rows[dongchon].Cells["MaNhaCungCap"].Value.ToString();
            txtTenNhaCungCap.Text = dgvThongTinNhaCungCap.Rows[dongchon].Cells["tenNhaCungCap"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không? Nếu đồng ý bấm OK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {
                int dongchon = dgvThongTinNhaCungCap.CurrentRow.Index;

                SqlCommand cmd = new SqlCommand("delete from NhaCungCap where MaNhaCungCap = @MaNhaCungCap", con);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", dgvThongTinNhaCungCap.Rows[dongchon].Cells["MaNhaCungCap"].Value);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thông tin nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiThongTin();
            }

            catch
            {
                MessageBox.Show("Nhà cung cấp có mã này chưa hoàn thành việc giao sách cho trung tâm như đơn đã đặt nên chưa thể xóa ra khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap where MaNhaCungCap like N'%" + txtTimKiem.Text + "%'" +
                                           "or TenNhaCungCap like N'%" + txtTimKiem.Text + "%'", con);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTinNhaCungCap.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NhaCungCap_Load(sender, e);
        }
    }
}
