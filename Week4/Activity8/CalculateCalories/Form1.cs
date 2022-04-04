namespace CalculateCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //methods
        //Fat Calories method. This method will take fat grams and calculate calories from said fat
        private double FatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }
        //Carb Calories method. This method will tqake carb grams and calculate calories from said carbs
        private double CarbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }
        
        //Button Click Methods
        private void button1_Click(object sender, EventArgs e)
        {
            double fatGrams;
            
            if (Double.TryParse(fatGramsTextBox.Text, out fatGrams) && fatGrams >= 0)
            {
                double calories = FatCalories(fatGrams);
                fatCaloriesLabel.Text = calories.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid number greater than or equal to 0.");
            }
        }

        private void calculateFromCarbButton_Click(object sender, EventArgs e)
        {
            double carbGrams;

            if (Double.TryParse(fatGramsTextBox.Text, out carbGrams) && carbGrams >= 0)
            {
                double calories = CarbCalories(carbGrams);
                carbCaloriesLabel.Text = calories.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid number greater than or equal to 0.");
            }
        }
    }
}