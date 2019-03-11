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
namespace FYP1
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;
        private void Student_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo from Person join Student on Person.Id = Student.Id", conn);
            adapter.Fill(dt);
            dataGridStudentdetail.DataSource = dt;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text !="" && txtlastname.Text !="" && txtemail.Text!=""&& txtdob.Text!="")
            {
                conn.Open();
                string query = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txtfirstname.Text + "','" + txtlastname.Text + "','"+txtcontactno.Text+"','"+txtemail.Text+"','"+Convert.ToDateTime(txtdob.Text).ToString()+"',(select Id from Lookup where Value='"+combogender.Text+"'))";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Student(RegistrationNo, Id) values('"+txtregno.Text+ "', (Select Id from Person where Contact='" + txtcontactno.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                cdn1.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id,Person.FirstName,Person.LastName,person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person inner join Student on Person.Id=Student.Id", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;
                txtfirstname.Text = "";
                txtlastname.Text = "";
                txtemail.Text = "";
                txtdob.Text = "";
                txtregno.Text = "";
                txtcontactno.Text = "";
                
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Provide complete information");
            }
        }

        private void dataGridStudentdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridStudentdetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridStudentdetail_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridStudentdetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text =dataGridStudentdetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdob.Text = Convert.ToDateTime(dataGridStudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text =Convert.ToInt32(dataGridStudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString()).ToString();
            txtregno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontactno.Text != "" )
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Person Set [FirstName]='" + txtfirstname.Text + "', [LastName] ='" + txtlastname.Text + "',Contact = '" + txtcontactno.Text + "',Email='" + txtemail.Text + "', DateOfBirth='" + Convert.ToDateTime(txtdob.Text).ToString() + "',Gender=(select Id from Lookup where Value='" + combogender.Text + "') where id='"+id+"'", conn);

                command.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand("Update Student set [RegistrationNo]='" + txtregno.Text + "' where Id=(select Id from Person where [FirstName]='" + txtfirstname.Text + "' and [LastName] ='" + txtlastname.Text + "' and Contact = '" + txtcontactno.Text + "' and Email='" + txtemail.Text + "' and DateOfBirth='" + Convert.ToDateTime(txtdob.Text).ToString() + "' and Gender=(select Id from Lookup where Value='" + combogender.Text + "'))", conn);

                command1.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id,Person.FirstName,Person.LastName,person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person join Student on Person.Id=Student.Id", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtemail.Text = "";
                combogender.Text = "";
                txtcontactno.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please provide all Information!!!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                int id1 = id;
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Student where id='" + id+ "'", conn);


                cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Delete from Person where Id='"+id1+"'", conn);
                cmd.ExecuteNonQuery();
               
                conn.Close();
                MessageBox.Show("Data Delete successfully!!");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id,Person.FirstName,Person.LastName,person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person inner join Student on Person.Id=Student.Id", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtemail.Text = "";
                combogender.Text = "";
                txtcontactno.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }
       
        private void combogender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn.Open();
            //query1 = "Select Id from Lookup where Value='"+combogender.Text+"';";
            //conn.Close();
        }
    }
}
