namespace BoozeRunProject
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.lblCheckout = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTtlOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblSubTtlOutput = new System.Windows.Forms.Label();
            this.lblTtl = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTtl = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPriceOutput = new System.Windows.Forms.Label();
            this.lblQtyOutput = new System.Windows.Forms.Label();
            this.lblProdDescripOutput = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProdDescription = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.BackColor = System.Drawing.SystemColors.Window;
            this.lblCheckout.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(446, 43);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(359, 72);
            this.lblCheckout.TabIndex = 0;
            this.lblCheckout.Text = "Checkout";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.SystemColors.Window;
            this.btnPurchase.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(585, 643);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(127, 51);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.Window;
            this.btnShop.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(36, 22);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(127, 51);
            this.btnShop.TabIndex = 8;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1040, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 51);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTtlOutput
            // 
            this.lblTtlOutput.AutoSize = true;
            this.lblTtlOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTtlOutput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlOutput.Location = new System.Drawing.Point(601, 603);
            this.lblTtlOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTtlOutput.Name = "lblTtlOutput";
            this.lblTtlOutput.Size = new System.Drawing.Size(28, 21);
            this.lblTtlOutput.TabIndex = 28;
            this.lblTtlOutput.Text = "***";
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.AutoSize = true;
            this.lblTaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxOutput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxOutput.Location = new System.Drawing.Point(601, 517);
            this.lblTaxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(28, 21);
            this.lblTaxOutput.TabIndex = 27;
            this.lblTaxOutput.Text = "***";
            // 
            // lblSubTtlOutput
            // 
            this.lblSubTtlOutput.AutoSize = true;
            this.lblSubTtlOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTtlOutput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTtlOutput.Location = new System.Drawing.Point(601, 476);
            this.lblSubTtlOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTtlOutput.Name = "lblSubTtlOutput";
            this.lblSubTtlOutput.Size = new System.Drawing.Size(28, 21);
            this.lblSubTtlOutput.TabIndex = 26;
            this.lblSubTtlOutput.Text = "***";
            // 
            // lblTtl
            // 
            this.lblTtl.AutoSize = true;
            this.lblTtl.BackColor = System.Drawing.Color.Transparent;
            this.lblTtl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtl.Location = new System.Drawing.Point(454, 603);
            this.lblTtl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTtl.Name = "lblTtl";
            this.lblTtl.Size = new System.Drawing.Size(59, 19);
            this.lblTtl.TabIndex = 25;
            this.lblTtl.Text = "TOTAL:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(454, 517);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(43, 19);
            this.lblTax.TabIndex = 24;
            this.lblTax.Text = "TAX:";
            // 
            // lblSubTtl
            // 
            this.lblSubTtl.AutoSize = true;
            this.lblSubTtl.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTtl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTtl.Location = new System.Drawing.Point(454, 476);
            this.lblSubTtl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTtl.Name = "lblSubTtl";
            this.lblSubTtl.Size = new System.Drawing.Size(86, 19);
            this.lblSubTtl.TabIndex = 23;
            this.lblSubTtl.Text = "SUBTOTAL:";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(385, 456);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(465, 20);
            this.lblLine.TabIndex = 22;
            this.lblLine.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // lblPriceOutput
            // 
            this.lblPriceOutput.AutoSize = true;
            this.lblPriceOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceOutput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOutput.Location = new System.Drawing.Point(767, 200);
            this.lblPriceOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceOutput.Name = "lblPriceOutput";
            this.lblPriceOutput.Size = new System.Drawing.Size(0, 20);
            this.lblPriceOutput.TabIndex = 21;
            // 
            // lblQtyOutput
            // 
            this.lblQtyOutput.AutoSize = true;
            this.lblQtyOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblQtyOutput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyOutput.Location = new System.Drawing.Point(616, 200);
            this.lblQtyOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtyOutput.Name = "lblQtyOutput";
            this.lblQtyOutput.Size = new System.Drawing.Size(0, 20);
            this.lblQtyOutput.TabIndex = 20;
            // 
            // lblProdDescripOutput
            // 
            this.lblProdDescripOutput.AutoSize = true;
            this.lblProdDescripOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblProdDescripOutput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescripOutput.Location = new System.Drawing.Point(392, 200);
            this.lblProdDescripOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdDescripOutput.Name = "lblProdDescripOutput";
            this.lblProdDescripOutput.Size = new System.Drawing.Size(0, 20);
            this.lblProdDescripOutput.TabIndex = 19;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(766, 153);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price:";
            // 
            // lblProdDescription
            // 
            this.lblProdDescription.AutoSize = true;
            this.lblProdDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblProdDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescription.Location = new System.Drawing.Point(388, 153);
            this.lblProdDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdDescription.Name = "lblProdDescription";
            this.lblProdDescription.Size = new System.Drawing.Size(194, 22);
            this.lblProdDescription.TabIndex = 17;
            this.lblProdDescription.Text = "Product Description:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(615, 153);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(97, 22);
            this.lblQty.TabIndex = 16;
            this.lblQty.Text = "Quantity:";
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFee.Location = new System.Drawing.Point(601, 560);
            this.lblDeliveryFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(28, 21);
            this.lblDeliveryFee.TabIndex = 30;
            this.lblDeliveryFee.Text = "***";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(454, 560);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(109, 19);
            this.lblDelivery.TabIndex = 29;
            this.lblDelivery.Text = "DELIVERY FEE:";
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoozeRunProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1235, 740);
            this.Controls.Add(this.lblDeliveryFee);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblTtlOutput);
            this.Controls.Add(this.lblTaxOutput);
            this.Controls.Add(this.lblSubTtlOutput);
            this.Controls.Add(this.lblTtl);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTtl);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblPriceOutput);
            this.Controls.Add(this.lblQtyOutput);
            this.Controls.Add(this.lblProdDescripOutput);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProdDescription);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblCheckout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTtlOutput;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblSubTtlOutput;
        private System.Windows.Forms.Label lblTtl;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTtl;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblPriceOutput;
        private System.Windows.Forms.Label lblQtyOutput;
        private System.Windows.Forms.Label lblProdDescripOutput;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProdDescription;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblDelivery;
    }
}