
using System;

namespace SouhaSchoolManagementSystem
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StGenCb = new System.Windows.Forms.ComboBox();
            this.ClassCb = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDbDataSet = new SouhaSchoolManagementSystem.SchoolDbDataSet();
            this.studentTblTableAdapter = new SouhaSchoolManagementSystem.SchoolDbDataSetTableAdapters.StudentTblTableAdapter();
            this.schoolDbDataSet1 = new SouhaSchoolManagementSystem.SchoolDbDataSet();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 69);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(830, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StNameTb
            // 
            this.StNameTb.Location = new System.Drawing.Point(31, 163);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(98, 20);
            this.StNameTb.TabIndex = 9;
            this.StNameTb.TextChanged += new System.EventHandler(this.StNameTb_TextChanged);
            // 
            // FeesTb
            // 
            this.FeesTb.Location = new System.Drawing.Point(607, 157);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(100, 20);
            this.FeesTb.TabIndex = 10;
            this.FeesTb.TextChanged += new System.EventHandler(this.FeesTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(624, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fees";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // StGenCb
            // 
            this.StGenCb.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StGenCb.FormattingEnabled = true;
            this.StGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StGenCb.Location = new System.Drawing.Point(159, 157);
            this.StGenCb.Name = "StGenCb";
            this.StGenCb.Size = new System.Drawing.Size(94, 24);
            this.StGenCb.TabIndex = 13;
            this.StGenCb.SelectedIndexChanged += new System.EventHandler(this.StGenCb_SelectedIndexChanged);
            // 
            // ClassCb
            // 
            this.ClassCb.FormattingEnabled = true;
            this.ClassCb.Items.AddRange(new object[] {
            "7th",
            "8th",
            "9th"});
            this.ClassCb.Location = new System.Drawing.Point(464, 157);
            this.ClassCb.Name = "ClassCb";
            this.ClassCb.Size = new System.Drawing.Size(108, 21);
            this.ClassCb.TabIndex = 14;
            this.ClassCb.SelectedIndexChanged += new System.EventHandler(this.ClassCb_SelectedIndexChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(307, 230);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(97, 33);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(596, 230);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(97, 33);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(167, 230);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(97, 33);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(450, 230);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(97, 33);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(317, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Students List";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBPicker.Location = new System.Drawing.Point(303, 157);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(102, 26);
            this.DOBPicker.TabIndex = 20;
            this.DOBPicker.ValueChanged += new System.EventHandler(this.DOBPicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(154, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(288, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date Of Birth";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(474, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Class";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIdDataGridViewTextBoxColumn,
            this.stNameDataGridViewTextBoxColumn,
            this.stGenDataGridViewTextBoxColumn,
            this.stDOBDataGridViewTextBoxColumn,
            this.stClassDataGridViewTextBoxColumn,
            this.stFeesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentTblBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(31, 340);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 92);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stIdDataGridViewTextBoxColumn
            // 
            this.stIdDataGridViewTextBoxColumn.DataPropertyName = "StId";
            this.stIdDataGridViewTextBoxColumn.HeaderText = "StId";
            this.stIdDataGridViewTextBoxColumn.Name = "stIdDataGridViewTextBoxColumn";
            this.stIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stNameDataGridViewTextBoxColumn
            // 
            this.stNameDataGridViewTextBoxColumn.DataPropertyName = "StName";
            this.stNameDataGridViewTextBoxColumn.HeaderText = "StName";
            this.stNameDataGridViewTextBoxColumn.Name = "stNameDataGridViewTextBoxColumn";
            // 
            // stGenDataGridViewTextBoxColumn
            // 
            this.stGenDataGridViewTextBoxColumn.DataPropertyName = "StGen";
            this.stGenDataGridViewTextBoxColumn.HeaderText = "StGen";
            this.stGenDataGridViewTextBoxColumn.Name = "stGenDataGridViewTextBoxColumn";
            // 
            // stDOBDataGridViewTextBoxColumn
            // 
            this.stDOBDataGridViewTextBoxColumn.DataPropertyName = "StDOB";
            this.stDOBDataGridViewTextBoxColumn.HeaderText = "StDOB";
            this.stDOBDataGridViewTextBoxColumn.Name = "stDOBDataGridViewTextBoxColumn";
            // 
            // stClassDataGridViewTextBoxColumn
            // 
            this.stClassDataGridViewTextBoxColumn.DataPropertyName = "StClass";
            this.stClassDataGridViewTextBoxColumn.HeaderText = "StClass";
            this.stClassDataGridViewTextBoxColumn.Name = "stClassDataGridViewTextBoxColumn";
            // 
            // stFeesDataGridViewTextBoxColumn
            // 
            this.stFeesDataGridViewTextBoxColumn.DataPropertyName = "StFees";
            this.stFeesDataGridViewTextBoxColumn.HeaderText = "StFees";
            this.stFeesDataGridViewTextBoxColumn.Name = "stFeesDataGridViewTextBoxColumn";
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.schoolDbDataSet;
            // 
            // schoolDbDataSet
            // 
            this.schoolDbDataSet.DataSetName = "SchoolDbDataSet";
            this.schoolDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // schoolDbDataSet1
            // 
            this.schoolDbDataSet1.DataSetName = "SchoolDbDataSet";
            this.schoolDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(752, 155);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(114, 80);
            this.AddressTb.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(763, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Adress";
            // 
            // Students
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ClassCb);
            this.Controls.Add(this.StGenCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Back_button:
        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StGenCb;
        private System.Windows.Forms.ComboBox ClassCb;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDbDataSet schoolDbDataSet;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private SchoolDbDataSetTableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFeesDataGridViewTextBoxColumn;
        private SchoolDbDataSet schoolDbDataSet1;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label label8;
    }
}