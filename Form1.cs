using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace EmployeeInformationSystem
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        void LoadEmployees()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Employees (Name, Department, Salary) VALUES (@n,@d,@s)", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@d", txtDept.Text);
                cmd.Parameters.AddWithValue("@s", txtSalary.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadEmployees();
            MessageBox.Show("Employee Added Successfully");
        }
    }
}
