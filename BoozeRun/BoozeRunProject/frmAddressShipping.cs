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
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BoozeRunProject
{
    public partial class frmAddressShipping : Form
    {
        public static string bFrstName, bLstName;
        public static string bCity, bState;
        public static string bZip;
        public static string eMail;
        public static string phone;


        // to start the file stream for the billing and shipping addresses
        FileStream outFile = new FileStream("BILLING_SHIPPING_INFO.txt", FileMode.Create, FileAccess.Write);

        public frmAddressShipping()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // declare variables
            string sFrstName, sLstName;
            string bStrtAdrs, bStrtAdrs2;
            string sStrtAdrs, sStrtAdrs2;
            string sCity, sState;
            string bCountry, sCountry;
            string sZip;
            string cardType;
            string cardNo, expDate, expYr;
            bool check1 = false, check2 = false, check3 = false, check4 = false, check5 = false;
      
            // New writer
            StreamWriter writer = new StreamWriter(outFile);

            // input data
            sFrstName = txtFirstNameShip.Text;
            sLstName = txtLastNameShip.Text;
            bStrtAdrs = txtStreet.Text;
            bStrtAdrs2 = txtStreet2.Text;
            sStrtAdrs = txtStreetAddressShip.Text;
            sStrtAdrs2 = txtStreetAddress2Ship.Text;
            sCity = txtCityShip.Text;
            sState = cmbState2.Text;
            bCountry = txtCountry.Text;
            sCountry = txtCountry2.Text;
            sZip = txtZip2.Text;
            cardType = cmbCardType.Text;
            cardNo = txtCardNum.Text;
            expDate = cmbExpireMo.Text;
            expYr = cmbExpireYr.Text;

            // to check for invalid data
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtFirstNameShip.Text == "" ||
                txtLastNameShip.Text == "" || txtStreet.Text == "" || txtStreetAddressShip.Text == "" ||
                txtCity.Text == "" || cmbState.Text == "SELECT STATE" || cmbState.Text == "" ||
                txtCityShip.Text == "" || cmbState2.Text == "" || cmbState2.Text == "SELECT STATE" ||
                txtCountry.Text == "" || txtCountry2.Text == "" || txtZip.Text == "0" ||
                txtZip2.Text == "0" || mskPhone.Text.Length != 10 || txtZip.Text.Length != 5 ||
                txtZip2.Text.Length != 5 || txtEmail.Text.Length < 10)
                // to show an error when an important information is not entered
                // this excludes the 2nd address
                lblError.Text = "Please complete the information.";
            else
                check1 = true; // to flag the 1st checkpoint

            // flagging the other checkpoints for the credit card info
            if (cmbCardType.Text == "SELECT CARD TYPE" || cmbCardType.Text == "")
                cmbCardType.Focus();
            else
                check2 = true; // 2nd checkpoint for card type
            if (txtCardNum.Text == "0")
                txtCardNum.Focus();
            else
                check3 = true; // 3rd checkpoint for card number
            if (cmbExpireMo.Text == "0")
                cmbExpireMo.Focus();
            else
                check4 = true; // 4th checkpoint for month expires
            if (cmbExpireYr.Text == "0")
                cmbExpireYr.Focus();
            else
                check5 = true; // 5th checkpoint for year expires


            // after all checkpoints are flagged as true
            if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                // to reverse the values of the checkpoints
                check1 = false;
                check2 = false;
                check3 = false;
                check4 = false;
                check5 = false;

                // to write the data into a master file for customers
                // first info for billing address
                writer.WriteLine(bFrstName);
                writer.WriteLine(bLstName);
                writer.WriteLine(bStrtAdrs);
                writer.WriteLine(bStrtAdrs2);
                writer.WriteLine(bCity);
                writer.WriteLine(bState);
                writer.WriteLine(bZip);
                writer.WriteLine(bCountry);
                writer.WriteLine(eMail);
                writer.WriteLine(phone);
                // second info for shipping address
                writer.WriteLine(sFrstName);
                writer.WriteLine(sLstName);
                writer.WriteLine(sStrtAdrs);
                writer.WriteLine(sStrtAdrs2);
                writer.WriteLine(sCity);
                writer.WriteLine(sState);
                writer.WriteLine(sZip);
                writer.WriteLine(sCountry);

                // close writer
                writer.Close();
                outFile.Close();

                // to go to the next form
                frmCheckout CheckoutForm = new frmCheckout();
                CheckoutForm.Show();
                this.Hide();
            }

        }

        private void rdoShipToBill_CheckedChanged(object sender, EventArgs e)
        {
            // declare var
            string bFrstName, bLstName;
            string sFrstName, sLstName;
            string bStrtAdrs, bStrtAdrs2;
            string sStrtAdrs, sStrtAdrs2;
            string bCity, bState;
            string sCity, sState;
            string bCountry, sCountry;
            string bZip, sZip;

            // input data
            bFrstName = txtFirstName.Text;
            bLstName = txtLastName.Text;
            sFrstName = txtFirstNameShip.Text;
            sLstName = txtLastNameShip.Text;
            bStrtAdrs = txtStreet.Text;
            bStrtAdrs2 = txtStreet2.Text;
            sStrtAdrs = txtStreetAddressShip.Text;
            sStrtAdrs2 = txtStreetAddress2Ship.Text;
            bCity = txtCity.Text;
            bState = cmbState.Text;
            sCity = txtCityShip.Text;
            sState = cmbState2.Text;
            bCountry = txtCountry.Text;
            sCountry = txtCountry2.Text;
            bZip = txtZip.Text;
            sZip = txtZip2.Text;

            // change input data
            txtFirstNameShip.Text = bFrstName;
            txtLastNameShip.Text = bLstName;
            txtStreetAddressShip.Text = bStrtAdrs;
            txtStreetAddress2Ship.Text = bStrtAdrs2;
            txtCityShip.Text = bCity;
            cmbState2.Text = bState;
            txtCountry2.Text = bCountry;
            txtZip2.Text = bZip.ToString();
        }

        private void rdoCancel_CheckedChanged(object sender, EventArgs e)
        {
            // remove data
            txtFirstNameShip.Text = null;
            txtLastNameShip.Text = null;
            txtStreetAddressShip.Text = null;
            txtStreetAddress2Ship.Text = null;
            txtCityShip.Text = null;
            cmbState2.Text = "SELECT STATE";
            txtCountry2.Text = null;
            txtZip2.Text = "0";
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void frmAddressShipping_Load(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler Reymer\Desktop\BoozeRunProject_4_24_16\BoozeRunProject\bin\Debug\BoozeRunDB.mdf;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("SELECT [First Name] FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd2 = new SqlCommand("SELECT [Last Name] FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd3 = new SqlCommand("SELECT City FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd4 = new SqlCommand("SELECT State FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd5 = new SqlCommand("SELECT [Zip Code] FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd6 = new SqlCommand("SELECT Email FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);
            SqlCommand cmd7 = new SqlCommand("SELECT [Phone Number] FROM Customer WHERE Username ='" + frmHome.userName + "'", con1);

            con1.Open();

            bFrstName = Convert.ToString(cmd1.ExecuteScalar());
            bLstName = Convert.ToString(cmd2.ExecuteScalar());
            bCity = Convert.ToString(cmd3.ExecuteScalar());
            bState = Convert.ToString(cmd4.ExecuteScalar());
            bZip = Convert.ToString(cmd5.ExecuteScalar());
            eMail = Convert.ToString(cmd6.ExecuteScalar());
            phone = Convert.ToString(cmd7.ExecuteScalar());

            con1.Close();

            txtFirstName.Text = bFrstName;
            txtLastName.Text = bLstName;
            txtCity.Text = bCity;
            cmbState.Text = bState;
            txtZip.Text = bZip;
            txtEmail.Text = eMail;
            mskPhone.Text = phone;
        }
    }
}
