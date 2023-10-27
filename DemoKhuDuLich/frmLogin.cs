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
        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // thoat 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtDangNhap.Text;
            string matkhau = txtMatKhau.Text;

            // Read the text file
            string[] lines = File.ReadAllLines(@"D:\hk3\LTUD\DoAnLTUD1\login.txt");

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
        static bool CheckUser(string userName, string password)
        {
            try {
                // Read the text file
                string[] lines = File.ReadAllLines(@"D:\hk3\LTUD\DoAnLTUD1\login.txt");
                foreach (string line in lines)
                {
                    string[] dangNhap = line.Split('\t');
                    string luuTendangnhap = dangNhap[0];
                    string luuMatkhau = dangNhap[1];

                    if (userName == luuTendangnhap && password == luuMatkhau)
                    {
                        return true;
                        break;
                    }
                }

            } 
            catch {
                MessageBox.Show("lỗi truy xuất thông tin ngưởi dùng, kiểm tra đường dẫn !!");
            }
            return false;
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
        /// <summary>
        /// khi nhấn enter ở textMatKhau sẽ chuyển xuống khiểm tra luôn. true thì tiếp tục.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (CheckUser(txtDangNhap.Text, txtMatKhau.Text)
)
                {
                    Hide(); // an login 
                    frmHeThong frmHeThong = new frmHeThong();
                    frmHeThong.Show();//mo tab he thong
                }
                else
                {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");

                }
            }

        }
    }
}

