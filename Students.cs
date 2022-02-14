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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Souha\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
    private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || StGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StFees,StAdd) values(@Sname,@SGen,@SDob,@SClass,@SFees,@SAdd)", Con);

                   
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");

                    Con.Close();
 
                    DisplayStudent();

                    Reset();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDbDataSet.StudentTbl' table. You can move, or remove it, as needed.
            this.studentTblTableAdapter.Fill(this.schoolDbDataSet.StudentTbl);

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            FeesTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;
        }

        int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            StGenCb.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DOBPicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ClassCb.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            FeesTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("delete from StudentTbl where StId= @StKey", Con);

                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student Deleted");

                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClassCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FeesTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void StNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || StGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set StName=@Sname,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StFees=@SFees,StAdd=@SAdd where StId=@StudentID", Con);

                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@StudentID", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");

                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }
    }
}
