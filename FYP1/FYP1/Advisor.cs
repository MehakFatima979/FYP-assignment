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
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && dateTimedob.Text != "" && txtcontactno.Text!="" && txtsalary.Text !="" && combodesignation.Text !="" && combogender.Text !="" )
            {
                conn.Open();
                string query = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtcontactno.Text + "','" + txtemail.Text + "','" + Convert.ToDateTime(dateTimedob.Text).ToString() + "',(select Id from Lookup where Value='" + combogender.Text + "'))";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Advisor(Designation,Salary,Id) values((select Id from Lookup where Value='"+combodesignation.Text+"'),'" + txtsalary.Text+"', (Select Id from Person where Contact='" + txtcontactno.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                cdn1.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
                adapter.Fill(dt);
                dataGridViewadvisor.DataSource = dt;
                txtfirstname.Text = "";
                txtlastname.Text = "";
                txtemail.Text = "";
                dateTimedob.Text = "";
                txtsalary.Text = "";
                txtcontactno.Text = "";
                combodesignation.Text = "";
                combogender.Text = "";
                
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Provide complete information");
            }
        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
            adapter.Fill(dt);
            dataGridViewadvisor.DataSource = dt;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewadvisor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimedob.Text = Convert.ToDateTime(dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text = Convert.ToInt32(dataGridViewadvisor.Rows[e.RowIndex].Cells[6].Value.ToString()).ToString();
           
            combodesignation.Text = query;
            txtsalary.Text= dataGridViewadvisor.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        string query;
        private void combodesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewadvisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            query = "select Value from Lookup where Id='" + dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString() + "'";
        }
    }
}
