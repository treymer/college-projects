using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BoozeRunProject
{
    public partial class frmCheckout : Form
    {
        public static double DELIVERY_RATE = 0.10;

        public static double grandTotal = 0.0;
        public static double tax = 0.0;
        public static double deliveryFee = 0.0;


        // Declare variables
        const double TAX = 0.0825;

        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {            

            // Hide this form, show address form
           
            frmPurchase purchaseForm = new frmPurchase();
            purchaseForm.Show();
            this.Hide();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            tax = frmShoppingCart.currentTotal * TAX;

            deliveryFee = frmShoppingCart.currentTotal * DELIVERY_RATE;

            grandTotal = tax + frmShoppingCart.currentTotal + deliveryFee;      

            lblSubTtlOutput.Text = String.Format("{0}", frmShoppingCart.currentTotal.ToString("C2"));
            lblTaxOutput.Text = String.Format("{0}", tax.ToString("C2"));
            lblDeliveryFee.Text = String.Format("{0}", deliveryFee.ToString("C2"));
            lblTtlOutput.Text = String.Format("{0}", grandTotal.ToString("C2"));

            // beer form quantity and price

            if (frmShoppingCart.domesticQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.domestic + " " + frmBeer.domesticSize + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.domesticQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmBeer.domesticPrice) + "\n";
            }
            if (frmShoppingCart.importedQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.imported + " " + frmBeer.importedSize + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.importedQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmBeer.importedPrice) + "\n";
            }
            if (frmShoppingCart.ipaQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.ipa + " " + frmBeer.ipaSize + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.ipaQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmBeer.ipaPrice) + "\n";
            }
            if (frmShoppingCart.merlotQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.merlot + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.merlotQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmWine.merlotPrice) + "\n";
            }
            if (frmShoppingCart.cabernetQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.cabernet + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.cabernetQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmWine.cabernetPrice) + "\n";
            }
            if (frmShoppingCart.chardonnayQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.chardonnay + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.chardonnayQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmWine.chardonnayPrice) + "\n";
            }
            if (frmShoppingCart.tequilaQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.tequila + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.tequilaQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmSpirits.tequilaPrice) + "\n";
            }
            if (frmShoppingCart.vodkaQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.vodka + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.vodkaQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmSpirits.vodkaPrice) + "\n";
            }
            if (frmShoppingCart.whiskeyQty > 0)
            {
                lblProdDescripOutput.Text += frmShoppingCart.whiskey + "\n";
                lblQtyOutput.Text += Convert.ToString(frmShoppingCart.whiskeyQty) + "\n";
                lblPriceOutput.Text += Convert.ToString(frmSpirits.whiskeyPrice) + "\n";
            }

        }
    }
}
