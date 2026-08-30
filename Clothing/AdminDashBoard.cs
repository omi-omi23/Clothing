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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Clothing
{
    public partial class AdminDashBoard : Form
    {
        
        private readonly string connectionString = @"Data Source=SNIGDHA-OMI-23;Initial Catalog=ClothingStoreDB;Integrated Security=True;";

        public AdminDashBoard()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void LoadOverviewCounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string customerQuery = "SELECT COUNT(*) FROM UserLogin";
                    using (SqlCommand cmd = new SqlCommand(customerQuery, con))
                    {
                        label5.Text = cmd.ExecuteScalar().ToString();
                    }

                    
                    string productQuery = "SELECT COUNT(*) FROM Products";
                    using (SqlCommand cmd = new SqlCommand(productQuery, con))
                    {
                        label6.Text = cmd.ExecuteScalar().ToString();
                    }

                 
                    string empQuery = "SELECT COUNT(*) FROM Employees WHERE Status = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(empQuery, con))
                    {
                        label7.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadCustomerTableData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    Dictionary<string, double> productPrices = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                    string prodQuery = "SELECT ProductName, Price FROM Products";
                    using (SqlCommand cmdProd = new SqlCommand(prodQuery, con))
                    {
                        using (SqlDataReader reader = cmdProd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string pName = reader["ProductName"].ToString().Trim();
                                double pPrice = Convert.ToDouble(reader["Price"]);
                                if (!productPrices.ContainsKey(pName))
                                {
                                    productPrices.Add(pName, pPrice);
                                }
                            }
                        }
                    }

                    
                    string userQuery = "SELECT Username AS [Customer Name], SelectedProductName AS [Chosen Product] FROM UserLogin";
                    SqlDataAdapter adapter = new SqlDataAdapter(userQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                   
                    dt.Columns.Add("Price", typeof(string));

                  
                    foreach (DataRow row in dt.Rows)
                    {
                        string selectedProducts = row["Chosen Product"] != DBNull.Value ? row["Chosen Product"].ToString() : "";

                        if (!string.IsNullOrWhiteSpace(selectedProducts))
                        {
                            double totalPrice = 0;
                            
                            string[] items = selectedProducts.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                            foreach (string item in items)
                            {
                                string cleanItem = item.Trim();
                                if (productPrices.ContainsKey(cleanItem))
                                {
                                    totalPrice += productPrices[cleanItem];
                                }
                            }

                            row["Price"] = totalPrice > 0 ? totalPrice.ToString("F2") : "0.00";
                        }
                        else
                        {
                            row["Price"] = "0.00";
                        }
                    }

                    
                    dgvCustomerData.DataSource = null;
                    dgvCustomerData.DataSource = dt;
                    dgvCustomerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table Load Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            LoadOverviewCounts();
            LoadCustomerTableData();
        }

        private void btnOverView(object sender, EventArgs e)
        {
            LoadOverviewCounts(); 
        }

        private void btnLogout(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void AdminDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblTotalCustomer(object sender, EventArgs e) { }
        private void lblProductStock(object sender, EventArgs e) { }
        private void lblActiveEmployee(object sender, EventArgs e) { }

       
        private void label1_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void btnCustomer(object sender, EventArgs e)
        {
            LoadCustomerTableData();
        }
        private void btnEmployee(object sender, EventArgs e) 
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }
        private void btnInventory(object sender, EventArgs e) { }
        private void btnorder(object sender, EventArgs e) { }

        private void dgvCustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}