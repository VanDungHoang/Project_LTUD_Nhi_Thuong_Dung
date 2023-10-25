using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoKhuDuLich
{
    public partial class frmHeThong : Form
    {
        
        public frmHeThong()
        {
            
            InitializeComponent();
        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            //lblXinChao.Text = "Xin chào nhân viên [" + NhanVienDangNhap.Ten + "]";
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Thông Tin Tài Khoản")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                this.Hide(); 
                
                frmThongTinTaiKHoan tttk  = new frmThongTinTaiKHoan();
                tttk.ShowDialog();
                this.Show();
            }
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Thông Tin khách hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                this.Hide();

                frmKhachHang  ttkh = new frmKhachHang();
                ttkh.ShowDialog();
                this.Show();
            }
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Thông Tin Dịch Vụ")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                this.Hide();
                frmDichVu ttdv = new frmDichVu();
                ttdv.ShowDialog();
                this.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
