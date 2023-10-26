using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoKhuDuLich
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        // git change
        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // thoat 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtDangNhap.Text;
            string matkhau = txtMatKhau.Text;

            // Read the text file
            string[] lines = File.ReadAllLines(@"D:\hk3\LTUD\DoAnLTUD\login.txt");

            // Check for a match
            bool timThay = false;
            foreach (string line in lines)
            {
                string[] dangNhap = line.Split('\t');
                string luuTendangnhap = dangNhap[0];
                string luuMatkhau = dangNhap[1];

                if (tendangnhap == luuTendangnhap && matkhau == luuMatkhau)
                {
                    timThay = true;
                    break;
                }
            }
            if (timThay)
            {
                MessageBox.Show("Dang nhap thanh cong");
                // Open new window or perform any other action
                Hide(); // an login 
                        //mo tab he thong
                frmHeThong frmHeThong = new frmHeThong();
                frmHeThong.Show();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
            }
        } 

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;

            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

