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
    public partial class frmAddDeleteDriverAdmin : Form
    {
        public frmAddDeleteDriverAdmin()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boozeRunDBDataSet);

        }

        private void AddDeleteDriverAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boozeRunDBDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.boozeRunDBDataSet.Driver);

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
    }
}
