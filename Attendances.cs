using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SouhaSchoolManagementSystem
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int Key = 0;
        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StId.SelectedValue = AttendanceDGV.SelectedRows[0].Cells[1].Value.ToString();
            STNameTb.Text = AttendanceDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttDatePicker.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttStatusCb.SelectedItem = AttendanceDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (STNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendanceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
