using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozeRunProject
{
    public partial class frmBeer : Form
    {
        // 6-pack prices
        const double DOMESTIC_PRICE_SIX = 6.99;
        const double IMPORTED_PRICE_SIX = 8.99;
        const double IPA_PRICE_SIX = 9.99;

        //12-pack prices
        const double DOMESTIC_PRICE_TWELVE = 13.98;
        const double IMPORTED_PRICE_TWELVE = 17.98;
        const double IPA_PRICE_TWELVE = 19.98;

        //30-case prices
        const double DOMESTIC_PRICE_THIRTY = 34.95;
        const double IMPORTED_PRICE_THIRTY = 44.95;
        const double IPA_PRICE_THIRTY = 49.95;

        // to get the output (qty and price) to another form
        public static string domesticQty = "0";
        public static string importedQty = "0";
        public static string ipaQty = "0";

        public static string domesticPrice = "0.0";
        public static string importedPrice = "0.0";
        public static string ipaPrice = "0.0";

        public static string domesticSize = "";
        public static string importedSize = "";
        public static string ipaSize = "";

        public frmBeer()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            // send the output also even when shop is clicked
            // sends output after button click
            domesticQty = txtDomesticQty.Text;
            importedQty = txtImportedQty.Text;
            ipaQty = txtIpaQty.Text;

            domesticPrice = lblDomesticPrice.Text;
            importedPrice = lblImportedPrice.Text;
            ipaPrice = lblIpaPrice.Text;

            // to send only products with quantity
            if (txtDomesticQty.Text == "0")
                domesticPrice = "0.0";
            if (txtImportedQty.Text == "0")
                importedPrice = "0.0";
            if (txtIpaQty.Text == "0")
                ipaPrice = "0.0";

            // to delete text after getting the output
            txtDomesticQty.Text = "0";
            txtImportedQty.Text = "0";
            txtIpaQty.Text = "0";

            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnAddShopCart_Click(object sender, EventArgs e)
        {
            // sends output after button click
            domesticQty = txtDomesticQty.Text;
            importedQty = txtImportedQty.Text;
            ipaQty = txtIpaQty.Text;

            domesticPrice = lblDomesticPrice.Text;
            importedPrice = lblImportedPrice.Text;
            ipaPrice = lblIpaPrice.Text;

            // to send only products with quantity
            if (txtDomesticQty.Text == "0")
                domesticPrice = "0.0";
            if (txtImportedQty.Text == "0")
                importedPrice = "0.0";
            if (txtIpaQty.Text == "0")
                ipaPrice = "0.0";

            // to delete text after getting the output
            txtDomesticQty.Text = "0";
            txtImportedQty.Text = "0";
            txtIpaQty.Text = "0";

            domesticSize = cmbDomesticQty.Text;
            importedSize = cmbImportedQty.Text;
            ipaSize = cmbIpaQty.Text;

            frmShoppingCart ShoppingCartForm = new frmShoppingCart();
            ShoppingCartForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void frmBeer_Load(object sender, EventArgs e)
        {
            lblDomesticPrice.Text = Convert.ToString(DOMESTIC_PRICE_SIX);
            lblImportedPrice.Text = Convert.ToString(IMPORTED_PRICE_SIX);
            lblIpaPrice.Text = Convert.ToString(IPA_PRICE_SIX);

            picDomestic.Visible = true;
            picImported.Visible = false;
            picIpa.Visible = false;
        }

        private void cmbDomesticQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDomesticQty.Text == "6-pack")
                lblDomesticPrice.Text = Convert.ToString(DOMESTIC_PRICE_SIX);
            else if (cmbDomesticQty.Text == "12-pack")
                lblDomesticPrice.Text = Convert.ToString(DOMESTIC_PRICE_TWELVE);
            else if (cmbDomesticQty.Text == "30-case")
                lblDomesticPrice.Text = Convert.ToString(DOMESTIC_PRICE_THIRTY);
        }

        private void cmbImportedQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbImportedQty.Text == "6-pack")
                lblImportedPrice.Text = Convert.ToString(IMPORTED_PRICE_SIX);
            else if (cmbImportedQty.Text == "12-pack")
                lblImportedPrice.Text = Convert.ToString(IMPORTED_PRICE_TWELVE);
            else if (cmbImportedQty.Text == "30-case")
                lblImportedPrice.Text = Convert.ToString(IMPORTED_PRICE_THIRTY);
        }

        private void cmbIpaQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIpaQty.Text == "6-pack")
                lblIpaPrice.Text = Convert.ToString(IPA_PRICE_SIX);
            else if (cmbIpaQty.Text == "12-pack")
                lblIpaPrice.Text = Convert.ToString(IPA_PRICE_TWELVE);
            else if (cmbIpaQty.Text == "30-case")
                lblIpaPrice.Text = Convert.ToString(IPA_PRICE_THIRTY);
        }

        private void rbtnDomesticPic_CheckedChanged(object sender, EventArgs e)
        {
            picDomestic.Visible = true;

            picImported.Visible = false;
            picIpa.Visible = false;
        }

        private void rbtnImportedPic_CheckedChanged(object sender, EventArgs e)
        {
            picImported.Visible = true;

            picDomestic.Visible = false;
            picIpa.Visible = false;
        }

        private void rbtnIpaPic_CheckedChanged(object sender, EventArgs e)
        {
            picIpa.Visible = true;

            picImported.Visible = false;
            picDomestic.Visible = false;
        }

        private void picImported_Click(object sender, EventArgs e)
        {

        }

        private void picIpa_Click(object sender, EventArgs e)
        {

        }

        private void picDomestic_Click(object sender, EventArgs e)
        {

        }
    }
}
