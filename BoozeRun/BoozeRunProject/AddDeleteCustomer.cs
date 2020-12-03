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
    public partial class frmAddDeleteCustomer : Form
    {
        public frmAddDeleteCustomer()
        {
            InitializeComponent();
        }

        private void AddDeleteCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boozeRunDBCustomer.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.boozeRunDBCustomer.Customer);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin adminForm = new frmAdmin();
            adminForm.Show();
            this.Hide();
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boozeRunDBCustomer);

        }
    }
}
