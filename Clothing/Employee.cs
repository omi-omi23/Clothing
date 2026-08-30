using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clothing
{
    public partial class Employee : Form
    {
        
        private SqlConnection con = new SqlConnection(@"Data Source=SNIGDHA-OMI-23;Initial Catalog=ClothingStoreDB;Integrated Security=True");

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        
        private void PopulateData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "SELECT EmployeeID, FullName, Username, Phone, Designation, Salary, Status FROM Employees";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvEmployees.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        
        public void AddEmployee(string fullName, string username, string password, string phone, string designation, decimal salary)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = "INSERT INTO Employees (FullName, Username, Password, Phone, Designation, Salary, Status) " +
                               "VALUES (@FullName, @Username, @Password, @Phone, @Designation, @Salary, 'Active')";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Designation", designation);
                    cmd.Parameters.AddWithValue("@Salary", salary);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopulateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

       
        public void BackToDashboard()
        {
            AdminDashBoard dashboard = new AdminDashBoard();
            dashboard.Show();
            this.Close();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                AddEmployee(txtFullName.Text, txtUsername.Text, txtPassword.Text, txtPhone.Text, txtDesignation.Text, salary);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard();
        }
    }
}