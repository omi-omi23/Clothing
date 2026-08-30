using System;
using System.Windows.Forms;

namespace Clothing
{
    // Abstraction: Main parent class
    public abstract class Payment
    {
        public abstract string GetMethodName();
    }

    // Polymorphism: Child classes
    public class Cash : Payment
    {
        public override string GetMethodName()
        {
            return "Cash";
        }
    }

    public class Card : Payment
    {
        public override string GetMethodName()
        {
            return "Card";
        }
    }

    public class Bkash : Payment
    {
        public override string GetMethodName()
        {
            return "bKash";
        }
    }

    // Main Form Code
    public partial class CheckoutForm : Form
    {
        private double totalAmount = 0;

        public CheckoutForm(double amount)
        {
            InitializeComponent();

            totalAmount = amount;
            label1.Text = "Total Amount: " + totalAmount.ToString("0.00") + " TK";

            orderConfirmedLabel.Visible = false;
            thankYouLabel.Visible = false;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            Payment payment = null;

            // Radio button check
            if (cashRadio.Checked == true)
            {
                payment = new Cash();
            }
            else if (cardRadio.Checked == true)
            {
                payment = new Card();
            }
            else if (bkashRadio.Checked == true)
            {
                payment = new Bkash();
            }
            else
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Getting method name using polymorphism
            string paymentMethod = payment.GetMethodName();

            orderConfirmedLabel.Visible = true;
            thankYouLabel.Visible = true;

            MessageBox.Show("Order Confirmed!\nTotal Amount: " + totalAmount.ToString("0.00") + " TK\nPayment Method: " + paymentMethod);

            //to clear list after placing a order
            MyCartForm.CartList.Clear();
            MyCartForm cartForm = (MyCartForm)Application.OpenForms["MyCartForm"];
            if (cartForm != null)
            {
                cartForm.Hide();  
            }

            HomeForm home = new HomeForm();
            home.Show();

            this.Close();
        }
    }
}