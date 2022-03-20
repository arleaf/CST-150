namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int secondsEntered;
            //try to parse text entered as int
            if (int.TryParse(inputTextBox.Text, out secondsEntered))
            {
                //Seconds entered should be postive
                if (secondsEntered >= 0)
                {
                    if (secondsEntered >= 86400)
                    {
                        int days = secondsEntered / 86400;
                        int seconds = secondsEntered % 86400;
                        string day = days.ToString();
                        string sec = seconds.ToString();
                        displayLabel.Text = day + " Days and " + sec + " seconds.";
                    }
                    else if (secondsEntered >= 3600)
                    {
                        int hours = secondsEntered / 3600;
                        int seconds = secondsEntered % 3600;
                        string hr = hours.ToString();
                        string sec = seconds.ToString();
                        displayLabel.Text = hr + " Hours and " + sec + " seconds.";
                    }
                    else if(secondsEntered >= 60)
                    {
                        int minutes = secondsEntered / 60;
                        int seconds = secondsEntered % 60;
                        string min = minutes.ToString();
                        string sec = seconds.ToString();
                        displayLabel.Text = min + " Minutes and " + sec + " seconds.";
                    }
                    else
                    {
                        string seconds = secondsEntered.ToString();
                        displayLabel.Text = seconds + " seconds";
                    }
                }
                else
                {
                    MessageBox.Show("Enter seconds equal to or higher than 0");
                }
            }
            else
            {
                MessageBox.Show("Enter valid seconds as integer.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}