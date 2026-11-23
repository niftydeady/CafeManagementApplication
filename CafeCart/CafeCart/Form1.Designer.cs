namespace CafeCart
{
    partial class OrderPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Orders = new GroupBox();
            Quantity = new Label();
            ItemQuantity = new NumericUpDown();
            ViewDetails = new Button();
            addItem = new CheckBox();
            ItemPrice = new Label();
            ItemName = new Label();
            ItemPic = new PictureBox();
            panel1 = new Panel();
            TotalAmount = new Label();
            OrderB = new Button();
            Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Orders
            // 
            Orders.BackColor = Color.FromArgb(128, 64, 0);
            Orders.Controls.Add(Quantity);
            Orders.Controls.Add(ItemQuantity);
            Orders.Controls.Add(ViewDetails);
            Orders.Controls.Add(addItem);
            Orders.Controls.Add(ItemPrice);
            Orders.Controls.Add(ItemName);
            Orders.Controls.Add(ItemPic);
            Orders.Location = new Point(1, -1);
            Orders.Name = "Orders";
            Orders.Size = new Size(801, 155);
            Orders.TabIndex = 0;
            Orders.TabStop = false;
            Orders.Enter += Orders_Enter;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.ForeColor = SystemColors.ButtonHighlight;
            Quantity.Location = new Point(178, 81);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(53, 15);
            Quantity.TabIndex = 6;
            Quantity.Text = "Quantity";
            // 
            // ItemQuantity
            // 
            ItemQuantity.Location = new Point(143, 79);
            ItemQuantity.Name = "ItemQuantity";
            ItemQuantity.Size = new Size(29, 23);
            ItemQuantity.TabIndex = 5;
            ItemQuantity.ValueChanged += ItemQuantity_ValueChanged;
            // 
            // ViewDetails
            // 
            ViewDetails.Location = new Point(235, 109);
            ViewDetails.Name = "ViewDetails";
            ViewDetails.Size = new Size(75, 23);
            ViewDetails.TabIndex = 4;
            ViewDetails.Text = "View";
            ViewDetails.UseVisualStyleBackColor = true;
            ViewDetails.Click += ViewDetails_Click;
            // 
            // addItem
            // 
            addItem.AutoSize = true;
            addItem.ForeColor = SystemColors.ButtonHighlight;
            addItem.Location = new Point(143, 112);
            addItem.Name = "addItem";
            addItem.Size = new Size(75, 19);
            addItem.TabIndex = 3;
            addItem.Text = "Add Item";
            addItem.UseVisualStyleBackColor = true;
            addItem.CheckedChanged += addItem_CheckedChanged;
            // 
            // ItemPrice
            // 
            ItemPrice.AutoSize = true;
            ItemPrice.ForeColor = SystemColors.ButtonHighlight;
            ItemPrice.Location = new Point(143, 55);
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new Size(60, 15);
            ItemPrice.TabIndex = 2;
            ItemPrice.Text = "Item Price";
            ItemPrice.Click += ItemPrice_Click;
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.ForeColor = SystemColors.ButtonHighlight;
            ItemName.Location = new Point(143, 26);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(66, 15);
            ItemName.TabIndex = 1;
            ItemName.Text = "Item Name";
            ItemName.Click += ItemName_Click;
            // 
            // ItemPic
            // 
            ItemPic.BackColor = Color.White;
            ItemPic.Location = new Point(9, 17);
            ItemPic.Name = "ItemPic";
            ItemPic.Size = new Size(115, 114);
            ItemPic.TabIndex = 0;
            ItemPic.TabStop = false;
            ItemPic.Click += ItemPic_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(TotalAmount);
            panel1.Controls.Add(OrderB);
            panel1.ForeColor = Color.FromArgb(128, 64, 0);
            panel1.Location = new Point(1, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 100);
            panel1.TabIndex = 1;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.ForeColor = Color.White;
            TotalAmount.Location = new Point(35, 42);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(33, 15);
            TotalAmount.TabIndex = 1;
            TotalAmount.Text = "Total";
            // 
            // OrderB
            // 
            OrderB.Location = new Point(673, 45);
            OrderB.Name = "OrderB";
            OrderB.Size = new Size(75, 23);
            OrderB.TabIndex = 0;
            OrderB.Text = "ORDER";
            OrderB.UseVisualStyleBackColor = true;
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Orders);
            Name = "OrderPanel";
            Text = "Form1";
            Orders.ResumeLayout(false);
            Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Orders;
        private Label ItemName;
        private PictureBox ItemPic;
        private CheckBox addItem;
        private Label ItemPrice;
        private Button ViewDetails;
        private Panel panel1;
        private Label Quantity;
        private NumericUpDown ItemQuantity;
        private Button OrderB;
        private Label TotalAmount;
    }
}
