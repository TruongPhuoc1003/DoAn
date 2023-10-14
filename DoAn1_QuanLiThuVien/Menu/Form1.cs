using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

       

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MdiParent = this;

            s.Show();
        }

        private void quảnLíPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MdiParent = this;
            pn.Show();
        }

        private void quảnLíPhiếuNhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhieuNhapSach pns = new PhieuNhapSach();
            pns.MdiParent = this;
            pns.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn đăg xuất không!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult.Yes == kq)
            {
                this.Hide();
                DangNhap dangnhap = new DangNhap();
                dangnhap.ShowDialog();
                this.Close();
            }
        }

        private void quảnLíPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonTra pmt = new PhieuMuonTra();
            pmt.MdiParent = this;
            pmt.Show();
        }

        private void quảnLíPhiếuMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonTraSach pmts = new PhieuMuonTraSach();
            pmts.MdiParent = this;
            pmts.Show();
        }

        private void bạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanDoc bd = new BanDoc();
            bd.MdiParent = this;
            bd.Show();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
