namespace FYP1
{
    partial class manageprojects
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewprojects = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprojects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(139, 195);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(97, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprojectname
            // 
            this.txtprojectname.Location = new System.Drawing.Point(139, 28);
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(250, 20);
            this.txtprojectname.TabIndex = 1;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(139, 97);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(250, 70);
            this.txtdescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewprojects
            // 
            this.dataGridViewprojects.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprojects.Location = new System.Drawing.Point(35, 224);
            this.dataGridViewprojects.Name = "dataGridViewprojects";
            this.dataGridViewprojects.Size = new System.Drawing.Size(586, 225);
            this.dataGridViewprojects.TabIndex = 5;
            this.dataGridViewprojects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprojects_CellContentClick);
            this.dataGridViewprojects.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewprojects_RowHeaderMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(289, 195);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(436, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(464, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // manageprojects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 461);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridViewprojects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtprojectname);
            this.Controls.Add(this.btnadd);
            this.Name = "manageprojects";
            this.Text = "Manage Projects";
            this.Load += new System.EventHandler(this.manageprojects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprojects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewprojects;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

