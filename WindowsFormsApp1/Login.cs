using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "user" && textBoxPwd.Text == "321")
            {
                Program.isValidUser = true;
                this.Close();
            }
            else if(textBoxUserName.Text == "" || textBoxPwd.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！","警告");
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","警告");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Program.isValidUser = false;
            this.Close();
        }


    }
}
