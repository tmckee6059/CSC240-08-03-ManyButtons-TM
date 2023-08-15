namespace CSC240_08_03_ManyButtons_TM
{
    public partial class ManyButtonsForm : Form
    {
        public ManyButtonsForm()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}