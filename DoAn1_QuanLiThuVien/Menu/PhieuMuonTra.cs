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
    public partial class PhieuMuonTra : Form
    {
        SqlConnection con;
        public PhieuMuonTra()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        public void hienThiThngTin()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuMuonTra", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTinPhieuMuon.DataSource = dt;
        }

        private void PhieuMuonTra_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            hienThiThngTin();

            SqlCommand cmd = new SqlCommand("select * from BanDoc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMaBanDoc.DataSource = dt;
            cmbMaBanDoc.DisplayMember = "MaBanDoc";
            cmbMaBanDoc.ValueMember = "MaBanDoc";
        }

        private void PhieuMuonTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaPhieu.Text.Trim() == "" || cmbMaBanDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into PhieuMuonTra(MaPhieu, MaBanDoc, NgayMuon, NgayTra)" +
                                                "values(@MaPhieu, @MaBanDoc, @NgayMuon, @NgayTra)", con);

                    cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@MaBanDoc", cmbMaBanDoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã hoàn thành phiếu mượn  sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Chuyển qua phiếu mượn trả sách để hoàn thành phiếu mượn trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PhieuMuonTraSach pmts = new PhieuMuonTraSach();
                        pmts.Show();
                    }
                    else
                    {
                        MessageBox.Show("Việc mượn sách đã xảy ra gián đoạn! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    hienThiThngTin();
                }
                catch
                {
                    MessageBox.Show("Mã phiếu đã tồn tại! Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void dgvThongTinPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinPhieuMuon.CurrentRow.Index;
            txtMaPhieu.Text = dgvThongTinPhieuMuon.Rows[dongchon].Cells["MaPhieu"].Value.ToString();
            cmbMaBanDoc.SelectedValue = dgvThongTinPhieuMuon.Rows[dongchon].Cells["MaBanDoc"].Value.ToString();
            dtpNgayMuon.Value = DateTime.Parse(dgvThongTinPhieuMuon.Rows[dongchon].Cells["NgayMuon"].Value.ToString());
            dtpNgayTra.Value = DateTime.Parse(dgvThongTinPhieuMuon.Rows[dongchon].Cells["NgayTra"].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = dgvThongTinPhieuMuon.CurrentRow.Index;


            if (txtMaPhieu.Text.Trim() == "" || cmbMaBanDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update PhieuMuonTra set MaPhieu = @MaPhieu, MaBanDoc = @MaBanDoc," +
                                                " NgayMuon = @NgayMuon, NgayTra = @NgayTra where MaPhieu = @MaPhieuCu", con);

                    cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@MaBanDoc", cmbMaBanDoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                    cmd.Parameters.AddWithValue("@MaPhieuCu", dgvThongTinPhieuMuon.Rows[dongchon].Cells["MaPhieu"].Value.ToString());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa thông tin phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hienThiThngTin();
                }

                catch
                {
                    MessageBox.Show("Bạn đọc này đang cầm sách có mã phiếu này của thư viện nên không thể thay đổi thông tin được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không? Nếu đồng ý bấm OK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {
                int dongchon = dgvThongTinPhieuMuon.CurrentRow.Index;
                SqlCommand cmd = new SqlCommand("delete from PhieuMuonTra where MaPhieu = @MaPhieu", con);

                cmd.Parameters.AddWithValue("@MaPhieu", dgvThongTinPhieuMuon.Rows[dongchon].Cells["MaPhieu"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thông tin phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thông tin phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienThiThngTin();
            }
            catch
            {
                MessageBox.Show("Bạn đọc có mã phiếu mượn  này chưa hoàn thành việc trả sách nên không thể xóa khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuMuonTra where MaPhieu like N'%" + txtTimKiem.Text + "%'" +
                                                                       "or MaBanDoc like N'%" + txtTimKiem.Text + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTinPhieuMuon.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuMuonTra_Load(sender, e);
        }
    }
}
