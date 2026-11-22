namespace CafeTest3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogoName_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderOnline_Click(object sender, EventArgs e)
        {

        }

        private void roundedBtnOrderNow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHeadline_Click(object sender, EventArgs e)
        {

        }

        private void lblSubHead_Click(object sender, EventArgs e)
        {

        }

        private void pnlHero_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
        pnlHero.ClientRectangle,
        Color.FromArgb(190, 20, 14, 10), // Dark espresso on the left
        Color.FromArgb(20, 20, 14, 10),  // Nearly transparent on the right (keeps latte bright)
        0f))
            {
                e.Graphics.FillRectangle(brush, pnlHero.ClientRectangle);
            }
        }
    }
}
