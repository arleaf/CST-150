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
            try
            {
                string celsiusDegrees;
                double farenheitDegrees;
                //This returns input from textBox and assigns it to celsuisDegrees
                celsiusDegrees = celsiusTextBox.Text;
                //Perform celisus to farenheit calculation
                //Converts string to double
                farenheitDegrees = (double.Parse(celsiusDegrees) * 1.8) + 32;
                //Converts double to string & uses number format up to 3 decimal places
                farenheitLabel.Text = farenheitDegrees.ToString("n3");
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message + " Input Valid Number.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}