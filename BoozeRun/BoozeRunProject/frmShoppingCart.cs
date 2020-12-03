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
    public partial class frmShoppingCart : Form
    {
        public static double currentTotal = 0.0;

        public static int domesticQty = 0, importedQty = 0, ipaQty = 0,
            merlotQty = 0, cabernetQty = 0, chardonnayQty = 0,
            vodkaQty = 0, tequilaQty = 0, whiskeyQty = 0;

        public static string domestic, imported, ipa;
        public static string merlot, cabernet, chardonnay;
        public static string vodka, tequila, whiskey;

        private void btnRemoveIpa_Click(object sender, EventArgs e)
        {
            // remove ipa product in cart
            lblCartIpaPrice.Text = "0.0";
            lblCartIpaQty.Text = "0";

            frmBeer.ipaQty = "0";
            frmBeer.ipaPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveMerlot_Click(object sender, EventArgs e)
        {
            // remove merlot product in cart
            lblCartMerlotPrice.Text = "0.0";
            lblCartMerlotQty.Text = "0";

            frmWine.merlotQty = "0";
            frmWine.merlotPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveCabernet_Click(object sender, EventArgs e)
        {
            // remove cabernet product in cart
            lblCartCabernetPrice.Text = "0.0";
            lblCartCabernetQty.Text = "0";

            frmWine.cabernetQty = "0";
            frmWine.cabernetPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveChardonnay_Click(object sender, EventArgs e)
        {
            // remove chardonnay product in cart
            lblCartChardonnayPrice.Text = "0.0";
            lblCartChardonnayQty.Text = "0";

            frmWine.chardonnayQty = "0";
            frmWine.chardonnayPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveVodka_Click(object sender, EventArgs e)
        {
            // remove vodka product in cart
            lblCartVodkaPrice.Text = "0.0";
            lblCartVodkaQty.Text = "0";

            frmSpirits.vodkaQty = "0";
            frmSpirits.vodkaPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveTequila_Click(object sender, EventArgs e)
        {
            // remove tequila product in cart
            lblCartTequilaPrice.Text = "0.0";
            lblCartTequilaQty.Text = "0";

            frmSpirits.tequilaQty = "0";
            frmSpirits.tequilaPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveWhiskey_Click(object sender, EventArgs e)
        {
            // remove whiskey product in cart
            lblCartWhiskeyPrice.Text = "0.0";
            lblCartWhiskeyQty.Text = "0";

            frmSpirits.whiskeyQty = "0";
            frmSpirits.whiskeyPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveImported_Click(object sender, EventArgs e)
        {
            // remove imported product in cart
            lblCartImportedPrice.Text = "0.0";
            lblCartImportedQty.Text = "0";

            frmBeer.importedQty = "0";
            frmBeer.importedPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        private void btnRemoveDomestic_Click(object sender, EventArgs e)
        {
            // remove domestic product in cart
            lblCartDomesticPrice.Text = "0.0";
            lblCartDomesticQty.Text = "0";

            frmBeer.domesticQty = "0";
            frmBeer.domesticPrice = "0.0";

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }

        double domesticPrice = 0.0, importedPrice = 0.0, ipaPrice = 0.0,
               merlotPrice = 0.0, cabernetPrice = 0.0, chardonnayPrice = 0.0,
               vodkaPrice = 0.0, tequilaPrice = 0.0, whiskeyPrice = 0.0;
             

        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //start writing products here
            frmAddressShipping AddressForm = new frmAddressShipping();
            AddressForm.Show();
            this.Hide();            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {      
            domestic = lblCartDomestic.Text;
            imported = lblCartImported.Text;
            ipa = lblCartIpa.Text;

            merlot = lblCartMerlot.Text;
            cabernet = lblCartCabernet.Text;
            chardonnay = lblCartChardonnay.Text;

            vodka = lblCartVodka.Text;
            tequila = lblCartTequila.Text;
            whiskey = lblCartWhiskey.Text;

            // beer form quantity and price
            lblCartDomesticQty.Text = frmBeer.domesticQty;
            lblCartImportedQty.Text = frmBeer.importedQty;
            lblCartIpaQty.Text = frmBeer.ipaQty;

            lblCartDomesticPrice.Text = frmBeer.domesticPrice;
            lblCartImportedPrice.Text = frmBeer.importedPrice;
            lblCartIpaPrice.Text = frmBeer.ipaPrice;

            // wine form quantity and price
            lblCartMerlotQty.Text = frmWine.merlotQty;
            lblCartCabernetQty.Text = frmWine.cabernetQty;
            lblCartChardonnayQty.Text = frmWine.chardonnayQty;

            lblCartMerlotPrice.Text = frmWine.merlotPrice;
            lblCartCabernetPrice.Text = frmWine.cabernetPrice;
            lblCartChardonnayPrice.Text = frmWine.chardonnayPrice;

            // spirits form quantity and price
            lblCartVodkaQty.Text = frmSpirits.vodkaQty;
            lblCartTequilaQty.Text = frmSpirits.tequilaQty;
            lblCartWhiskeyQty.Text = frmSpirits.whiskeyQty;

            lblCartVodkaPrice.Text = frmSpirits.vodkaPrice;
            lblCartTequilaPrice.Text = frmSpirits.tequilaPrice;
            lblCartWhiskeyPrice.Text = frmSpirits.whiskeyPrice;

            // get variable values from labels
            // beers qty
            domesticQty = Convert.ToInt16(lblCartDomesticQty.Text);
            importedQty = Convert.ToInt16(lblCartImportedQty.Text);
            ipaQty = Convert.ToInt16(lblCartIpaQty.Text);
            // wines qty
            merlotQty = Convert.ToInt16(lblCartMerlotQty.Text);
            cabernetQty = Convert.ToInt16(lblCartCabernetQty.Text);
            chardonnayQty = Convert.ToInt16(lblCartChardonnayQty.Text);
            // spirits qty
            vodkaQty = Convert.ToInt16(lblCartVodkaQty.Text);
            tequilaQty = Convert.ToInt16(lblCartTequilaQty.Text);
            whiskeyQty = Convert.ToInt16(lblCartWhiskeyQty.Text);
            // beers price
            domesticPrice = Convert.ToDouble(lblCartDomesticPrice.Text);
            importedPrice = Convert.ToDouble(lblCartImportedPrice.Text);
            ipaPrice = Convert.ToDouble(lblCartIpaPrice.Text);
            // wines price
            merlotPrice = Convert.ToDouble(lblCartMerlotPrice.Text);
            cabernetPrice = Convert.ToDouble(lblCartCabernetPrice.Text);
            chardonnayPrice = Convert.ToDouble(lblCartChardonnayPrice.Text);
            // spirits price
            vodkaPrice = Convert.ToDouble(lblCartVodkaPrice.Text);
            tequilaPrice = Convert.ToDouble(lblCartTequilaPrice.Text);
            whiskeyPrice = Convert.ToDouble(lblCartWhiskeyPrice.Text);

            // get current total
            currentTotal = (domesticQty * domesticPrice) + (importedQty * importedPrice) + (ipaQty * ipaPrice) +
                           (merlotQty * merlotPrice) + (cabernetQty * cabernetPrice) + (chardonnayQty * chardonnayPrice) +
                           (vodkaQty * vodkaPrice) + (tequilaQty * tequilaPrice) + (whiskeyQty * whiskeyPrice);

            lblCartTotalPrice.Text = Convert.ToString(currentTotal);
        }
    }
}
