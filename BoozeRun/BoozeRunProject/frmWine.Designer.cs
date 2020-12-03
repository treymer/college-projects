namespace BoozeRunProject
{
    partial class frmWine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWine));
            this.lblWine = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnAddShopCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblChardonnayPrice = new System.Windows.Forms.Label();
            this.lblChardonnay = new System.Windows.Forms.Label();
            this.txtChardonnayQty = new System.Windows.Forms.TextBox();
            this.lblCabernetPrice = new System.Windows.Forms.Label();
            this.lblCabernet = new System.Windows.Forms.Label();
            this.txtCabernetQty = new System.Windows.Forms.TextBox();
            this.lblMerlotPrice = new System.Windows.Forms.Label();
            this.lblMerlot = new System.Windows.Forms.Label();
            this.txtMerlotQty = new System.Windows.Forms.TextBox();
            this.picChardonnay = new System.Windows.Forms.PictureBox();
            this.picMerlot = new System.Windows.Forms.PictureBox();
            this.rbtnChardonnayPic = new System.Windows.Forms.RadioButton();
            this.rbtnMerlotPic = new System.Windows.Forms.RadioButton();
            this.rbtnCabernetPic = new System.Windows.Forms.RadioButton();
            this.picCabernet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChardonnay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabernet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWine
            // 
            this.lblWine.AutoSize = true;
            this.lblWine.BackColor = System.Drawing.SystemColors.Window;
            this.lblWine.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWine.Location = new System.Drawing.Point(517, 58);
            this.lblWine.Name = "lblWine";
            this.lblWine.Size = new System.Drawing.Size(205, 72);
            this.lblWine.TabIndex = 0;
            this.lblWine.Text = "Wine";
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.Window;
            this.btnShop.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(39, 25);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(127, 51);
            this.btnShop.TabIndex = 4;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnAddShopCart
            // 
            this.btnAddShopCart.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddShopCart.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShopCart.Location = new System.Drawing.Point(1056, 660);
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
            this.btnHome.Location = new System.Drawing.Point(1056, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 51);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblChardonnayPrice
            // 
            this.lblChardonnayPrice.AutoSize = true;
            this.lblChardonnayPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChardonnayPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChardonnayPrice.Location = new System.Drawing.Point(950, 312);
            this.lblChardonnayPrice.Name = "lblChardonnayPrice";
            this.lblChardonnayPrice.Size = new System.Drawing.Size(46, 30);
            this.lblChardonnayPrice.TabIndex = 25;
            this.lblChardonnayPrice.Text = "0.0";
            // 
            // lblChardonnay
            // 
            this.lblChardonnay.AutoSize = true;
            this.lblChardonnay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChardonnay.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChardonnay.Location = new System.Drawing.Point(826, 191);
            this.lblChardonnay.Name = "lblChardonnay";
            this.lblChardonnay.Size = new System.Drawing.Size(305, 36);
            this.lblChardonnay.TabIndex = 24;
            this.lblChardonnay.Text = "White (Chardonnay)";
            // 
            // txtChardonnayQty
            // 
            this.txtChardonnayQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChardonnayQty.Location = new System.Drawing.Point(955, 255);
            this.txtChardonnayQty.Name = "txtChardonnayQty";
            this.txtChardonnayQty.Size = new System.Drawing.Size(35, 37);
            this.txtChardonnayQty.TabIndex = 23;
            this.txtChardonnayQty.Text = "0";
            // 
            // lblCabernetPrice
            // 
            this.lblCabernetPrice.AutoSize = true;
            this.lblCabernetPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCabernetPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabernetPrice.Location = new System.Drawing.Point(602, 312);
            this.lblCabernetPrice.Name = "lblCabernetPrice";
            this.lblCabernetPrice.Size = new System.Drawing.Size(46, 30);
            this.lblCabernetPrice.TabIndex = 22;
            this.lblCabernetPrice.Text = "0.0";
            // 
            // lblCabernet
            // 
            this.lblCabernet.AutoSize = true;
            this.lblCabernet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCabernet.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabernet.Location = new System.Drawing.Point(510, 191);
            this.lblCabernet.Name = "lblCabernet";
            this.lblCabernet.Size = new System.Drawing.Size(239, 36);
            this.lblCabernet.TabIndex = 21;
            this.lblCabernet.Text = "Red (Cabernet)";
            // 
            // txtCabernetQty
            // 
            this.txtCabernetQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabernetQty.Location = new System.Drawing.Point(607, 255);
            this.txtCabernetQty.Name = "txtCabernetQty";
            this.txtCabernetQty.Size = new System.Drawing.Size(35, 37);
            this.txtCabernetQty.TabIndex = 20;
            this.txtCabernetQty.Text = "0";
            // 
            // lblMerlotPrice
            // 
            this.lblMerlotPrice.AutoSize = true;
            this.lblMerlotPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMerlotPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerlotPrice.Location = new System.Drawing.Point(248, 312);
            this.lblMerlotPrice.Name = "lblMerlotPrice";
            this.lblMerlotPrice.Size = new System.Drawing.Size(46, 30);
            this.lblMerlotPrice.TabIndex = 19;
            this.lblMerlotPrice.Text = "0.0";
            // 
            // lblMerlot
            // 
            this.lblMerlot.AutoSize = true;
            this.lblMerlot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMerlot.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerlot.Location = new System.Drawing.Point(178, 191);
            this.lblMerlot.Name = "lblMerlot";
            this.lblMerlot.Size = new System.Drawing.Size(192, 36);
            this.lblMerlot.TabIndex = 18;
            this.lblMerlot.Text = "Red (Merlot)";
            // 
            // txtMerlotQty
            // 
            this.txtMerlotQty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerlotQty.Location = new System.Drawing.Point(253, 255);
            this.txtMerlotQty.Name = "txtMerlotQty";
            this.txtMerlotQty.Size = new System.Drawing.Size(35, 37);
            this.txtMerlotQty.TabIndex = 17;
            this.txtMerlotQty.Text = "0";
            // 
            // picChardonnay
            // 
            this.picChardonnay.Image = global::BoozeRunProject.Properties.Resources.chardonnayAll;
            this.picChardonnay.Location = new System.Drawing.Point(596, 429);
            this.picChardonnay.Name = "picChardonnay";
            this.picChardonnay.Size = new System.Drawing.Size(535, 212);
            this.picChardonnay.TabIndex = 40;
            this.picChardonnay.TabStop = false;
            // 
            // picMerlot
            // 
            this.picMerlot.Image = global::BoozeRunProject.Properties.Resources.merlotAll;
            this.picMerlot.Location = new System.Drawing.Point(579, 428);
            this.picMerlot.Name = "picMerlot";
            this.picMerlot.Size = new System.Drawing.Size(565, 213);
            this.picMerlot.TabIndex = 39;
            this.picMerlot.TabStop = false;
            // 
            // rbtnChardonnayPic
            // 
            this.rbtnChardonnayPic.AutoSize = true;
            this.rbtnChardonnayPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnChardonnayPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChardonnayPic.Location = new System.Drawing.Point(943, 376);
            this.rbtnChardonnayPic.Name = "rbtnChardonnayPic";
            this.rbtnChardonnayPic.Size = new System.Drawing.Size(153, 21);
            this.rbtnChardonnayPic.TabIndex = 38;
            this.rbtnChardonnayPic.Text = "White(Chardonnay)";
            this.rbtnChardonnayPic.UseVisualStyleBackColor = false;
            this.rbtnChardonnayPic.CheckedChanged += new System.EventHandler(this.rbtnChardonnayPic_CheckedChanged);
            // 
            // rbtnMerlotPic
            // 
            this.rbtnMerlotPic.AutoSize = true;
            this.rbtnMerlotPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnMerlotPic.Checked = true;
            this.rbtnMerlotPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMerlotPic.Location = new System.Drawing.Point(640, 376);
            this.rbtnMerlotPic.Name = "rbtnMerlotPic";
            this.rbtnMerlotPic.Size = new System.Drawing.Size(100, 21);
            this.rbtnMerlotPic.TabIndex = 37;
            this.rbtnMerlotPic.TabStop = true;
            this.rbtnMerlotPic.Text = "Red(Merlot)";
            this.rbtnMerlotPic.UseVisualStyleBackColor = false;
            this.rbtnMerlotPic.CheckedChanged += new System.EventHandler(this.rbtnMerlotPic_CheckedChanged);
            // 
            // rbtnCabernetPic
            // 
            this.rbtnCabernetPic.AutoSize = true;
            this.rbtnCabernetPic.BackColor = System.Drawing.SystemColors.Window;
            this.rbtnCabernetPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCabernetPic.Location = new System.Drawing.Point(782, 376);
            this.rbtnCabernetPic.Name = "rbtnCabernetPic";
            this.rbtnCabernetPic.Size = new System.Drawing.Size(122, 21);
            this.rbtnCabernetPic.TabIndex = 36;
            this.rbtnCabernetPic.Text = "Red(Cabernet)";
            this.rbtnCabernetPic.UseVisualStyleBackColor = false;
            this.rbtnCabernetPic.CheckedChanged += new System.EventHandler(this.rbtnCabernetPic_CheckedChanged);
            // 
            // picCabernet
            // 
            this.picCabernet.Image = global::BoozeRunProject.Properties.Resources.cabernetAll;
            this.picCabernet.Location = new System.Drawing.Point(579, 428);
            this.picCabernet.Name = "picCabernet";
            this.picCabernet.Size = new System.Drawing.Size(552, 211);
            this.picCabernet.TabIndex = 35;
            this.picCabernet.TabStop = false;
            // 
            // frmWine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoozeRunProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1237, 733);
            this.Controls.Add(this.picChardonnay);
            this.Controls.Add(this.picMerlot);
            this.Controls.Add(this.rbtnChardonnayPic);
            this.Controls.Add(this.rbtnMerlotPic);
            this.Controls.Add(this.rbtnCabernetPic);
            this.Controls.Add(this.picCabernet);
            this.Controls.Add(this.lblChardonnayPrice);
            this.Controls.Add(this.lblChardonnay);
            this.Controls.Add(this.txtChardonnayQty);
            this.Controls.Add(this.lblCabernetPrice);
            this.Controls.Add(this.lblCabernet);
            this.Controls.Add(this.txtCabernetQty);
            this.Controls.Add(this.lblMerlotPrice);
            this.Controls.Add(this.lblMerlot);
            this.Controls.Add(this.txtMerlotQty);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAddShopCart);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblWine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChardonnay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCabernet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWine;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnAddShopCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblChardonnayPrice;
        private System.Windows.Forms.Label lblChardonnay;
        private System.Windows.Forms.TextBox txtChardonnayQty;
        private System.Windows.Forms.Label lblCabernetPrice;
        private System.Windows.Forms.Label lblCabernet;
        private System.Windows.Forms.TextBox txtCabernetQty;
        private System.Windows.Forms.Label lblMerlotPrice;
        private System.Windows.Forms.Label lblMerlot;
        private System.Windows.Forms.TextBox txtMerlotQty;
        private System.Windows.Forms.PictureBox picChardonnay;
        private System.Windows.Forms.PictureBox picMerlot;
        private System.Windows.Forms.RadioButton rbtnChardonnayPic;
        private System.Windows.Forms.RadioButton rbtnMerlotPic;
        private System.Windows.Forms.RadioButton rbtnCabernetPic;
        private System.Windows.Forms.PictureBox picCabernet;
    }
}