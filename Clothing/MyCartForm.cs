using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing
{
    public partial class MyCartForm : Form
    {
        public static List<CartItem> CartList = new List<CartItem>();
        double subTotal = 0;
        public MyCartForm()
        {
            InitializeComponent();
        }

        private void MyCartForm_Load(object sender, EventArgs e)
        {
            LoadCartData();
        }

        public void LoadCartData()
        {
            dgvCart.DataSource = null;
            dgvCart.Rows.Clear();
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("ProductName", "Product Name");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("TotalPrice", "Total");

            DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
            btnIncrease.Name = "btnIncrease";
            btnIncrease.HeaderText = "Add Item";
            btnIncrease.Text = "+";
            btnIncrease.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(btnIncrease);

            DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();
            btnDecrease.Name = "btnDecrease";
            btnDecrease.HeaderText = "Remove Item";
            btnDecrease.Text = "-";
            btnDecrease.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(btnDecrease);

            //double subTotal = 0;

            foreach (CartItem item in CartList)
            {
                dgvCart.Rows.Add(item.ProductName, item.Price, item.Quantity, item.GetTotal());
                subTotal = subTotal + item.GetTotal();
            }
            lblSubTotal.Text = "Sub Total: BDT " + subTotal;
            //lblSubTotal.Text = lblSubTotal.Text+"  " + subTotal;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CheckoutForm checkout = new CheckoutForm(subTotal);
            checkout.ShowDialog();
            //this.Hide();

            //DialogResult dialogResult = MessageBox.Show("Remove me when next page added!", "Ok", MessageBoxButtons.OK);
        }

        private void MyCartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string productName = dgvCart.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            CartItem selectedItem = null;

            foreach (CartItem item in CartList)
            {
                if (item.ProductName == productName)
                {
                    selectedItem = item;
                    break; 
                }
            }

            if (selectedItem != null)
            {
                if (dgvCart.Columns[e.ColumnIndex].Name == "btnIncrease")
                {
                    selectedItem.Quantity++;
                }
                else if (dgvCart.Columns[e.ColumnIndex].Name == "btnDecrease")
                {
                    selectedItem.Quantity--;

                    if (selectedItem.Quantity <= 0)
                    {
                        CartList.Remove(selectedItem);
                    }
                }
                LoadCartData();
            }
        }
    }
}
