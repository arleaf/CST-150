namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cardFront_Click(object sender, EventArgs e)
        {

        }

        private void cardBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardBack.Visible = false;
            cardFront.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            cardBack.Visible = true;
            cardFront.Visible = false;
        }
    }
}