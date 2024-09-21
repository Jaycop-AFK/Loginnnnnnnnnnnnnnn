using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginnnnnnnnnnnnnnn
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>()
{
    { "user1", "1234" }, 
    { "user2", "5678" }  
};

        string logUsername;
        string logPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_login_Click(object sender, EventArgs e)
        {
            logUsername = tUser.Text;
            logPassword = tPwd.Text;

            if (users.ContainsKey(logUsername) && users[logUsername] == logPassword)
            {
                if (logUsername == "user2")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tPwd.Text = string.Empty;
                tPwd.Select();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c_password_CheckedChanged(object sender, EventArgs e)
        {
            if (c_password.Checked)
            {
                tPwd.UseSystemPasswordChar = false;
            }
            else
            {
                tPwd.UseSystemPasswordChar = true;
            }
        }
    }
}
