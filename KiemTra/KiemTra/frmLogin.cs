using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtpassword.Text;

            if (username.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmMain frm = new frmMain();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
            }
        }
        
    }
}
