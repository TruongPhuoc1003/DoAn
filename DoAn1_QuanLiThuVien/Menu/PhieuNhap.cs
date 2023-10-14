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
    public partial class PhieuNhap : Form
    {
        SqlConnection con;
        public PhieuNhap()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        public void HienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHienThiThongTinPhieuNhap.DataSource = dt;
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            HienThiThongTin();

            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMaNhaCungCap.DataSource = dt;
            cmbMaNhaCungCap.DisplayMember = "TenNhaCungCap";
            cmbMaNhaCungCap.ValueMember = "MaNhaCungCap";

            SqlCommand cmd1 = new SqlCommand("select * from NhanVien", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmbHoTenNhanVien.DataSource = dt1;
            cmbHoTenNhanVien.DisplayMember = "MaNhanVien";
            cmbHoTenNhanVien.ValueMember = "MaNhanVien";
        }

        private void PhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if (txtMaPhieuNhap.Text.Trim() == ""|| cmbMaNhaCungCap.SelectedIndex == -1 || cmbHoTenNhanVien.SelectedIndex == -1 || dtpNgayLap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into PhieuNhap(MaPhieuNhap, MaNhaCungCap, MaNhanVien, NgayLap) values(@MaPhieuNhap, @MaNhaCungCap, @MaNhanVien, @NgayLap) ", con);

                    cmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", cmbMaNhaCungCap.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbHoTenNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm phiếu nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Hãy chuyển qua phiếu nhập sách để hoàn thành việc nhập sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PhieuNhapSach pns = new PhieuNhapSach();
                        pns.Show();

                    }

                    else
                        MessageBox.Show("Thêm phiếu nhập sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiThongTin();
                }

                catch
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại! Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }    
        }

        private void dgvHienThiThongTinPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = dgvHienThiThongTinPhieuNhap.CurrentRow.Index;

            txtMaPhieuNhap.Text = dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["MaPhieuNhap"].Value.ToString();
            cmbMaNhaCungCap.SelectedValue = dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["MaNhaCungCap"].Value;
            cmbHoTenNhanVien.SelectedValue = dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["MaNhanVien"].Value;
            dtpNgayLap.Value = DateTime.Parse(dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["NgayLap"].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhap.Text.Trim() == "" || cmbMaNhaCungCap.SelectedIndex == -1 || cmbHoTenNhanVien.SelectedIndex == -1 || dtpNgayLap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    int dongchon = dgvHienThiThongTinPhieuNhap.CurrentRow.Index;

                    SqlCommand cmd = new SqlCommand("update PhieuNhap set MaPhieuNhap = @MaPhieuNhap, MaNhaCungCap = @MaNhaCungCap, MaNhanVien = @MaNhanVien, NgayLap = @NgayLap where MaPhieuNhap = @MaPhieuNhapCu", con);
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", cmbMaNhaCungCap.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbHoTenNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    cmd.Parameters.AddWithValue("@MaPhieuNhapCu", dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["MaPhieuNhap"].Value.ToString());

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
                    MessageBox.Show("Mã phiếu nhập đã tồn tại! Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không? Nếu đồng ý bấm OK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {

                int dongchon = dgvHienThiThongTinPhieuNhap.CurrentRow.Index;

                SqlCommand cmd = new SqlCommand("delete from PhieuNhap where MaPhieuNhap = @MaPhieuNhap", con);
                cmd.Parameters.AddWithValue("@MaPhieuNhap", dgvHienThiThongTinPhieuNhap.Rows[dongchon].Cells["MaPhieuNhap"].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thông tin phiếu nhập sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("Xóa thông tin phiếu nhập sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiThongTin();
            }
            catch
            {
                MessageBox.Show("Việc nhập sách chưa hoàn thành nên chưa thể xóa phiếu nhập này ra khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap where MaPhieuNhap like'%" + txtTimKiem.Text + "%'" +
                                           "or MaNhaCungCap like'%" + txtTimKiem.Text + "%'" +
                                           "or MaNhanVien like'%" + txtTimKiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHienThiThongTinPhieuNhap.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuNhap_Load(sender, e);
        }
    }
}
