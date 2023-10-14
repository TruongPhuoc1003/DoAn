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
    public partial class PhieuNhapSach : Form
    {
        SqlConnection con;
        public PhieuNhapSach()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");

        }

        public void HienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhapSach", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvShowThongTin.DataSource = dt;
        }

        private void PhieuNhapSach_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            HienThiThongTin();

            SqlCommand cmd = new SqlCommand("select * from PhieuNhap", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMaPhieuNhap.DataSource = dt;
            cmbMaPhieuNhap.DisplayMember = "MaPhieuNhap";
            cmbMaPhieuNhap.ValueMember = "MaPhieuNhap";

            SqlCommand cmd1 = new SqlCommand("select * from Sach", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmbMaSach.DataSource = dt1;
            cmbMaSach.DisplayMember = "TenSach";
            cmbMaSach.ValueMember = "MaSach";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
           if(cmbMaPhieuNhap.SelectedIndex == -1 || cmbMaSach.SelectedIndex == -1 || txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into PhieuNhapSach(MaPhieuNhap, MaSach, SoLuong) values(@MaPhieuNhap, @MaSach, @SoLuong) ", con);

                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cmbMaPhieuNhap.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaSach", cmbMaSach.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã hoàn thành việc nhập sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Việc nhập sách đã xảy ra gián đoạn! Vui lòng kiểm tra lại đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Mã phiếu nhập cho cuốn sách này đã tồn tại, vui lòng nhập mã phiếu  khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }    
        }

        private void PhieuNhapSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (cmbMaPhieuNhap.SelectedIndex == -1 || cmbMaSach.SelectedIndex == -1 || txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
            {
                try
                {
                    int dongchon = dgvShowThongTin.CurrentRow.Index;
                    SqlCommand cmd = new SqlCommand("update PhieuNhapSach set MaPhieuNhap = @MaPhieuNhap," +
                                                " MaSach = @MaSach, SoLuong = @SoLuong where MaPhieuNhap = @MaPhieuNhapCu", con);

                    cmd.Parameters.AddWithValue("@MaPhieuNhap", cmbMaPhieuNhap.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaSach", cmbMaSach.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@MaPhieuNhapCu", dgvShowThongTin.Rows[dongchon].Cells["MaPhieuNhap"].Value.ToString());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin phiếu nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Sửa thông tin phiếu nhập sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Tồn tại nhiều mã giống nhau nên không sửa thông tin của một trong các mã phiếu được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void dgvShowThongTin_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvShowThongTin.CurrentRow.Index;

            cmbMaPhieuNhap.SelectedValue = dgvShowThongTin.Rows[dongchon].Cells["MaPhieuNhap"].Value;
            cmbMaSach.SelectedValue = dgvShowThongTin.Rows[dongchon].Cells["MaSach"].Value;
            txtSoLuong.Text = dgvShowThongTin.Rows[dongchon].Cells["SoLuong"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dongchon = dgvShowThongTin.CurrentRow.Index;

            SqlCommand cmd = new SqlCommand("delete from PhieuNhapSach where MaPhieuNhap = @MaPhieuNhap ", con);

            cmd.Parameters.AddWithValue("@MaPhieuNhap", dgvShowThongTin.Rows[dongchon].Cells["MaPhieuNhap"].Value.ToString());

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa phiếu nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Xóa phiếu nhập sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiThongTin();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhapSach where MaPhieuNhap like'%" + txtTimKiem.Text + "%'" +
                                         "or MaSach like'%" + txtTimKiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvShowThongTin.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuNhapSach_Load(sender, e);
        }
    }
}
