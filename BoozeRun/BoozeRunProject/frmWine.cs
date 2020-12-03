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
    public partial class frmWine : Form
    {
        const double MERLOT_PRICE = 9.99;
        const double CABERNET_PRICE = 9.99;
        const double CHARDONNAY_PRICE = 9.99;

        // to get the output (qty and price) to another form
        public static string merlotQty = "0";
        public static string cabernetQty = "0";
        public static string chardonnayQty = "0";

        public static string merlotPrice = "0.0";
        public static string cabernetPrice = "0.0";
        public static string chardonnayPrice = "0.0";

        public frmWine()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            // send the output also even when shop is clicked
            // sends output after button click
            merlotQty = txtMerlotQty.Text;
            cabernetQty = txtCabernetQty.Text;
            chardonnayQty = txtChardonnayQty.Text;

            merlotPrice = lblMerlotPrice.Text;
            cabernetPrice = lblCabernetPrice.Text;
            chardonnayPrice = lblChardonnayPrice.Text;

            // to send only products with quantity
            if (txtMerlotQty.Text == "0")
                merlotPrice = "0.0";
            if (txtCabernetQty.Text == "0")
                cabernetPrice = "0.0";
            if (txtChardonnayQty.Text == "0")
                chardonnayPrice = "0.0";

            // to delete text after getting the output
            txtMerlotQty.Text = "0";
            txtCabernetQty.Text = "0";
            txtChardonnayQty.Text = "0";

            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnAddShopCart_Click(object sender, EventArgs e)
        {
            // sends output after button click
            merlotQty = txtMerlotQty.Text;
            cabernetQty = txtCabernetQty.Text;
            chardonnayQty = txtChardonnayQty.Text;

            merlotPrice = lblMerlotPrice.Text;
            cabernetPrice = lblCabernetPrice.Text;
            chardonnayPrice = lblChardonnayPrice.Text;

            // to send only products with quantity
            if (txtMerlotQty.Text == "0")
                merlotPrice = "0.0";
            if (txtCabernetQty.Text == "0")
                cabernetPrice = "0.0";
            if (txtChardonnayQty.Text == "0")
                chardonnayPrice = "0.0";

            // to delete text after getting the output
            txtMerlotQty.Text = "0";
            txtCabernetQty.Text = "0";
            txtChardonnayQty.Text = "0";

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

        private void frmWine_Load(object sender, EventArgs e)
        {
            lblMerlotPrice.Text = Convert.ToString(MERLOT_PRICE);
            lblCabernetPrice.Text = Convert.ToString(CABERNET_PRICE);
            lblChardonnayPrice.Text = Convert.ToString(CHARDONNAY_PRICE);

            picCabernet.Visible = false;
            picMerlot.Visible = true;
            picChardonnay.Visible = false;
        }

        private void rbtnCabernetPic_CheckedChanged(object sender, EventArgs e)
        {
            picCabernet.Visible = true;

            picMerlot.Visible = false;
            picChardonnay.Visible = false;
        }

        private void rbtnMerlotPic_CheckedChanged(object sender, EventArgs e)
        {
            picMerlot.Visible = true;

            picCabernet.Visible = false;
            picChardonnay.Visible = false;
        }

        private void rbtnChardonnayPic_CheckedChanged(object sender, EventArgs e)
        {
            picChardonnay.Visible = true;

            picMerlot.Visible = false;
            picCabernet.Visible = false;
        }
    }
}
