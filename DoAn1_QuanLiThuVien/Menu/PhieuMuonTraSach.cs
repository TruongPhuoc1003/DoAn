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
    public partial class PhieuMuonTraSach : Form
    {
        SqlConnection con;
        public PhieuMuonTraSach()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        public void HienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuMuonTraSach", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvShowThongTin.DataSource = dt;
        }

        private void PhieuMuonTraSach_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            HienThiThongTin();

            SqlCommand cmd = new SqlCommand("select * from PhieuMuonTra", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMaPhieu.DataSource = dt;
            cmbMaPhieu.DisplayMember = "MaPhieu";
            cmbMaPhieu.ValueMember = "MaPhieu";


            SqlCommand cmd1 = new SqlCommand("select * from Sach", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmbMaSach.DataSource = dt1;
            cmbMaSach.DisplayMember = "TenSach";
            cmbMaSach.ValueMember = "MaSach";
        }

        private void PhieuMuonTraSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(cmbMaPhieu.SelectedIndex == -1 || cmbMaSach.SelectedIndex == -1 || txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into PhieuMuonTraSach(MaPhieu, MaSach, SoLuong) values(@MaPhieu, @MaSach, @SoLuong) ", con);

                    cmd.Parameters.AddWithValue("@MaPhieu", cmbMaPhieu.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaSach", cmbMaSach.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm phiếu mượn trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Thêm phiếu mượn trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Bạn đọc đã mượn cuốn sách này, vui lòng mượn cuốn khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = dgvShowThongTin.CurrentRow.Index;

            if (cmbMaPhieu.SelectedIndex == -1 || cmbMaSach.SelectedIndex == -1 || txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update PhieuMuonTraSach set MaPhieu = @MaPhieu," +
                                                " MaSach = @MaSach, SoLuong = @SoLuong where MaPhieu = @MaPhieuCu", con);

                    cmd.Parameters.AddWithValue("@MaPhieu", cmbMaPhieu.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaSach", cmbMaSach.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@MaPhieuCu", dgvShowThongTin.Rows[dongchon].Cells["MaPhieu"].Value.ToString());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin phiếu mượn trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Sửa thông tin phiếu mượn trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Tồn tại nhiều mã phiếu giống nhau nên không sửa thông tin của một trong các mã phiếu được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void dgvShowThongTin_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvShowThongTin.CurrentRow.Index;

            cmbMaPhieu.SelectedValue = dgvShowThongTin.Rows[dongchon].Cells["MaPhieu"].Value;
            cmbMaSach.SelectedValue = dgvShowThongTin.Rows[dongchon].Cells["MaSach"].Value;
            txtSoLuong.Text = dgvShowThongTin.Rows[dongchon].Cells["SoLuong"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dongchon = dgvShowThongTin.CurrentRow.Index;

            SqlCommand cmd = new SqlCommand("delete from PhieuMuonTraSach where MaPhieu = @MaPhieu ", con);

            cmd.Parameters.AddWithValue("@MaPhieu", dgvShowThongTin.Rows[dongchon].Cells["MaPhieu"].Value.ToString());

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa phiếu mượn trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Xóa phiếu mượn trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiThongTin();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuMuonTraSach where MaPhieu like'%" + txtTimKiem.Text + "%'" +
                                            "or MaSach like'%" + txtTimKiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvShowThongTin.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuMuonTraSach_Load(sender, e);
        }
    }
}

