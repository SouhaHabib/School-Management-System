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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvents();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Souha\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayEvents()
        {
            Con.Open();

            string Query = "Select * from EventsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            EdurationTb.Text = "";
            EDescTb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventsTbl(EDesc,EDate,Eduration) values(@EvDesc,@EvDate,@Evdur)", Con);


                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", Edate.Value.Date);
                    cmd.Parameters.AddWithValue("@Evdur", EdurationTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added");

                    Con.Close();

                    DisplayEvents();

                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        int Key = 0;
        private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EDescTb.Text = EventsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Edate.Text = EventsDGV.SelectedRows[0].Cells[2].Value.ToString();
            EdurationTb.Text = EventsDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (EDescTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EventsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Event");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("delete from EventsTbl where EId= @EKey", Con);

                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event Deleted");

                    Con.Close();
                    DisplayEvents();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventsTbl set EDesc=@EvDesc,EDate=@EvDate,Eduration=@Evdur where EId=@EvID", Con);

                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", Edate.Value.Date);
                    cmd.Parameters.AddWithValue("@Evdur", EdurationTb.Text);
                    cmd.Parameters.AddWithValue("@EvID", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated");

                    Con.Close();
                    DisplayEvents();
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
