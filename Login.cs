using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouhaSchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter UserName and Password please!");
            }
            else if (UnameTb.Text == "Souha" && PasswordTb.Text == "Souha123")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                UnameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
