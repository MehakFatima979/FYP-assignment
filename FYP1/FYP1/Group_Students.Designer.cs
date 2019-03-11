namespace FYP1
{
    partial class Group_Students
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
            this.dataGridViewstudentdetails = new System.Windows.Forms.DataGridView();
            this.btncopy = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxcreated = new System.Windows.Forms.ComboBox();
            this.dateTimeassignment = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewstudentdetails
            // 
            this.dataGridViewstudentdetails.AllowUserToAddRows = false;
            this.dataGridViewstudentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudentdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.FirstName,
            this.LastName,
            this.Contact,
            this.Email,
            this.Gender,
            this.DateOfBirth});
            this.dataGridViewstudentdetails.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewstudentdetails.Name = "dataGridViewstudentdetails";
            this.dataGridViewstudentdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewstudentdetails.Size = new System.Drawing.Size(778, 203);
            this.dataGridViewstudentdetails.TabIndex = 0;
            this.dataGridViewstudentdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudentdetails_CellContentClick);
            this.dataGridViewstudentdetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewstudentdetails_MouseClick);
            // 
            // btncopy
            // 
            this.btncopy.Location = new System.Drawing.Point(688, 221);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(104, 31);
            this.btncopy.TabIndex = 2;
            this.btncopy.Text = "Copy";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(569, 221);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(113, 31);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewGroup.Location = new System.Drawing.Point(12, 261);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroup.Size = new System.Drawing.Size(778, 203);
            this.dataGridViewGroup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assignment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Created Date";
            // 
            // comboBoxcreated
            // 
            this.comboBoxcreated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcreated.FormattingEnabled = true;
            this.comboBoxcreated.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.comboBoxcreated.Location = new System.Drawing.Point(316, 478);
            this.comboBoxcreated.Name = "comboBoxcreated";
            this.comboBoxcreated.Size = new System.Drawing.Size(200, 21);
            this.comboBoxcreated.TabIndex = 8;
            // 
            // dateTimeassignment
            // 
            this.dateTimeassignment.Location = new System.Drawing.Point(316, 563);
            this.dateTimeassignment.Name = "dateTimeassignment";
            this.dateTimeassignment.Size = new System.Drawing.Size(200, 20);
            this.dateTimeassignment.TabIndex = 9;
            // 
            // dateTimeCreated
            // 
            this.dateTimeCreated.Location = new System.Drawing.Point(317, 519);
            this.dateTimeCreated.Name = "dateTimeCreated";
            this.dateTimeCreated.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCreated.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(625, 580);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Group_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 615);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dateTimeCreated);
            this.Controls.Add(this.dateTimeassignment);
            this.Controls.Add(this.comboBoxcreated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGroup);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.dataGridViewstudentdetails);
            this.Name = "Group_Students";
            this.Text = "Group_Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudentdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewstudentdetails;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxcreated;
        private System.Windows.Forms.DateTimePicker dateTimeassignment;
        private System.Windows.Forms.DateTimePicker dateTimeCreated;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}