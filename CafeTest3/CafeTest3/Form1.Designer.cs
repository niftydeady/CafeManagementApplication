namespace CafeTest3
{
    partial class Form1
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
            panelNavigation = new Panel();
            pictureBox2 = new PictureBox();
            flowLayoutPanelNavigation = new FlowLayoutPanel();
            lblHome = new Label();
            lblAboutUs = new Label();
            lblMENU = new Label();
            lblLocations = new Label();
            lblOrderOnline = new Label();
            lblContact = new Label();
            roundedBtnOrderNow = new RoundedButton();
            lblLogoName = new Label();
            pictureBox1 = new PictureBox();
            pnlHero = new Panel();
            roundedBtnViewMore = new RoundedButton();
            roundedBtnOrderNowTwo = new RoundedButton();
            lblSubHead = new Label();
            lblHeadline = new Label();
            pnlPageContainer = new Panel();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHero.SuspendLayout();
            pnlPageContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavigation.BackColor = Color.FromArgb(34, 24, 18);
            panelNavigation.Controls.Add(pictureBox2);
            panelNavigation.Controls.Add(flowLayoutPanelNavigation);
            panelNavigation.Controls.Add(roundedBtnOrderNow);
            panelNavigation.Controls.Add(lblLogoName);
            panelNavigation.Controls.Add(pictureBox1);
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(1263, 70);
            panelNavigation.TabIndex = 0;
            panelNavigation.Paint += panelNavigation_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.bag;
            pictureBox2.Location = new Point(1131, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanelNavigation
            // 
            flowLayoutPanelNavigation.AutoSize = true;
            flowLayoutPanelNavigation.Controls.Add(lblHome);
            flowLayoutPanelNavigation.Controls.Add(lblAboutUs);
            flowLayoutPanelNavigation.Controls.Add(lblMENU);
            flowLayoutPanelNavigation.Controls.Add(lblLocations);
            flowLayoutPanelNavigation.Controls.Add(lblOrderOnline);
            flowLayoutPanelNavigation.Controls.Add(lblContact);
            flowLayoutPanelNavigation.Location = new Point(285, 3);
            flowLayoutPanelNavigation.Name = "flowLayoutPanelNavigation";
            flowLayoutPanelNavigation.Padding = new Padding(0, 20, 0, 0);
            flowLayoutPanelNavigation.Size = new Size(669, 90);
            flowLayoutPanelNavigation.TabIndex = 1;
            flowLayoutPanelNavigation.Paint += flowLayoutPanel1_Paint;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.Transparent;
            lblHome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblHome.ForeColor = Color.FromArgb(209, 192, 172);
            lblHome.Location = new Point(15, 20);
            lblHome.Margin = new Padding(15, 0, 15, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(53, 20);
            lblHome.TabIndex = 1;
            lblHome.Text = "HOME";
            lblHome.Click += lblHome_Click;
            // 
            // lblAboutUs
            // 
            lblAboutUs.AutoSize = true;
            lblAboutUs.BackColor = Color.Transparent;
            lblAboutUs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblAboutUs.ForeColor = Color.FromArgb(209, 192, 172);
            lblAboutUs.Location = new Point(98, 20);
            lblAboutUs.Margin = new Padding(15, 0, 15, 0);
            lblAboutUs.Name = "lblAboutUs";
            lblAboutUs.Size = new Size(81, 20);
            lblAboutUs.TabIndex = 6;
            lblAboutUs.Text = "ABOUT US";
            // 
            // lblMENU
            // 
            lblMENU.AutoSize = true;
            lblMENU.BackColor = Color.Transparent;
            lblMENU.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblMENU.ForeColor = Color.FromArgb(209, 192, 172);
            lblMENU.Location = new Point(209, 20);
            lblMENU.Margin = new Padding(15, 0, 15, 0);
            lblMENU.Name = "lblMENU";
            lblMENU.Size = new Size(54, 20);
            lblMENU.TabIndex = 5;
            lblMENU.Text = "MENU";
            // 
            // lblLocations
            // 
            lblLocations.AutoSize = true;
            lblLocations.BackColor = Color.Transparent;
            lblLocations.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblLocations.ForeColor = Color.FromArgb(209, 192, 172);
            lblLocations.Location = new Point(293, 20);
            lblLocations.Margin = new Padding(15, 0, 15, 0);
            lblLocations.Name = "lblLocations";
            lblLocations.Size = new Size(88, 20);
            lblLocations.TabIndex = 4;
            lblLocations.Text = "LOCATIONS";
            // 
            // lblOrderOnline
            // 
            lblOrderOnline.AutoSize = true;
            lblOrderOnline.BackColor = Color.Transparent;
            lblOrderOnline.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblOrderOnline.ForeColor = Color.FromArgb(209, 192, 172);
            lblOrderOnline.Location = new Point(411, 20);
            lblOrderOnline.Margin = new Padding(15, 0, 15, 0);
            lblOrderOnline.Name = "lblOrderOnline";
            lblOrderOnline.Size = new Size(115, 20);
            lblOrderOnline.TabIndex = 3;
            lblOrderOnline.Text = "ORDER ONLINE";
            lblOrderOnline.Click += lblOrderOnline_Click;
            // 
            // lblContact
            // 
            lblContact.Anchor = AnchorStyles.None;
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.Transparent;
            lblContact.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(209, 192, 172);
            lblContact.Location = new Point(556, 20);
            lblContact.Margin = new Padding(15, 0, 15, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(75, 20);
            lblContact.TabIndex = 2;
            lblContact.Text = "CONTACT";
            lblContact.Click += lblContact_Click;
            // 
            // roundedBtnOrderNow
            // 
            roundedBtnOrderNow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedBtnOrderNow.BackColor = Color.FromArgb(209, 192, 172);
            roundedBtnOrderNow.BorderColor = Color.Transparent;
            roundedBtnOrderNow.BorderRadius = 8;
            roundedBtnOrderNow.BorderSize = 0;
            roundedBtnOrderNow.FlatAppearance.BorderSize = 0;
            roundedBtnOrderNow.FlatStyle = FlatStyle.Flat;
            roundedBtnOrderNow.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            roundedBtnOrderNow.ForeColor = Color.FromArgb(34, 24, 18);
            roundedBtnOrderNow.Location = new Point(977, 14);
            roundedBtnOrderNow.Margin = new Padding(20, 12, 0, 0);
            roundedBtnOrderNow.Name = "roundedBtnOrderNow";
            roundedBtnOrderNow.Size = new Size(125, 38);
            roundedBtnOrderNow.TabIndex = 1;
            roundedBtnOrderNow.Text = "ORDER NOW";
            roundedBtnOrderNow.UseVisualStyleBackColor = false;
            roundedBtnOrderNow.Click += roundedBtnOrderNow_Click;
            // 
            // lblLogoName
            // 
            lblLogoName.AutoSize = true;
            lblLogoName.BackColor = Color.Transparent;
            lblLogoName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogoName.ForeColor = Color.White;
            lblLogoName.Location = new Point(77, 25);
            lblLogoName.Name = "lblLogoName";
            lblLogoName.Size = new Size(82, 21);
            lblLogoName.TabIndex = 1;
            lblLogoName.Text = "CafeBrew";
            lblLogoName.Click += lblLogoName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coffeicon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlHero
            // 
            pnlHero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHero.BackgroundImage = Properties.Resources.Warm_Café_Ambiance;
            pnlHero.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHero.Controls.Add(roundedBtnViewMore);
            pnlHero.Controls.Add(roundedBtnOrderNowTwo);
            pnlHero.Controls.Add(lblSubHead);
            pnlHero.Controls.Add(lblHeadline);
            pnlHero.Location = new Point(0, 0);
            pnlHero.Name = "pnlHero";
            pnlHero.Size = new Size(1260, 550);
            pnlHero.TabIndex = 1;
            pnlHero.Paint += pnlHero_Paint;
            // 
            // roundedBtnViewMore
            // 
            roundedBtnViewMore.BackColor = Color.Transparent;
            roundedBtnViewMore.BorderColor = Color.FromArgb(209, 192, 172);
            roundedBtnViewMore.BorderRadius = 8;
            roundedBtnViewMore.BorderSize = 1;
            roundedBtnViewMore.FlatAppearance.BorderSize = 0;
            roundedBtnViewMore.FlatStyle = FlatStyle.Flat;
            roundedBtnViewMore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            roundedBtnViewMore.ForeColor = Color.Tan;
            roundedBtnViewMore.Location = new Point(228, 264);
            roundedBtnViewMore.Margin = new Padding(20, 12, 0, 0);
            roundedBtnViewMore.Name = "roundedBtnViewMore";
            roundedBtnViewMore.Size = new Size(125, 38);
            roundedBtnViewMore.TabIndex = 3;
            roundedBtnViewMore.Text = "VIEW MORE";
            roundedBtnViewMore.UseVisualStyleBackColor = false;
            // 
            // roundedBtnOrderNowTwo
            // 
            roundedBtnOrderNowTwo.BackColor = Color.FromArgb(209, 192, 172);
            roundedBtnOrderNowTwo.BorderColor = Color.Transparent;
            roundedBtnOrderNowTwo.BorderRadius = 8;
            roundedBtnOrderNowTwo.BorderSize = 0;
            roundedBtnOrderNowTwo.FlatAppearance.BorderSize = 0;
            roundedBtnOrderNowTwo.FlatStyle = FlatStyle.Flat;
            roundedBtnOrderNowTwo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            roundedBtnOrderNowTwo.ForeColor = Color.FromArgb(34, 24, 18);
            roundedBtnOrderNowTwo.Location = new Point(77, 264);
            roundedBtnOrderNowTwo.Margin = new Padding(20, 12, 0, 0);
            roundedBtnOrderNowTwo.Name = "roundedBtnOrderNowTwo";
            roundedBtnOrderNowTwo.Size = new Size(125, 38);
            roundedBtnOrderNowTwo.TabIndex = 2;
            roundedBtnOrderNowTwo.Text = "ORDER NOW";
            roundedBtnOrderNowTwo.UseVisualStyleBackColor = false;
            // 
            // lblSubHead
            // 
            lblSubHead.AutoSize = true;
            lblSubHead.BackColor = Color.Transparent;
            lblSubHead.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubHead.ForeColor = Color.FromArgb(209, 192, 172);
            lblSubHead.Location = new Point(77, 219);
            lblSubHead.Name = "lblSubHead";
            lblSubHead.Size = new Size(257, 17);
            lblSubHead.TabIndex = 1;
            lblSubHead.Text = "FRESHLY ROASTED, BREWED TO ORDER.";
            lblSubHead.Click += lblSubHead_Click;
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.BackColor = Color.Transparent;
            lblHeadline.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeadline.ForeColor = Color.FromArgb(255, 248, 238);
            lblHeadline.Location = new Point(77, 26);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(596, 168);
            lblHeadline.TabIndex = 0;
            lblHeadline.Text = "Craft in every cup, \nwarmth  in every sip, \nmoments made to stay.";
            lblHeadline.Click += lblHeadline_Click;
            // 
            // pnlPageContainer
            // 
            pnlPageContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPageContainer.AutoScroll = true;
            pnlPageContainer.BackColor = Color.FromArgb(242, 236, 228);
            pnlPageContainer.Controls.Add(pnlHero);
            pnlPageContainer.Location = new Point(0, 70);
            pnlPageContainer.Name = "pnlPageContainer";
            pnlPageContainer.Size = new Size(1260, 1990);
            pnlPageContainer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 236, 228);
            ClientSize = new Size(1280, 788);
            Controls.Add(pnlPageContainer);
            Controls.Add(panelNavigation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(0, 70);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeManagement";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanelNavigation.ResumeLayout(false);
            flowLayoutPanelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHero.ResumeLayout(false);
            pnlHero.PerformLayout();
            pnlPageContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavigation;
        private PictureBox pictureBox1;
        private Label lblLogoName;
        private FlowLayoutPanel flowLayoutPanelNavigation;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAboutUs;
        private Label lblHome;
        private Label lblContact;
        private Label lblOrderOnline;
        private Label lblLocations;
        private Label lblMENU;
        private RoundedButton roundedBtnOrderNow;
        private PictureBox pictureBox2;
        private Panel pnlHero;
        private Label lblHeadline;
        private Label lblSubHead;
        private RoundedButton roundedBtnViewMore;
        private RoundedButton roundedBtnOrderNowTwo;
        private Panel pnlPageContainer;
    }
}
