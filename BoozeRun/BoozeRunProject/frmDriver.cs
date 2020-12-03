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
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }


        private void frmDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boozeRunDBDataSetOrders.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.boozeRunDBDataSetOrders.Orders);
            
        }

        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boozeRunDBDataSetOrders);

        }
    }
}
