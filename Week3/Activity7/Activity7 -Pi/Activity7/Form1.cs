namespace Activity7
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

        private void calButton_Click(object sender, EventArgs e)
        {
            int numOfTerms;
            double piTotal= 0;
            int.TryParse(termsTextBox.Text, out numOfTerms);
            for (int count = 1; count <= numOfTerms; count++)
            {
                int k = count - 1;
                piTotal = piTotal + (4 * Math.Pow(-1, k)) / (2 * k + 1);
            }
            termTextLabel.Text = "The approximate value of pi after " + numOfTerms.ToString() + " terms ";
            piCalculation.Text = " = " + piTotal.ToString();
        }
    }
}