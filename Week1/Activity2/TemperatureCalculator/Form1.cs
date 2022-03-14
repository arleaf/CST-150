namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void farenheitLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string celsiusDegrees;
            double farenheitDegrees;
            //This returns input from textBox and assigns it to celsuisDegrees
            celsiusDegrees = celsiusTextBox.Text;
            //Perform celisus to farenheit calculation
            //Converts string to double
            farenheitDegrees = (double.Parse(celsiusDegrees)*1.8) + 32;
            //Converts double to string
            farenheitLabel.Text = farenheitDegrees.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}