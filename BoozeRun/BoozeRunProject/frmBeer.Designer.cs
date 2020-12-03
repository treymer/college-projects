namespace BoozeRunProject
{
    partial class frmBeer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeer));
            this.lblBeer = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnAddShopCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtDomesticQty = new System.Windows.Forms.TextBox();
            this.lblDomestic = new System.Windows.Forms.Label();
            this.lblDomesticPrice = new System.Windows.Forms.Label();
            this.lblImportedPrice = new System.Windows.Forms.Label();
            this.lblImported = new System.Windows.Forms.Label();
            this.txtImportedQty = new System.Windows.Forms.TextBox();
            this.lblIpaPrice = new System.Windows.Forms.Label();
            this.lblIpa = new System.Windows.Forms.Label();
            this.txtIpaQty = new System.Windows.Forms.TextBox();
            this.cmbDomesticQty = new System.Windows.Forms.ComboBox();
            this.cmbImportedQty = new System.Windows.Forms.ComboBox();
            this.cmbIpaQty = new System.Windows.Forms.ComboBox();
            this.picDomestic = new System.Windows.Forms.PictureBox();
            this.rbtnDomesticPic = new System.Windows.Forms.RadioButton();
            this.rbtnImportedPic = new System.Windows.Forms.RadioButton();
            this.rbtnIpaPic = new System.Windows.Forms.RadioButton();
            this.picImported = new System.Windows.Forms.PictureBox();
            this.picIpa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDomestic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIpa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBeer
            // 
            this.lblBeer.AutoSize = true;
            this.lblBeer.BackColor = System.Drawing.SystemColors.Window;
            this.lblBeer.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeer.Location = new System.Drawing.Point(511, 52);
            this.lblBeer.Name = "lblBeer";
            this.lblBeer.Size = new System.Drawing.Size(186, 72);
            this.lblBeer.TabIndex = 0;
            this.lblBeer.Text = "Beer";
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.Window;
            this.btnShop.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(38, 27);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(127, 51);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnAddShopCart
            // 
            this.btnAddShopCart.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddShopCart.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShopCart.Location = new System.Drawing.Point(1067, 661);
            this.btnAddShopCart.Name = "btnAddShopCart";
            this.btnAddShopCart.Size = new System.Drawing.Size(127, 51);
            this.btnAddShopCart.TabIndex = 6;
            this.btnAddShopCart.Text = "Add to Cart";
            this.btnAddShopCart.UseVisualStyleBackColor = false;
            this.btnAddShopCart.Click += new System.EventHandler(this.btnAddShopCart_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1067, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 51);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtDomesticQty
            // 
            this.txtDomesticQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomesticQty.Location = new System.Drawing.Point(285, 263);
            this.txtDomesticQty.Name = "txtDomesticQty";
            this.txtDomesticQty.Size = new System.Drawing.Size(35, 37);
            this.txtDomesticQty.TabIndex = 8;
            this.txtDomesticQty.Text = "0";
            // 
            // lblDomestic
            // 
            this.lblDomestic.AutoSize = true;
            this.lblDomestic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDomestic.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomestic.Location = new System.Drawing.Point(157, 178);
            this.lblDomestic.Name = "lblDomestic";
            this.lblDomestic.Size = new System.Drawing.Size(150, 36);
            this.lblDomestic.TabIndex = 9;
            this.lblDomestic.Text = "Domestic";
            // 
            // lblDomesticPrice
            // 
            this.lblDomesticPrice.AutoSize = true;
            this.lblDomesticPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDomesticPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomesticPrice.Location = new System.Drawing.Point(272, 320);
            this.lblDomesticPrice.Name = "lblDomesticPrice";
            this.lblDomesticPrice.Size = new System.Drawing.Size(46, 30);
            this.lblDomesticPrice.TabIndex = 10;
            this.lblDomesticPrice.Text = "0.0";
            // 
            // lblImportedPrice
            // 
            this.lblImportedPrice.AutoSize = true;
            this.lblImportedPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImportedPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportedPrice.Location = new System.Drawing.Point(641, 322);
            this.lblImportedPrice.Name = "lblImportedPrice";
            this.lblImportedPrice.Size = new System.Drawing.Size(46, 30);
            this.lblImportedPrice.TabIndex = 13;
            this.lblImportedPrice.Text = "0.0";
            // 
            // lblImported
            // 
            this.lblImported.AutoSize = true;
            this.lblImported.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImported.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImported.Location = new System.Drawing.Point(517, 178);
            this.lblImported.Name = "lblImported";
            this.lblImported.Size = new System.Drawing.Size(148, 36);
            this.lblImported.TabIndex = 12;
            this.lblImported.Text = "Imported";
            // 
            // txtImportedQty
            // 
            this.txtImportedQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportedQty.Location = new System.Drawing.Point(654, 265);
            this.txtImportedQty.Name = "txtImportedQty";
            this.txtImportedQty.Size = new System.Drawing.Size(35, 37);
            this.txtImportedQty.TabIndex = 11;
            this.txtImportedQty.Text = "0";
            // 
            // lblIpaPrice
            // 
            this.lblIpaPrice.AutoSize = true;
            this.lblIpaPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIpaPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpaPrice.Location = new System.Drawing.Point(1026, 321);
            this.lblIpaPrice.Name = "lblIpaPrice";
            this.lblIpaPrice.Size = new System.Drawing.Size(46, 30);
            this.lblIpaPrice.TabIndex = 16;
            this.lblIpaPrice.Text = "0.0";
            // 
            // lblIpa
            // 
            this.lblIpa.AutoSize = true;
            this.lblIpa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIpa.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpa.Location = new System.Drawing.Point(935, 178);
            this.lblIpa.Name = "lblIpa";
            this.lblIpa.Size = new System.Drawing.Size(61, 36);
            this.lblIpa.TabIndex = 15;
            this.lblIpa.Text = "IPA";
            // 
            // txtIpaQty
            // 
            this.txtIpaQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpaQty.Location = new System.Drawing.Point(1039, 264);
            this.txtIpaQty.Name = "txtIpaQty";
            this.txtIpaQty.Size = new System.Drawing.Size(35, 37);
            this.txtIpaQty.TabIndex = 14;
            this.txtIpaQty.Text = "0";
            // 
            // cmbDomesticQty
            // 
            this.cmbDomesticQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDomesticQty.FormattingEnabled = true;
            this.cmbDomesticQty.Items.AddRange(new object[] {
            "6-pack",
            "12-pack",
            "30-case"});
            this.cmbDomesticQty.Location = new System.Drawing.Point(125, 263);
            this.cmbDomesticQty.Name = "cmbDomesticQty";
            this.cmbDomesticQty.Size = new System.Drawing.Size(121, 36);
            this.cmbDomesticQty.TabIndex = 26;
            this.cmbDomesticQty.Text = "6-pack";
            this.cmbDomesticQty.SelectedIndexChanged += new System.EventHandler(this.cmbDomesticQty_SelectedIndexChanged);
            // 
            // cmbImportedQty
            // 
            this.cmbImportedQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImportedQty.FormattingEnabled = true;
            this.cmbImportedQty.Items.AddRange(new object[] {
            "6-pack",
            "12-pack",
            "30-case"});
            this.cmbImportedQty.Location = new System.Drawing.Point(486, 265);
            this.cmbImportedQty.Name = "cmbImportedQty";
            this.cmbImportedQty.Size = new System.Drawing.Size(121, 36);
            this.cmbImportedQty.TabIndex = 27;
            this.cmbImportedQty.Text = "6-pack";
            this.cmbImportedQty.SelectedIndexChanged += new System.EventHandler(this.cmbImportedQty_SelectedIndexChanged);
            // 
            // cmbIpaQty
            // 
            this.cmbIpaQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIpaQty.FormattingEnabled = true;
            this.cmbIpaQty.Items.AddRange(new object[] {
            "6-pack",
            "12-pack",
            "30-case"});
            this.cmbIpaQty.Location = new System.Drawing.Point(875, 264);
            this.cmbIpaQty.Name = "cmbIpaQty";
            this.cmbIpaQty.Size = new System.Drawing.Size(121, 36);
            this.cmbIpaQty.TabIndex = 28;
            this.cmbIpaQty.Text = "6-pack";
            this.cmbIpaQty.SelectedIndexChanged += new System.EventHandler(this.cmbIpaQty_SelectedIndexChanged);
            // 
            // picDomestic
            // 
            this.picDomestic.Image = global::BoozeRunProject.Properties.Resources.domesticAll;
            this.picDomestic.Location = new System.Drawing.Point(541, 411);
            this.picDomestic.Name = "picDomestic";
            this.picDomestic.Size = new System.Drawing.Size(610, 202);
            this.picDomestic.TabIndex = 29;
            this.picDomestic.TabStop = false;
            this.picDomestic.Click += new System.EventHandler(this.picDomestic_Click);
            // 
            // rbtnDomesticPic
            // 
            this.rbtnDomesticPic.AutoSize = true;
            this.rbtnDomesticPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnDomesticPic.Checked = true;
            this.rbtnDomesticPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDomesticPic.Location = new System.Drawing.Point(635, 372);
            this.rbtnDomesticPic.Name = "rbtnDomesticPic";
            this.rbtnDomesticPic.Size = new System.Drawing.Size(87, 21);
            this.rbtnDomesticPic.TabIndex = 30;
            this.rbtnDomesticPic.TabStop = true;
            this.rbtnDomesticPic.Text = "Domestic";
            this.rbtnDomesticPic.UseVisualStyleBackColor = false;
            this.rbtnDomesticPic.CheckedChanged += new System.EventHandler(this.rbtnDomesticPic_CheckedChanged);
            // 
            // rbtnImportedPic
            // 
            this.rbtnImportedPic.AutoSize = true;
            this.rbtnImportedPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnImportedPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnImportedPic.Location = new System.Drawing.Point(801, 372);
            this.rbtnImportedPic.Name = "rbtnImportedPic";
            this.rbtnImportedPic.Size = new System.Drawing.Size(86, 21);
            this.rbtnImportedPic.TabIndex = 31;
            this.rbtnImportedPic.Text = "Imported";
            this.rbtnImportedPic.UseVisualStyleBackColor = false;
            this.rbtnImportedPic.CheckedChanged += new System.EventHandler(this.rbtnImportedPic_CheckedChanged);
            // 
            // rbtnIpaPic
            // 
            this.rbtnIpaPic.AutoSize = true;
            this.rbtnIpaPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnIpaPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIpaPic.Location = new System.Drawing.Point(950, 372);
            this.rbtnIpaPic.Name = "rbtnIpaPic";
            this.rbtnIpaPic.Size = new System.Drawing.Size(46, 21);
            this.rbtnIpaPic.TabIndex = 32;
            this.rbtnIpaPic.Text = "IPA";
            this.rbtnIpaPic.UseVisualStyleBackColor = false;
            this.rbtnIpaPic.CheckedChanged += new System.EventHandler(this.rbtnIpaPic_CheckedChanged);
            // 
            // picImported
            // 
            this.picImported.Image = global::BoozeRunProject.Properties.Resources.importedAll;
            this.picImported.Location = new System.Drawing.Point(523, 411);
            this.picImported.Name = "picImported";
            this.picImported.Size = new System.Drawing.Size(638, 202);
            this.picImported.TabIndex = 33;
            this.picImported.TabStop = false;
            this.picImported.Click += new System.EventHandler(this.picImported_Click);
            // 
            // picIpa
            // 
            this.picIpa.Image = global::BoozeRunProject.Properties.Resources.ipaAll;
            this.picIpa.Location = new System.Drawing.Point(523, 411);
            this.picIpa.Name = "picIpa";
            this.picIpa.Size = new System.Drawing.Size(658, 202);
            this.picIpa.TabIndex = 34;
            this.picIpa.TabStop = false;
            this.picIpa.Click += new System.EventHandler(this.picIpa_Click);
            // 
            // frmBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoozeRunProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1232, 733);
            this.Controls.Add(this.picIpa);
            this.Controls.Add(this.picImported);
            this.Controls.Add(this.rbtnIpaPic);
            this.Controls.Add(this.rbtnImportedPic);
            this.Controls.Add(this.rbtnDomesticPic);
            this.Controls.Add(this.picDomestic);
            this.Controls.Add(this.cmbIpaQty);
            this.Controls.Add(this.cmbImportedQty);
            this.Controls.Add(this.cmbDomesticQty);
            this.Controls.Add(this.lblIpaPrice);
            this.Controls.Add(this.lblIpa);
            this.Controls.Add(this.txtIpaQty);
            this.Controls.Add(this.lblImportedPrice);
            this.Controls.Add(this.lblImported);
            this.Controls.Add(this.txtImportedQty);
            this.Controls.Add(this.lblDomesticPrice);
            this.Controls.Add(this.lblDomestic);
            this.Controls.Add(this.txtDomesticQty);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAddShopCart);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblBeer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBeer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDomestic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeer;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnAddShopCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtDomesticQty;
        private System.Windows.Forms.Label lblDomestic;
        private System.Windows.Forms.Label lblDomesticPrice;
        private System.Windows.Forms.Label lblImportedPrice;
        private System.Windows.Forms.Label lblImported;
        private System.Windows.Forms.TextBox txtImportedQty;
        private System.Windows.Forms.Label lblIpaPrice;
        private System.Windows.Forms.Label lblIpa;
        private System.Windows.Forms.TextBox txtIpaQty;
        private System.Windows.Forms.ComboBox cmbDomesticQty;
        private System.Windows.Forms.ComboBox cmbImportedQty;
        private System.Windows.Forms.ComboBox cmbIpaQty;
        private System.Windows.Forms.PictureBox picDomestic;
        private System.Windows.Forms.RadioButton rbtnDomesticPic;
        private System.Windows.Forms.RadioButton rbtnImportedPic;
        private System.Windows.Forms.RadioButton rbtnIpaPic;
        private System.Windows.Forms.PictureBox picImported;
        private System.Windows.Forms.PictureBox picIpa;
    }
}