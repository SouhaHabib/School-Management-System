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

namespace SouhaSchoolManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Souha\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void CountStudents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StdLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountTeachers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from TeacherTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Tlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountEvents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from EventsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Elbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumFees()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Amt) from FeesTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FeesLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudents();
            CountTeachers();
            CountEvents();
            SumFees();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
