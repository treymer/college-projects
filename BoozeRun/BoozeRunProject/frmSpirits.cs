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
    public partial class frmSpirits : Form
    {
        const double VODKA_PRICE = 15.99;
        const double TEQUILA_PRICE = 15.99;
        const double WHISKEY_PRICE = 19.99;

        // to get the output (qty and price) to another form
        public static string vodkaQty = "0";
        public static string tequilaQty = "0";
        public static string whiskeyQty = "0";

        public static string vodkaPrice = "0.0";
        public static string tequilaPrice = "0.0";
        public static string whiskeyPrice = "0.0";

        public frmSpirits()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            // send the output also even when shop is clicked
            // sends output after button click
            vodkaQty = txtVodkaQty.Text;
            tequilaQty = txtTequilaQty.Text;
            whiskeyQty = txtWhiskeyQty.Text;

            vodkaPrice = lblVodkaPrice.Text;
            tequilaPrice = lblTequilaPrice.Text;
            whiskeyPrice = lblWhiskeyPrice.Text;

            // to send only products with quantity
            if (txtVodkaQty.Text == "0")
                vodkaPrice = "0.0";
            if (txtTequilaQty.Text == "0")
                tequilaPrice = "0.0";
            if (txtWhiskeyQty.Text == "0")
                whiskeyPrice = "0.0";

            // to delete text after getting the output
            txtVodkaQty.Text = "0";
            txtTequilaQty.Text = "0";
            txtWhiskeyQty.Text = "0";

            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnAddShopCart_Click(object sender, EventArgs e)
        {
            // sends output after button click
            vodkaQty = txtVodkaQty.Text;
            tequilaQty = txtTequilaQty.Text;
            whiskeyQty = txtWhiskeyQty.Text;

            vodkaPrice = lblVodkaPrice.Text;
            tequilaPrice = lblTequilaPrice.Text;
            whiskeyPrice = lblWhiskeyPrice.Text;

            // to send only products with quantity
            if (txtVodkaQty.Text == "0")
                vodkaPrice = "0.0";
            if (txtTequilaQty.Text == "0")
                tequilaPrice = "0.0";
            if (txtWhiskeyQty.Text == "0")
                whiskeyPrice = "0.0";

            // to delete text after getting the output
            txtVodkaQty.Text = "0";
            txtTequilaQty.Text = "0";
            txtWhiskeyQty.Text = "0";

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

        private void frmSpirits_Load(object sender, EventArgs e)
        {
            lblVodkaPrice.Text = Convert.ToString(VODKA_PRICE);
            lblTequilaPrice.Text = Convert.ToString(TEQUILA_PRICE);
            lblWhiskeyPrice.Text = Convert.ToString(WHISKEY_PRICE);

            picVodka.Visible = true;
            picTequila.Visible = false;
            picWhiskey.Visible = false;
        }

        private void rbtnVodkaPic_CheckedChanged(object sender, EventArgs e)
        {
            picVodka.Visible = true;

            picTequila.Visible = false;
            picWhiskey.Visible = false;
        }

        private void rbtnTequilaPic_CheckedChanged(object sender, EventArgs e)
        {
            picTequila.Visible = true;

            picVodka.Visible = false;
            picWhiskey.Visible = false;
        }

        private void rbtnWhiskeyPic_CheckedChanged(object sender, EventArgs e)
        {
            picWhiskey.Visible = true;

            picTequila.Visible = false;
            picVodka.Visible = false;
        }
    }
}
