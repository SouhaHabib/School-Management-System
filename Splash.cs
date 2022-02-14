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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyprogressBar.Value = startpoint;
            Percentage.Text = startpoint + "%";
            if (MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
