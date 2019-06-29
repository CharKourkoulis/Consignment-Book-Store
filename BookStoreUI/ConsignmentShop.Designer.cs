namespace BookStoreUI
{
    partial class ConsignmentShop
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
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartListboxLabal = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.vendroListboxLabel = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.BackColor = System.Drawing.Color.Purple;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.itemsListboxLabel.Location = new System.Drawing.Point(54, 126);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(82, 33);
            this.itemsListboxLabel.TabIndex = 0;
            this.itemsListboxLabel.Text = "BOOKS";
            // 
            // itemsListbox
            // 
            this.itemsListbox.BackColor = System.Drawing.Color.Purple;
            this.itemsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsListbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 29;
            this.itemsListbox.Location = new System.Drawing.Point(50, 156);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(353, 205);
            this.itemsListbox.TabIndex = 1;
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Chiller", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(249, 377);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(154, 58);
            this.addToCart.TabIndex = 2;
            this.addToCart.Text = "ADD TO CART";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.BackColor = System.Drawing.Color.Purple;
            this.shoppingCartListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shoppingCartListbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shoppingCartListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 29;
            this.shoppingCartListbox.Location = new System.Drawing.Point(581, 322);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(353, 147);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // shoppingCartListboxLabal
            // 
            this.shoppingCartListboxLabal.AutoSize = true;
            this.shoppingCartListboxLabal.BackColor = System.Drawing.Color.Purple;
            this.shoppingCartListboxLabal.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.shoppingCartListboxLabal.Location = new System.Drawing.Point(584, 296);
            this.shoppingCartListboxLabal.Name = "shoppingCartListboxLabal";
            this.shoppingCartListboxLabal.Size = new System.Drawing.Size(177, 33);
            this.shoppingCartListboxLabal.TabIndex = 3;
            this.shoppingCartListboxLabal.Text = "SHOPPING CART";
            // 
            // makePurchase
            // 
            this.makePurchase.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchase.Location = new System.Drawing.Point(800, 253);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(134, 54);
            this.makePurchase.TabIndex = 5;
            this.makePurchase.Text = "PURCHASE";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // vendorListbox
            // 
            this.vendorListbox.BackColor = System.Drawing.Color.Purple;
            this.vendorListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorListbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendorListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 29;
            this.vendorListbox.Location = new System.Drawing.Point(50, 496);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(353, 89);
            this.vendorListbox.TabIndex = 7;
            // 
            // vendroListboxLabel
            // 
            this.vendroListboxLabel.AutoSize = true;
            this.vendroListboxLabel.BackColor = System.Drawing.Color.Purple;
            this.vendroListboxLabel.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendroListboxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vendroListboxLabel.Location = new System.Drawing.Point(54, 466);
            this.vendroListboxLabel.Name = "vendroListboxLabel";
            this.vendroListboxLabel.Size = new System.Drawing.Size(103, 33);
            this.vendroListboxLabel.TabIndex = 6;
            this.vendroListboxLabel.Text = "VENDORS";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.BackColor = System.Drawing.Color.Purple;
            this.storeProfitLabel.Font = new System.Drawing.Font("Chiller", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.storeProfitLabel.Location = new System.Drawing.Point(658, 496);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(167, 33);
            this.storeProfitLabel.TabIndex = 8;
            this.storeProfitLabel.Text = "STORE PROFIT:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.BackColor = System.Drawing.Color.Purple;
            this.storeProfitValue.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.storeProfitValue.Location = new System.Drawing.Point(850, 496);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(83, 32);
            this.storeProfitValue.TabIndex = 9;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStoreUI.Properties.Resources.bookart;
            this.ClientSize = new System.Drawing.Size(1026, 619);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.vendroListboxLabel);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.shoppingCartListboxLabal);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label shoppingCartListboxLabal;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label vendroListboxLabel;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

