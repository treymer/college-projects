namespace BoozeRunProject
{
    partial class frmAddressShipping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddressShipping));
            this.lblError = new System.Windows.Forms.Label();
            this.rdoCancel = new System.Windows.Forms.RadioButton();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.cmbExpireYr = new System.Windows.Forms.ComboBox();
            this.cmbExpireMo = new System.Windows.Forms.ComboBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.lblExpire = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.picCreditCards = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtZip2 = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.cmbState2 = new System.Windows.Forms.ComboBox();
            this.txtCityShip = new System.Windows.Forms.TextBox();
            this.txtCountry2 = new System.Windows.Forms.TextBox();
            this.txtStreetAddress2Ship = new System.Windows.Forms.TextBox();
            this.txtStreetAddressShip = new System.Windows.Forms.TextBox();
            this.txtLastNameShip = new System.Windows.Forms.TextBox();
            this.txtFirstNameShip = new System.Windows.Forms.TextBox();
            this.lblState2 = new System.Windows.Forms.Label();
            this.lblCountry2 = new System.Windows.Forms.Label();
            this.lblZip2 = new System.Windows.Forms.Label();
            this.lblCity2 = new System.Windows.Forms.Label();
            this.lblStreetAddressShip = new System.Windows.Forms.Label();
            this.lblStreetAddress2Ship = new System.Windows.Forms.Label();
            this.lblNameShip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.rdoShipToBill = new System.Windows.Forms.RadioButton();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblStreetAddress2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCreditCards)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(262, 604);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 106;
            // 
            // rdoCancel
            // 
            this.rdoCancel.AutoSize = true;
            this.rdoCancel.BackColor = System.Drawing.Color.Transparent;
            this.rdoCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCancel.Location = new System.Drawing.Point(265, 565);
            this.rdoCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoCancel.Name = "rdoCancel";
            this.rdoCancel.Size = new System.Drawing.Size(216, 20);
            this.rdoCancel.TabIndex = 11;
            this.rdoCancel.TabStop = true;
            this.rdoCancel.Text = "Click to delete current Shipping info";
            this.rdoCancel.UseVisualStyleBackColor = false;
            this.rdoCancel.CheckedChanged += new System.EventHandler(this.rdoCancel_CheckedChanged);
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.Location = new System.Drawing.Point(392, 476);
            this.mskPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(96, 21);
            this.mskPhone.TabIndex = 9;
            this.mskPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbExpireYr
            // 
            this.cmbExpireYr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpireYr.FormattingEnabled = true;
            this.cmbExpireYr.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbExpireYr.Location = new System.Drawing.Point(849, 587);
            this.cmbExpireYr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExpireYr.Name = "cmbExpireYr";
            this.cmbExpireYr.Size = new System.Drawing.Size(79, 24);
            this.cmbExpireYr.TabIndex = 15;
            // 
            // cmbExpireMo
            // 
            this.cmbExpireMo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpireMo.FormattingEnabled = true;
            this.cmbExpireMo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbExpireMo.Location = new System.Drawing.Point(786, 587);
            this.cmbExpireMo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExpireMo.Name = "cmbExpireMo";
            this.cmbExpireMo.Size = new System.Drawing.Size(52, 24);
            this.cmbExpireMo.TabIndex = 14;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.Location = new System.Drawing.Point(786, 548);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(210, 21);
            this.txtCardNum.TabIndex = 13;
            // 
            // cmbCardType
            // 
            this.cmbCardType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this.cmbCardType.Location = new System.Drawing.Point(786, 505);
            this.cmbCardType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(210, 24);
            this.cmbCardType.TabIndex = 12;
            this.cmbCardType.Text = "SELECT CARD TYPE";
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.BackColor = System.Drawing.Color.Transparent;
            this.lblExpire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.Location = new System.Drawing.Point(644, 587);
            this.lblExpire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(102, 17);
            this.lblExpire.TabIndex = 105;
            this.lblExpire.Text = "Expiration Date:";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.Location = new System.Drawing.Point(644, 548);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(90, 17);
            this.lblCardNum.TabIndex = 104;
            this.lblCardNum.Text = "Card Number:";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.BackColor = System.Drawing.Color.Transparent;
            this.lblCardType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(644, 510);
            this.lblCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(110, 17);
            this.lblCardType.TabIndex = 103;
            this.lblCardType.Text = "Credit Card Type:";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditCard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.Location = new System.Drawing.Point(644, 465);
            this.lblCreditCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(80, 17);
            this.lblCreditCard.TabIndex = 102;
            this.lblCreditCard.Text = "Credit Card:";
            // 
            // picCreditCards
            // 
            this.picCreditCards.Image = ((System.Drawing.Image)(resources.GetObject("picCreditCards.Image")));
            this.picCreditCards.Location = new System.Drawing.Point(786, 448);
            this.picCreditCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCreditCards.Name = "picCreditCards";
            this.picCreditCards.Size = new System.Drawing.Size(194, 48);
            this.picCreditCards.TabIndex = 101;
            this.picCreditCards.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(695, 421);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(259, 20);
            this.lblLine.TabIndex = 100;
            this.lblLine.Text = "--------------------------------------------------";
            // 
            // txtZip2
            // 
            this.txtZip2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip2.Location = new System.Drawing.Point(805, 337);
            this.txtZip2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZip2.MaxLength = 5;
            this.txtZip2.Name = "txtZip2";
            this.txtZip2.Size = new System.Drawing.Size(96, 21);
            this.txtZip2.TabIndex = 22;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingAddress.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingAddress.Location = new System.Drawing.Point(740, 49);
            this.lblShippingAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(256, 36);
            this.lblShippingAddress.TabIndex = 99;
            this.lblShippingAddress.Text = "Shipping Address";
            // 
            // cmbState2
            // 
            this.cmbState2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState2.FormattingEnabled = true;
            this.cmbState2.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmbState2.Location = new System.Drawing.Point(805, 295);
            this.cmbState2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbState2.Name = "cmbState2";
            this.cmbState2.Size = new System.Drawing.Size(142, 24);
            this.cmbState2.TabIndex = 21;
            this.cmbState2.Text = "SELECT STATE";
            // 
            // txtCityShip
            // 
            this.txtCityShip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityShip.Location = new System.Drawing.Point(805, 251);
            this.txtCityShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCityShip.MaxLength = 20;
            this.txtCityShip.Name = "txtCityShip";
            this.txtCityShip.Size = new System.Drawing.Size(123, 21);
            this.txtCityShip.TabIndex = 20;
            // 
            // txtCountry2
            // 
            this.txtCountry2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry2.Location = new System.Drawing.Point(805, 384);
            this.txtCountry2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountry2.Name = "txtCountry2";
            this.txtCountry2.Size = new System.Drawing.Size(123, 21);
            this.txtCountry2.TabIndex = 23;
            // 
            // txtStreetAddress2Ship
            // 
            this.txtStreetAddress2Ship.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress2Ship.Location = new System.Drawing.Point(805, 212);
            this.txtStreetAddress2Ship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreetAddress2Ship.Name = "txtStreetAddress2Ship";
            this.txtStreetAddress2Ship.Size = new System.Drawing.Size(210, 21);
            this.txtStreetAddress2Ship.TabIndex = 19;
            // 
            // txtStreetAddressShip
            // 
            this.txtStreetAddressShip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddressShip.Location = new System.Drawing.Point(805, 171);
            this.txtStreetAddressShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreetAddressShip.Name = "txtStreetAddressShip";
            this.txtStreetAddressShip.Size = new System.Drawing.Size(210, 21);
            this.txtStreetAddressShip.TabIndex = 18;
            // 
            // txtLastNameShip
            // 
            this.txtLastNameShip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameShip.Location = new System.Drawing.Point(913, 129);
            this.txtLastNameShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastNameShip.Name = "txtLastNameShip";
            this.txtLastNameShip.Size = new System.Drawing.Size(102, 21);
            this.txtLastNameShip.TabIndex = 17;
            // 
            // txtFirstNameShip
            // 
            this.txtFirstNameShip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameShip.Location = new System.Drawing.Point(805, 129);
            this.txtFirstNameShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstNameShip.Name = "txtFirstNameShip";
            this.txtFirstNameShip.Size = new System.Drawing.Size(104, 21);
            this.txtFirstNameShip.TabIndex = 16;
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.BackColor = System.Drawing.Color.Transparent;
            this.lblState2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState2.Location = new System.Drawing.Point(665, 300);
            this.lblState2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(44, 17);
            this.lblState2.TabIndex = 98;
            this.lblState2.Text = "State:";
            // 
            // lblCountry2
            // 
            this.lblCountry2.AutoSize = true;
            this.lblCountry2.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry2.Location = new System.Drawing.Point(665, 384);
            this.lblCountry2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry2.Name = "lblCountry2";
            this.lblCountry2.Size = new System.Drawing.Size(57, 17);
            this.lblCountry2.TabIndex = 97;
            this.lblCountry2.Text = "Country:";
            // 
            // lblZip2
            // 
            this.lblZip2.AutoSize = true;
            this.lblZip2.BackColor = System.Drawing.Color.Transparent;
            this.lblZip2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip2.Location = new System.Drawing.Point(665, 340);
            this.lblZip2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip2.Name = "lblZip2";
            this.lblZip2.Size = new System.Drawing.Size(28, 17);
            this.lblZip2.TabIndex = 96;
            this.lblZip2.Text = "Zip:";
            // 
            // lblCity2
            // 
            this.lblCity2.AutoSize = true;
            this.lblCity2.BackColor = System.Drawing.Color.Transparent;
            this.lblCity2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity2.Location = new System.Drawing.Point(665, 254);
            this.lblCity2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity2.Name = "lblCity2";
            this.lblCity2.Size = new System.Drawing.Size(34, 17);
            this.lblCity2.TabIndex = 95;
            this.lblCity2.Text = "City:";
            // 
            // lblStreetAddressShip
            // 
            this.lblStreetAddressShip.AutoSize = true;
            this.lblStreetAddressShip.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddressShip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddressShip.Location = new System.Drawing.Point(665, 174);
            this.lblStreetAddressShip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddressShip.Name = "lblStreetAddressShip";
            this.lblStreetAddressShip.Size = new System.Drawing.Size(98, 17);
            this.lblStreetAddressShip.TabIndex = 93;
            this.lblStreetAddressShip.Text = "Street Address:";
            // 
            // lblStreetAddress2Ship
            // 
            this.lblStreetAddress2Ship.AutoSize = true;
            this.lblStreetAddress2Ship.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddress2Ship.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress2Ship.Location = new System.Drawing.Point(665, 215);
            this.lblStreetAddress2Ship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress2Ship.Name = "lblStreetAddress2Ship";
            this.lblStreetAddress2Ship.Size = new System.Drawing.Size(108, 17);
            this.lblStreetAddress2Ship.TabIndex = 91;
            this.lblStreetAddress2Ship.Text = "Street Address 2:";
            // 
            // lblNameShip
            // 
            this.lblNameShip.AutoSize = true;
            this.lblNameShip.BackColor = System.Drawing.Color.Transparent;
            this.lblNameShip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameShip.Location = new System.Drawing.Point(665, 131);
            this.lblNameShip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameShip.Name = "lblNameShip";
            this.lblNameShip.Size = new System.Drawing.Size(102, 17);
            this.lblNameShip.TabIndex = 89;
            this.lblNameShip.Text = "First/Last Name:";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(392, 339);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(96, 21);
            this.txtZip.TabIndex = 6;
            // 
            // rdoShipToBill
            // 
            this.rdoShipToBill.AutoSize = true;
            this.rdoShipToBill.BackColor = System.Drawing.Color.Transparent;
            this.rdoShipToBill.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoShipToBill.Location = new System.Drawing.Point(265, 527);
            this.rdoShipToBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoShipToBill.Name = "rdoShipToBill";
            this.rdoShipToBill.Size = new System.Drawing.Size(128, 20);
            this.rdoShipToBill.TabIndex = 10;
            this.rdoShipToBill.TabStop = true;
            this.rdoShipToBill.Text = "Ship to this address";
            this.rdoShipToBill.UseVisualStyleBackColor = false;
            this.rdoShipToBill.CheckedChanged += new System.EventHandler(this.rdoShipToBill_CheckedChanged);
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingAddress.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingAddress.Location = new System.Drawing.Point(334, 49);
            this.lblBillingAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(217, 36);
            this.lblBillingAddress.TabIndex = 86;
            this.lblBillingAddress.Text = "Billing Address";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmbState.Location = new System.Drawing.Point(392, 297);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(137, 24);
            this.cmbState.TabIndex = 5;
            this.cmbState.Text = "SELECT STATE";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(392, 252);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(123, 21);
            this.txtCity.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(392, 431);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(392, 385);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(123, 21);
            this.txtCountry.TabIndex = 7;
            this.txtCountry.Text = "USA";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet2.Location = new System.Drawing.Point(392, 214);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(210, 21);
            this.txtStreet2.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(392, 172);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(210, 21);
            this.txtStreet.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(500, 131);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(102, 21);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(392, 131);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(104, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(262, 303);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 17);
            this.lblState.TabIndex = 74;
            this.lblState.Text = "State:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(262, 479);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 17);
            this.lblPhone.TabIndex = 71;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(262, 433);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Email:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(262, 387);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 67;
            this.lblCountry.Text = "Country:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(262, 342);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(28, 17);
            this.lblZip.TabIndex = 65;
            this.lblZip.Text = "Zip:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(262, 256);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 17);
            this.lblCity.TabIndex = 64;
            this.lblCity.Text = "City:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(262, 176);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(98, 17);
            this.lblStreetAddress.TabIndex = 61;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblStreetAddress2
            // 
            this.lblStreetAddress2.AutoSize = true;
            this.lblStreetAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddress2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress2.Location = new System.Drawing.Point(262, 218);
            this.lblStreetAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress2.Name = "lblStreetAddress2";
            this.lblStreetAddress2.Size = new System.Drawing.Size(108, 17);
            this.lblStreetAddress2.TabIndex = 59;
            this.lblStreetAddress2.Text = "Street Address 2:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(262, 133);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 17);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "First/Last Name:";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.Window;
            this.btnCheckout.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(588, 660);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 63);
            this.btnCheckout.TabIndex = 24;
            this.btnCheckout.Text = "Confirm Order";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1132, 22);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(148, 63);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.Window;
            this.btnShop.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(14, 26);
            this.btnShop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(148, 63);
            this.btnShop.TabIndex = 26;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // frmAddressShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1304, 746);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rdoCancel);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.cmbExpireYr);
            this.Controls.Add(this.cmbExpireMo);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.lblExpire);
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.picCreditCards);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txtZip2);
            this.Controls.Add(this.lblShippingAddress);
            this.Controls.Add(this.cmbState2);
            this.Controls.Add(this.txtCityShip);
            this.Controls.Add(this.txtCountry2);
            this.Controls.Add(this.txtStreetAddress2Ship);
            this.Controls.Add(this.txtStreetAddressShip);
            this.Controls.Add(this.txtLastNameShip);
            this.Controls.Add(this.txtFirstNameShip);
            this.Controls.Add(this.lblState2);
            this.Controls.Add(this.lblCountry2);
            this.Controls.Add(this.lblZip2);
            this.Controls.Add(this.lblCity2);
            this.Controls.Add(this.lblStreetAddressShip);
            this.Controls.Add(this.lblStreetAddress2Ship);
            this.Controls.Add(this.lblNameShip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.rdoShipToBill);
            this.Controls.Add(this.lblBillingAddress);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblStreetAddress2);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddressShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddressShipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCreditCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RadioButton rdoCancel;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.ComboBox cmbExpireYr;
        private System.Windows.Forms.ComboBox cmbExpireMo;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.PictureBox picCreditCards;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtZip2;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.ComboBox cmbState2;
        private System.Windows.Forms.TextBox txtCityShip;
        private System.Windows.Forms.TextBox txtCountry2;
        private System.Windows.Forms.TextBox txtStreetAddress2Ship;
        private System.Windows.Forms.TextBox txtStreetAddressShip;
        private System.Windows.Forms.TextBox txtLastNameShip;
        private System.Windows.Forms.TextBox txtFirstNameShip;
        private System.Windows.Forms.Label lblState2;
        private System.Windows.Forms.Label lblCountry2;
        private System.Windows.Forms.Label lblZip2;
        private System.Windows.Forms.Label lblCity2;
        private System.Windows.Forms.Label lblStreetAddressShip;
        private System.Windows.Forms.Label lblStreetAddress2Ship;
        private System.Windows.Forms.Label lblNameShip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.RadioButton rdoShipToBill;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShop;
    }
}