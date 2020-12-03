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
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            frmBeer beerForm = new frmBeer();
            beerForm.Show();
            this.Hide();
        }

        private void btnSpirit_Click(object sender, EventArgs e)
        {
            frmSpirits spiritsForm = new frmSpirits();
            spiritsForm.Show();
            this.Hide();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            frmWine wineForm = new frmWine();
            wineForm.Show();
            this.Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            frmShoppingCart shoppingCartForm = new frmShoppingCart();
            shoppingCartForm.Show();
            this.Hide();
        }
    }
}
