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
using System.Net;
using System.Net.Mail;

namespace BoozeRunProject
{
    public partial class frmPurchase : Form
    {
        // to declare variables
        string[] bFrstName;
        string[] bLstName;
        string[] sFrstName;
        string[] sLstName;
        string[] bStrtAdrs;
        string[] bStrtAdrs2;
        string[] sStrtAdrs;
        string[] sStrtAdrs2;
        string[] bCity;
        string[] bState;
        string[] sCity;
        string[] sState;
        string[] bCountry;
        string[] sCountry;
        string[] bZip;
        string[] sZip;
        string[] eMail;
        string[] phone;


        public frmPurchase()
        {
            InitializeComponent();
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

        private void btnTrackDriver_Click(object sender, EventArgs e)
        {
            frmTrackDriver trackDriverForm = new frmTrackDriver();
            trackDriverForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void btnContShopping_Click(object sender, EventArgs e)
        {
            frmShop shopForm = new frmShop();
            shopForm.Show();
            this.Hide();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            if (frmShoppingCart.domesticQty > 0)
            {
                lblProduct.Text += frmShoppingCart.domestic + " " + frmBeer.domesticSize + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.domesticQty) + "\n";
                lblCost.Text += Convert.ToString(frmBeer.domesticPrice) + "\n";
            }
            if (frmShoppingCart.importedQty > 0)
            {
                lblProduct.Text += frmShoppingCart.imported + " " + frmBeer.importedSize + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.importedQty) + "\n";
                lblCost.Text += Convert.ToString(frmBeer.importedPrice) + "\n";
            }
            if (frmShoppingCart.ipaQty > 0)
            {
                lblProduct.Text += frmShoppingCart.ipa + " " + frmBeer.ipaSize + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.ipaQty) + "\n";
                lblCost.Text += Convert.ToString(frmBeer.ipaPrice) + "\n";
            }
            if (frmShoppingCart.merlotQty > 0)
            {
                lblProduct.Text += frmShoppingCart.merlot + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.merlotQty) + "\n";
                lblCost.Text += Convert.ToString(frmWine.merlotPrice) + "\n";
            }
            if (frmShoppingCart.cabernetQty > 0)
            {
                lblProduct.Text += frmShoppingCart.cabernet + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.cabernetQty) + "\n";
                lblCost.Text += Convert.ToString(frmWine.cabernetPrice) + "\n";
            }
            if (frmShoppingCart.chardonnayQty > 0)
            {
                lblProduct.Text += frmShoppingCart.chardonnay + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.chardonnayQty) + "\n";
                lblCost.Text += Convert.ToString(frmWine.chardonnayPrice) + "\n";
            }
            if (frmShoppingCart.tequilaQty > 0)
            {
                lblProduct.Text += frmShoppingCart.tequila + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.tequilaQty) + "\n";
                lblCost.Text += Convert.ToString(frmSpirits.tequilaPrice) + "\n";
            }
            if (frmShoppingCart.vodkaQty > 0)
            {
                lblProduct.Text += frmShoppingCart.vodka + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.vodkaQty) + "\n";
                lblCost.Text += Convert.ToString(frmSpirits.vodkaPrice) + "\n";
            }
            if (frmShoppingCart.whiskeyQty > 0)
            {
                lblProduct.Text += frmShoppingCart.whiskey + "\n";
                lblTtlQty.Text += Convert.ToString(frmShoppingCart.whiskeyQty) + "\n";
                lblCost.Text += Convert.ToString(frmSpirits.whiskeyPrice) + "\n";
            }

            // to start the file stream and get length
            const string FILENAME = "BILLING_SHIPPING_INFO.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            // Find text file length and assign it to variable
            int txtFileLength = File.ReadLines(FILENAME).Count(); // used to get the entire length of the billing info text file

            // read data into arrays to use
            StreamReader reader = new StreamReader(inFile);
            int finalPos = 0;

            // getting the length of the array using the txt file
            int arrayLength = txtFileLength / 16;

            bFrstName = new string[arrayLength];
            bLstName = new string[arrayLength];
            sFrstName = new string[arrayLength];
            sLstName = new string[arrayLength];
            bStrtAdrs = new string[arrayLength];
            bStrtAdrs2 = new string[arrayLength];
            sStrtAdrs = new string[arrayLength];
            sStrtAdrs2 = new string[arrayLength];
            bCity = new string[arrayLength];
            bState = new string[arrayLength];
            sCity = new string[arrayLength];
            sState = new string[arrayLength];
            bCountry = new string[arrayLength];
            sCountry = new string[arrayLength];
            bZip = new string[arrayLength];
            sZip = new string[arrayLength];
            eMail = new string[arrayLength];
            phone = new string[arrayLength];

            // read data into arrays
            for (int x = 0; x < bFrstName.Length; ++x)
            {
                bFrstName[x] = reader.ReadLine();
                bLstName[x] = reader.ReadLine();
                bStrtAdrs[x] = reader.ReadLine();
                bStrtAdrs2[x] = reader.ReadLine();
                bCity[x] = reader.ReadLine();
                bState[x] = reader.ReadLine();
                bZip[x] = reader.ReadLine();
                bCountry[x] = reader.ReadLine();
                eMail[x] = reader.ReadLine();
                phone[x] = reader.ReadLine();

                sFrstName[x] = reader.ReadLine();
                sLstName[x] = reader.ReadLine();
                sStrtAdrs[x] = reader.ReadLine();
                sStrtAdrs2[x] = reader.ReadLine();
                sCity[x] = reader.ReadLine();
                sState[x] = reader.ReadLine();
                sZip[x] = reader.ReadLine();
                sCountry[x] = reader.ReadLine();

                finalPos = x;
            }

            // closing the reader and infile after reading the data
            reader.Close();
            inFile.Close();

            // to put the info from the txt file using the last customer
            lblThankyou.Text = String.Format("Thank you, {0}.", bFrstName[finalPos]);
            lblEmail.Text = String.Format("A confirmation email has been sent to {0}.", eMail[finalPos]);

            lblBillName.Text = "Name:   " + bFrstName[finalPos] + " " + bLstName[finalPos];
            lblBillStrt.Text = "Street:  " + bStrtAdrs[finalPos];
            lblBillCty.Text = "City:    " + bCity[finalPos];
            lblBillState.Text = "State:   " + bState[finalPos];
            lblBillZip.Text = "Zip:     " + bZip[finalPos];
            lblBillCntry.Text = "Country: " + bCountry[finalPos];

            lblShipName.Text += sFrstName[finalPos] + " " + sLstName[finalPos];
            lblShipStrt.Text += sStrtAdrs[finalPos];
            lblShipCty.Text += sCity[finalPos];
            lblShipState.Text += sState[finalPos];
            lblShipZip.Text += sZip[finalPos];
            lblShipCntry.Text += sCountry[finalPos];

            // Display totals

            lblSubTtlOutput.Text = String.Format("{0}", frmShoppingCart.currentTotal.ToString("C2"));
            lblTaxOutput.Text = String.Format("{0}", frmCheckout.tax.ToString("C2"));
            lblDeliveryFee.Text = String.Format("{0}", frmCheckout.deliveryFee.ToString("C2"));
            lblTtlOutput.Text = String.Format("{0}", frmCheckout.grandTotal.ToString("C2"));

            int orderNumber = 0;
            int NumberOfOrders = 0;

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler Reymer\Desktop\BoozeRunProject_4_24_16\BoozeRunProject\bin\Debug\BoozeRunDB.mdf;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) AS NumberOfOrders FROM Orders", con1);

            con1.Open();

            NumberOfOrders = Convert.ToInt32(cmd1.ExecuteScalar());

            orderNumber = 1000 + NumberOfOrders;

            SqlCommand cmd2 = new SqlCommand("INSERT INTO Orders ([Order Number], Username, Products, Complete, Subtotal, Tax, Total, Name, Street, City, State, Zip, DriverOnTheWay) VALUES ('" + orderNumber + "','" + frmHome.userName + "','" + lblProduct.Text + "','" + "No" + "','" + lblSubTtlOutput.Text + "','" + lblTaxOutput.Text + "','" + lblTtlOutput.Text + "','" + lblShipName.Text + "','" + lblShipStrt.Text + "','" + lblShipCty.Text + "','" + lblShipState.Text + "','" + lblShipZip.Text + "','" + "No" + "')", con1);

            cmd2.ExecuteNonQuery(); 

            lblThankyou.Text += " Your Order Number is " + orderNumber;

            SqlCommand cmd3 = new SqlCommand("INSERT INTO Sales (TransactionID, SubTotal, Tax, DeliveryFee, Total) VALUES ('" + orderNumber + "','" + frmShoppingCart.currentTotal + "','" + frmCheckout.tax + "','" + frmCheckout.deliveryFee + "','" + frmCheckout.grandTotal + "')", con1);

            cmd3.ExecuteNonQuery();
            con1.Close();

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("boozerunorders@gmail.com", "Letmein1$");
                MailMessage msg = new MailMessage();
                msg.To.Add(eMail[finalPos]);
                msg.From = new MailAddress("boozerunorders@gmail.com");
                msg.Subject = "Your Booze Run Order - " + orderNumber;
                msg.Body = "Thank you for your Booze Run purchase! Your order of " + lblProduct.Text + " will be delivered shortly.";
                msg.Body += "Your order number is " + orderNumber + ". Thank you for your purchase! :)";
                client.Send(msg);
                MessageBox.Show("Email Sent to " + eMail[finalPos]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
