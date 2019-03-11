namespace FYP1
{
    partial class Student
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtdob = new System.Windows.Forms.DateTimePicker();
            this.dataGridStudentdetail = new System.Windows.Forms.DataGridView();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.lblregno = new System.Windows.Forms.Label();
            this.txtregno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(38, 37);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(57, 13);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(38, 63);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(58, 13);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(320, 34);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Email";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(297, 60);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(320, 93);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "Gender";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(371, 34);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(198, 20);
            this.txtemail.TabIndex = 8;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(112, 34);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(177, 20);
            this.txtfirstname.TabIndex = 9;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(112, 60);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(177, 20);
            this.txtlastname.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(100, 156);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(260, 156);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(427, 156);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // combogender
            // 
            this.combogender.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(368, 93);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(201, 21);
            this.combogender.TabIndex = 15;
            this.combogender.SelectedIndexChanged += new System.EventHandler(this.combogender_SelectedIndexChanged);
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(371, 60);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(198, 20);
            this.txtdob.TabIndex = 17;
            // 
            // dataGridStudentdetail
            // 
            this.dataGridStudentdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudentdetail.Location = new System.Drawing.Point(41, 185);
            this.dataGridStudentdetail.Name = "dataGridStudentdetail";
            this.dataGridStudentdetail.Size = new System.Drawing.Size(528, 217);
            this.dataGridStudentdetail.TabIndex = 18;
            this.dataGridStudentdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudentdetail_CellContentClick);
            this.dataGridStudentdetail.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridStudentdetail_CellMouseDoubleClick);
            this.dataGridStudentdetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridStudentdetail_RowHeaderMouseClick);
            this.dataGridStudentdetail.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridStudentdetail_RowHeaderMouseDoubleClick);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(112, 86);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(177, 20);
            this.txtcontactno.TabIndex = 19;
            // 
            // lblregno
            // 
            this.lblregno.AutoSize = true;
            this.lblregno.Location = new System.Drawing.Point(38, 119);
            this.lblregno.Name = "lblregno";
            this.lblregno.Size = new System.Drawing.Size(47, 13);
            this.lblregno.TabIndex = 20;
            this.lblregno.Text = "Reg. No";
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(112, 112);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(177, 20);
            this.txtregno.TabIndex = 21;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 414);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.lblregno);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.dataGridStudentdetail);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.DateTimePicker txtdob;
        private System.Windows.Forms.DataGridView dataGridStudentdetail;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.Label lblregno;
        private System.Windows.Forms.TextBox txtregno;
    }
}