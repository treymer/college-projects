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
using System.IO;

namespace BoozeRunProject
{
    public partial class frmHome : Form
    {
        public static string userName = "";
        public frmHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Hide this form, show create account form
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           
            string passWord;

            userName = txtUserName.Text;
            passWord = txtPassword.Text;

            lblError1.Visible = false;
            lblErrorStar1.Visible = false;
            lblErrorStar2.Visible = false;
            lblError1.Text = "";

            if (userName == "" || passWord == "")
            {
                lblError1.Visible = true;
                lblErrorStar1.Visible = true;
                lblErrorStar2.Visible = true;
                lblError1.Text = "Must enter a Username and Password";
                txtPassword.Text = null;
                txtUserName.Text = null;
            }
            else if (userName == "admin" && passWord == "admin")
            {
                frmAdmin adminForm = new frmAdmin();
                adminForm.Show();
                this.Hide();
            }
            else if(userName == "driver" && passWord == "driver")
            {
                frmDriver driverForm = new frmDriver();
                driverForm.Show();
                this.Hide();
            }
           
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler Reymer\Desktop\BoozeRunProject_4_24_16\BoozeRunProject\bin\Debug\BoozeRunDB.mdf;Integrated Security=True"); //ERROR HERE

                cn.Open();  

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Username ='" + txtUserName.Text + "' AND Password='" + txtPassword.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                int count = 0;

                while (dr.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Welcome " + userName + "!");
                    frmShop Shop = new frmShop();
                    Shop.Show();
                    this.Hide();

                }
                else if (count > 0)
                {
                    MessageBox.Show("Duplicate Username and Password");
                }
                else
                {
                    MessageBox.Show("Username or Password not correct");
                }

                cn.Close();

            }
 
            txtPassword.Clear();
            txtUserName.Clear();

        }

        private void btnTrackDriver_Click(object sender, EventArgs e)
        {
          
            string passWord;

            userName = txtUserName.Text;
            passWord = txtPassword.Text;

            lblError1.Visible = false;
            lblErrorStar1.Visible = false;
            lblErrorStar2.Visible = false;
            lblError1.Text = "";
            txtPassword.Text = null;
            txtUserName.Text = null;

            if (userName == "" || passWord == "")
            {
                lblError1.Visible = true;
                lblErrorStar1.Visible = true;
                lblErrorStar2.Visible = true;
                lblError1.Text = "Must enter a Username and Password";
                txtPassword.Text = null;
                txtUserName.Text = null;
            }
           else if (userName == "admin" || userName == "driver")
            {
                //Display error
                lblError1.Visible = true;
                lblError1.Text = "Must be a user to track your driver";
                lblErrorStar1.Visible = true;
                lblErrorStar2.Visible = true;     

                txtPassword.Text = null;
                txtUserName.Text = null;

            
            }
            else
            {
                frmTrackDriver trackDriverForm = new frmTrackDriver();
                trackDriverForm.Show();
                this.Hide();
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.Show();
        }
    }
}
