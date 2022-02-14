
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SouhaSchoolManagementSystem
{
    partial class Attendances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendances));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AttDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AttStatusCb = new System.Windows.Forms.ComboBox();
            this.StId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.STNameTb = new System.Windows.Forms.TextBox();
            this.AttendanceDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 69);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(786, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendances";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(302, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 37);
            this.label4.TabIndex = 53;
            this.label4.Text = "Attendance List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(456, 214);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(97, 33);
            this.DeleteBtn.TabIndex = 52;
            this.DeleteBtn.Text = "Reset";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(138, 214);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(97, 33);
            this.AddBtn.TabIndex = 51;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(616, 214);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(97, 33);
            this.BackBtn.TabIndex = 50;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(295, 214);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(97, 33);
            this.EditBtn.TabIndex = 49;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(665, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(477, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(55, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 68;
            this.label5.Text = "Student Id";
            // 
            // AttDatePicker
            // 
            this.AttDatePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AttDatePicker.Location = new System.Drawing.Point(447, 147);
            this.AttDatePicker.Name = "AttDatePicker";
            this.AttDatePicker.Size = new System.Drawing.Size(119, 26);
            this.AttDatePicker.TabIndex = 67;
            // 
            // AttStatusCb
            // 
            this.AttStatusCb.FormattingEnabled = true;
            this.AttStatusCb.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.AttStatusCb.Location = new System.Drawing.Point(655, 147);
            this.AttStatusCb.Name = "AttStatusCb";
            this.AttStatusCb.Size = new System.Drawing.Size(108, 21);
            this.AttStatusCb.TabIndex = 66;
            // 
            // StId
            // 
            this.StId.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StId.FormattingEnabled = true;
            this.StId.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StId.Location = new System.Drawing.Point(61, 151);
            this.StId.Name = "StId";
            this.StId.Size = new System.Drawing.Size(94, 26);
            this.StId.TabIndex = 65;
            this.StId.SelectionChangeCommitted += new System.EventHandler(this.StId_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(236, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Student Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // STNameTb
            // 
            this.STNameTb.Enabled = false;
            this.STNameTb.Location = new System.Drawing.Point(230, 151);
            this.STNameTb.Name = "STNameTb";
            this.STNameTb.Size = new System.Drawing.Size(133, 20);
            this.STNameTb.TabIndex = 61;
            // 
            // AttendanceDGV
            // 
            this.AttendanceDGV.BackgroundColor = System.Drawing.Color.White;
            this.AttendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceDGV.GridColor = System.Drawing.Color.LightGray;
            this.AttendanceDGV.Location = new System.Drawing.Point(128, 345);
            this.AttendanceDGV.Name = "AttendanceDGV";
            this.AttendanceDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AttendanceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceDGV.Size = new System.Drawing.Size(538, 121);
            this.AttendanceDGV.TabIndex = 71;
            this.AttendanceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceDGV_CellContentClick);
            // 
            // Attendances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 547);
            this.Controls.Add(this.AttendanceDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AttDatePicker);
            this.Controls.Add(this.AttStatusCb);
            this.Controls.Add(this.StId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.STNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendances";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (STNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AttendanceTbl set AttStId=@StId,AttStName=@StName,AttDate=@ADate,AttStatus=@AStatus where AttNum=@ANum", Con);

                    cmd.Parameters.AddWithValue("@StId", StId.SelectedValue.ToString()); //StId combobox 
                    cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");

                    Con.Close();
                    DisplayAttendance();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select StId from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            /*Student combobox named StId */StId.ValueMember = "StId";
            StId.DataSource = dt;
            Con.Close();
        }

        private void GetStudName()
        {
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where StId=@SID",Con);
            Cmd.Parameters.AddWithValue("@SID", StId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                STNameTb.Text = dr["StName"].ToString();
            }

            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Souha\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            STNameTb.Text = "";
            StId.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (STNameTb.Text == "" || AttStatusCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTbl(AttStId,AttStName,AttDate,AttStatus) values(@StId,@StName,@AttDate,@Status)", Con);


                    cmd.Parameters.AddWithValue("@StId", StId.SelectedValue.ToString()); //StId combobox 
                    cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Taken");

                    Con.Close();

                    DisplayAttendance();

                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker AttDatePicker;
        private System.Windows.Forms.ComboBox AttStatusCb;
        private System.Windows.Forms.ComboBox StId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox STNameTb;
        private System.Windows.Forms.DataGridView AttendanceDGV;
    }
}