using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing
{
    public partial class HomeForm : Form
    {
        private readonly string connectionString = @"Data Source=SNIGDHA-OMI-23;Initial Catalog=ClothingStoreDB;Integrated Security=True;";
        public HomeForm()
        {
            InitializeComponent();
            LoadProducts("All");
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadProducts(string category)
        {
            flpcontentdress.Controls.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "";

                if (category != "All")
                {
                    query = "SELECT * FROM Products WHERE Category = @category OR ProductName LIKE '%' + @category + '%'";
                }
                else {
                    query = "SELECT * FROM Products";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                if (category != "All")
                {
                    cmd.Parameters.AddWithValue("@category", category);
                }

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int pId = Convert.ToInt32(reader["ProductID"]);
                        string pName = reader["ProductName"].ToString();
                        string price = "BDT " + reader["Price"].ToString();
                        double pPrice = Convert.ToDouble(reader["Price"]);
                        string imgPath = reader["ImagePath"].ToString();

                        Panel pnlCard = new Panel();
                        pnlCard.Size = new Size(180, 260);
                        pnlCard.BorderStyle = BorderStyle.FixedSingle;
                        pnlCard.Margin = new Padding(10);

                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(160, 110);
                        pic.Location = new Point(10, 10);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        if (System.IO.File.Exists(imgPath))
                        {
                            pic.ImageLocation = imgPath;
                        }
                        else
                        {
                            pic.Image = null;
                        }

                        Label lblName = new Label();
                        lblName.Text = pName;
                        lblName.Font = new Font("Arial", 9, FontStyle.Bold);
                        lblName.Location = new Point(10, 145);
                        lblName.AutoSize = true;

                        Label lblPrice = new Label();
                        lblPrice.Text = price;
                        lblPrice.Font = new Font("Arial", 9, FontStyle.Regular);
                        lblPrice.Location = new Point(10, 170);
                        lblPrice.ForeColor = Color.DarkGreen;

                        Button btnAddToCart = new Button();
                        btnAddToCart.Text = "Add to Cart";
                        btnAddToCart.Font = new Font("Arial", 8, FontStyle.Bold);
                        btnAddToCart.Size = new Size(160, 30);
                        btnAddToCart.Location = new Point(10, 195);
                        btnAddToCart.BackColor = Color.SaddleBrown;
                        btnAddToCart.ForeColor = Color.White;
                        btnAddToCart.FlatStyle = FlatStyle.Flat;
                        btnAddToCart.Tag = pId;

                        btnAddToCart.Click += (sender, e) =>   
                        {
                            Button btn = (Button)sender;
                            AddToCart(pName, pPrice);
                        };

                        pnlCard.Controls.Add(pic);
                        pnlCard.Controls.Add(lblName);
                        pnlCard.Controls.Add(lblPrice);
                        pnlCard.Controls.Add(btnAddToCart);

                        flpcontentdress.Controls.Add(pnlCard);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddToCart(string productName, double price)   
        {
            bool found = false;

            foreach (CartItem item in MyCartForm.CartList)
            {
                if (item.ProductName == productName)
                {
                    item.Quantity++; 
                    found = true;
                    break; 
                }
            }

            if (!found)
            {
                CartItem newItem = new CartItem(productName, price, 1);
                MyCartForm.CartList.Add(newItem);
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"UPDATE UserLogin 
                SET SelectedProductName = 
                    CASE 
                        WHEN SelectedProductName IS NULL OR SelectedProductName = '' THEN @ProductName 
                        ELSE SelectedProductName + ', ' + @ProductName 
                    END 
                WHERE LOWER(TRIM(Username)) = LOWER(TRIM(@Username))";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);

                        
                        cmd.Parameters.AddWithValue("@Username", Form1.LoggedInUser);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Update Error: " + ex.Message);
            }

            MessageBox.Show(productName + " added to cart!");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }


        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnCategories_Click(object sender, EventArgs e)
        {
            pnlCategories.Visible =! pnlCategories.Visible; 
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadProducts("All");
        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            LoadProducts("Women");
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            LoadProducts("Men");
        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            LoadProducts("Kids");
        }

       
        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(textBoxSearch.Text);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (MyCartForm.CartList.Count == 0)
            {
                MessageBox.Show("Your cart is empty!","Empty Cart",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return; 
            }

            MyCartForm productsummary = new MyCartForm();
            productsummary.WindowState = FormWindowState.Maximized;
            productsummary.ShowDialog();
            //productsummary.Show();
            //this.Hide();
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }

        private void flpcontentdress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
