using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace BoozeRunProject
{
    public partial class frmTrackDriver : Form
    {
        public frmTrackDriver()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void frmTrackDriver_Load(object sender, EventArgs e)
        {
            txtOrderNumber.Focus();
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            string orderNumber = "";
            string orderComplete = "";
            string driverStatus = "";

            orderNumber = txtOrderNumber.Text;

            if(orderNumber == "")
            {
                MessageBox.Show("Please enter an order number.");
            }

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler Reymer\Desktop\BoozeRunProject_4_24_16\BoozeRunProject\bin\Debug\BoozeRunDB.mdf;Integrated Security=True"); 

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Complete FROM Orders WHERE Username='" + frmHome.userName + "' AND [Order Number]='" + orderNumber + "'", cn);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            dr.Close();

            if (count == 1)
            {
                MessageBox.Show("Found " + orderNumber + "!");
                orderComplete = Convert.ToString(cmd.ExecuteScalar());

                if (orderComplete == "Yes" || orderComplete == "yes")
                {
                    lblOrderStatus.Text += frmHome.userName;
                    lblOrderStatus.Text += ", your order is Completed \nand has been delivered!";
                }
                else
                {
                    lblOrderStatus.Text += frmHome.userName;
                    lblOrderStatus.Text += ", your order is still processing.\n";
                }

                SqlCommand cmd2 = new SqlCommand("SELECT DriverOnTheWay FROM Orders WHERE Username = '" + frmHome.userName + "' AND[Order Number] = '" + orderNumber + "'", cn);

                driverStatus = Convert.ToString(cmd2.ExecuteScalar());

                if ((driverStatus == "Yes" || driverStatus == "yes") && (orderComplete != "Yes" || orderComplete != "Yes"))
                {
                    lblOrderStatus.Text += "Your driver is on the way! \nExpect delivery within 30 minutes!";
                }
                else if ((driverStatus == "No" || driverStatus == "no") && (orderComplete != "No" || orderComplete != "no"))
                {
                    lblOrderStatus.Text += "We are gathering your order. \nYour driver will be on their way shortly.";
                }
            }
            else if (count > 0)
            {
                MessageBox.Show("Duplicate Order Numbers!");
            }
            else
            {
                MessageBox.Show("Invalid Order Number!");

                txtOrderNumber.Text = null;
            }

            cn.Close();

        }
    }
}
