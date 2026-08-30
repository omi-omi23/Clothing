using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clothing
{
    public partial class ProductStockForEmp : Form
    {
        private readonly string connectionString = @"Data Source=SNIGDHA-OMI-23;Initial Catalog=ClothingStoreDB;Integrated Security=True;";

        public ProductStockForEmp()
        {
            InitializeComponent();
            LoadProductStock();
        }

        private void ProductStockForEmp_Load(object sender, EventArgs e)
        {

        }

        private void LoadProductStock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    
                    string query = "SELECT ProductID, ProductName, Category, Price FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStock.DataSource = dt;
                    dgvStock.ReadOnly = true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeDashBoard empDash = new EmployeeDashBoard();
            empDash.Show();
            this.Hide();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}