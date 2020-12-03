using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Created By: Tyler Reymer and Christine Curry
 * Created On: 11/10/2014
 * Project: PizzaPrices
 */
namespace PizzaPrices
{
    public partial class formPizzaria : Form
    {
        public formPizzaria()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Declare variables and arrays.
            const double TAX = 0.0775;

            double[] PRICE = { 6.99, 8.99, 12.50, 15.00 };
            string[] SIZE = { "Small", "Medium", "Large", "Extra Large" };

            double total = 0.0, tax, subTotal;
            int quantity, x = 0;
            bool flag = false;
            string size = " ";

            // Gather user's input for quantity.
            quantity = Convert.ToInt16(txtQuantity.Text);

            // If statements to control the of the pizza.
            if(rbtnSmall.Checked)            
                size = "Small";
            
            if(rbtnMedium.Checked)           
                size = "Medium";            

            if(rbtnLarge.Checked)            
                size = "Large";            

            if(rbtnXlarge.Checked)
                size = "Extra Large";

            // While loop to find the correct size of the pizza.
            while (x < SIZE.Length && size != SIZE[x])
                ++x;

            // If the counter does not exceed the size of the array, then flag it.
            if (x != SIZE.Length)
                flag = true;

            // If the size is found, calculate the subtotal, tax, and total for the order.
            if(flag)
            {
                lblOutput.Visible = true;
                lblError.Visible = false;
                subTotal = PRICE[x] * quantity;
                tax = (PRICE[x] * quantity) * TAX;
                total = PRICE[x] * quantity + tax;
                lblOutput.Text = String.Format("* SUBTOTAL * = {0}\n* TAX * = {1}\nYour total for {2} {3} pizza's is {4}.", subTotal.ToString("C2"), tax.ToString("C2"), quantity, size, total.ToString("C2"));
                txtQuantity.Text = null;
                rbtnSmall.Checked = false; rbtnMedium.Checked = false; rbtnLarge.Checked = false; rbtnXlarge.Checked = false;
            }
            // If the user forget to check a radio button, then display an error.
            else
            {
                lblOutput.Visible = true;
                lblOutput.Text = String.Format("Please choose a pizza size.");
                txtQuantity.Text = null;
                lblError.Visible = true;
                rbtnSmall.Checked = false; rbtnMedium.Checked = false; rbtnLarge.Checked = false; rbtnXlarge.Checked = false;
            }

        }

        private void formPizzaria_Load(object sender, EventArgs e)
        {

        }

    }
}
