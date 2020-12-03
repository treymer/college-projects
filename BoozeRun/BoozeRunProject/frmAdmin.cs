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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            frmAddDeleteDriverAdmin addDeleteDriverForm = new frmAddDeleteDriverAdmin();
            addDeleteDriverForm.Show();
            this.Hide();
        }

        private void btnAddDeleteCust_Click(object sender, EventArgs e)
        {
            frmAddDeleteCustomer addDeleteCustomerForm = new frmAddDeleteCustomer();
            addDeleteCustomerForm.Show();
            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmSalesReportsAdmin salesReportForm = new frmSalesReportsAdmin();
            salesReportForm.Show();
            this.Hide();
        }
    }
}
