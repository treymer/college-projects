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
    public partial class frmRegister : Form
    {
        public static string firstName = "";
        public static string lastName = "";
        public static string dateOfBirth = "";
        public static int age;
        public static string userName = "";
        public static string passWord = "";
        public static string city = "";
        public static string state = "";
        public static string zipCode = "";
        public static string phoneNumber = "";
        public static string email = "";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            lblError1.Text = "";
            lblErrorAge.Visible = false;
            lblErrorAge.Text = "";

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            dateOfBirth = mskDOB.Text;
            age = Convert.ToInt16(txtAge.Text);
            userName = txtUserName.Text;
            passWord = txtPassword.Text;
            city = txtCity.Text;
            state = cmbState.Text;
            zipCode = txtZipCode.Text;
            phoneNumber = mskPhone.Text;
            email = txtEmail.Text;


            if(firstName == "" || lastName == "" || userName == "" || passWord == "" || city == "" || state == "" || zipCode == "" || phoneNumber == "" || email == "" || age == 1)
            {
                // Error
                lblError1.Visible = true;
                lblError1.Text = "Must complete all fields to register";
            }
            else if (age < 21)
            {
                //Error
                lblErrorAge.Visible = true;
                lblErrorAge.Text = "Must 21+ to register";
                txtFirstName.Text = null;
                txtLastName.Text = null;
                mskDOB.Text = null;
                txtAge.Text = null;
                txtUserName.Text = null;
                txtPassword.Text = null;
                txtCity.Text = null;
                cmbState.Text = null;
                txtZipCode.Text = null;
                mskPhone.Text = null;
                txtEmail.Text = null;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tyler Reymer\Desktop\BoozeRunProject_4_24_16\BoozeRunProject\bin\Debug\BoozeRunDB.mdf;Integrated Security=True");

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Username ='" + txtUserName.Text + "'", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                int count = 0;

                while (dr.Read())
                {
                    count += 1;
                }

                dr.Close();

                if (count == 0)
                {
                    MessageBox.Show("Registration Complete!");

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Customer (Username, [First Name], [Last Name], [Date of Birth], Age, Password, City, State, [Zip Code], [Phone Number], Email) VALUES ('" + txtUserName.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + mskDOB.Text + "','" + txtAge.Text + "','" + txtPassword.Text + "','" + txtCity.Text + "','" + cmbState.Text + "','" + txtZipCode.Text + "','" + mskPhone.Text + "','" + txtEmail.Text + "')", con);

                    cmd2.ExecuteNonQuery();
                    con.Close();

                    frmHome homeForm = new frmHome();
                    homeForm.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Duplicate username exists, please choose a new one.");

                    txtUserName.Text = null;
                    txtUserName.Focus();
                }                 
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome homeForm = new frmHome();
            homeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
