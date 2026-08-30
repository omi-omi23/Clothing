using System;
using System.Windows.Forms;

namespace Clothing
{
    public partial class EmployeeDashBoard : Form
    {
        public EmployeeDashBoard()
        {
            InitializeComponent();
        }

        
        private void btnNewSale_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductStockForEmp stockForm = new ProductStockForEmp();
            stockForm.Show();
            this.Hide();
        }

        
        private void btnCart_Click(object sender, EventArgs e)
        {
            MyCartForm cart = new MyCartForm();
            cart.Show();
            this.Hide();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); 
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}