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
    public partial class BanDoc : Form
    {
        SqlConnection con;
        public BanDoc()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\MEOKUROMI;Initial Catalog=QuanLiThuVien;Integrated Security=True");
        }

        public void hienThiThongTin()
        {
            SqlCommand cmd = new SqlCommand("select * from BanDoc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showInfromationdataGridView.DataSource = dt;
        }

        private void BanDoc_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            hienThiThongTin();
        }

        private void BanDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaBanDoc.Text.Trim() == ""|| txtHoTen.Text.Trim() =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into BanDoc(MaBanDoc, TenBanDoc, DiaChi) values(@MaBanDoc, @TenBanDoc, @DiaChi)", con);

                    cmd.Parameters.AddWithValue("@MaBanDoc", txtMaBanDoc.Text);
                    cmd.Parameters.AddWithValue("@TenBanDoc", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", cmbDiaChi.SelectedItem);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm bạn đọc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm bạn đọc thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Mã bạn đọc đã tồn tại, vui lòng nhập mã sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dongchon = showInfromationdataGridView.CurrentRow.Index;

            if (txtMaBanDoc.Text.Trim() == "" || txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update BanDoc set MaBanDoc = @MaBanDoc, TenBanDoc = @TenBanDoc, DiaChi = @DiaChi where MaBanDoc = @MaBanDocCu", con);

                    cmd.Parameters.AddWithValue("@MaBanDoc", txtMaBanDoc.Text);
                    cmd.Parameters.AddWithValue("@TenBanDoc", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", cmbDiaChi.SelectedItem);
                    cmd.Parameters.AddWithValue("@MaBanDocCu", showInfromationdataGridView.Rows[dongchon].Cells["MaBanDoc"].Value.ToString());


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thông tin bạn đọc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sửa thông tin bạn đọc thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hienThiThongTin();
                }
                catch
                {
                    MessageBox.Show("Bạn đọc có mã này đang mượn sách của thư viện nên không thể thay đổi thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }    
        }

        private void showInfromationdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = showInfromationdataGridView.CurrentRow.Index;

            txtMaBanDoc.Text = showInfromationdataGridView.Rows[dongchon].Cells["MaBanDoc"].Value.ToString();
            txtHoTen.Text = showInfromationdataGridView.Rows[dongchon].Cells["TenBanDoc"].Value.ToString();
            cmbDiaChi.SelectedItem = showInfromationdataGridView.Rows[dongchon].Cells["DiaChi"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không? Nếu đồng ý bấm OK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {
                int dongchon = showInfromationdataGridView.CurrentRow.Index;
                SqlCommand cmd = new SqlCommand("delete from BanDoc where MaBanDoc = @MaBanDoc", con);
                cmd.Parameters.AddWithValue("@MaBanDoc", showInfromationdataGridView.Rows[dongchon].Cells["MaBanDoc"].Value.ToString());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa bạn đọc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa bạn đọc thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienThiThongTin();
            }
            catch
            {
                MessageBox.Show("Bạn đọc có mã này đang trong thời gian mượn sách nên không thể xóa khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from BanDoc where MaBanDoc like N'%" + txtTimKiem.Text + "%'" +
                                        "or TenBanDoc like N'%" + txtTimKiem.Text + "%'" +
                                        "or DiaChi like N'%" + txtTimKiem.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            showInfromationdataGridView.DataSource = dt;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BanDoc_Load(sender, e);
        }
    }
}


