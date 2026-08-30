using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Clothing
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Data Source=SNIGDHA-OMI-23;Initial Catalog=ClothingStoreDB;Integrated Security=True;";
        public static string LoggedInUser = "";
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string adminQuery = "SELECT COUNT(*) FROM Admins WHERE LOWER(TRIM(Username)) = LOWER(TRIM(@Username)) AND Password = @Password";
                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, con))
                    {
                        adminCmd.Parameters.AddWithValue("@Username", username);
                        adminCmd.Parameters.AddWithValue("@Password", password);

                        int adminCount = Convert.ToInt32(adminCmd.ExecuteScalar());

                        if (adminCount > 0)
                        {
                            MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            LoggedInUser = username;

                            AdminDashBoard adminDash = new AdminDashBoard();
                            adminDash.Show();
                            this.Hide();
                            return;
                        }
                    }

                    string empQuery = "SELECT COUNT(*) FROM Employees WHERE LOWER(TRIM(Username)) = LOWER(TRIM(@Username)) AND Password = @Password";
                    using (SqlCommand empCmd = new SqlCommand(empQuery, con))
                    {
                        empCmd.Parameters.AddWithValue("@Username", username);
                        empCmd.Parameters.AddWithValue("@Password", password);

                        int empCount = Convert.ToInt32(empCmd.ExecuteScalar());

                        if (empCount > 0)
                        {
                            MessageBox.Show("Employee Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoggedInUser = username;

                            EmployeeDashBoard empDash = new EmployeeDashBoard();
                            empDash.Show();
                            this.Hide();
                            return;
                        }
                    }

                    string userQuery = "SELECT COUNT(*) FROM UserLogin WHERE LOWER(TRIM(Username)) = LOWER(TRIM(@Username)) AND Password = @Password";
                    using (SqlCommand userCmd = new SqlCommand(userQuery, con))
                    {
                        userCmd.Parameters.AddWithValue("@Username", username);
                        userCmd.Parameters.AddWithValue("@Password", password);

                        int userCount = Convert.ToInt32(userCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("User Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoggedInUser = username;

                            HomeForm dashboard = new HomeForm();
                            dashboard.WindowState = FormWindowState.Maximized;
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User does not exist or invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Cannot register with username 'admin'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string checkUserQuery = "SELECT COUNT(*) FROM UserLogin WHERE LOWER(TRIM(Username)) = LOWER(TRIM(@Username))";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, con))
                    {
                        checkUserCmd.Parameters.AddWithValue("@Username", username);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO UserLogin (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}

        