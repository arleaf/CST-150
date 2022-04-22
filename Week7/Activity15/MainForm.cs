namespace LuckyNumber
{
    public partial class MainForm : Form
    {
        public string name;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            birthMonthBox.SelectedIndex = 0;
            for(int i = 1; i < 32; i++)
            {
                birthDayBox.Items.Add(i.ToString());
            }
            birthDayBox.SelectedIndex = 0;
            favColorBox.SelectedIndex = 0;
        }

        private void birthMonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (birthMonthBox.SelectedIndex == 1)
            {
                birthDayBox.SelectedIndex = birthDayBox.Items.IndexOf("29");
            }
            else if (birthMonthBox.SelectedIndex == 3 || birthMonthBox.SelectedIndex == 5 || birthMonthBox.SelectedIndex == 8 || birthMonthBox.SelectedIndex == 10)
            {
                birthDayBox.SelectedIndex = birthDayBox.Items.IndexOf("30");
            }
            else if (birthDayBox.SelectedIndex != 30)
            {
                birthDayBox.SelectedIndex = birthDayBox.Items.IndexOf("31");
            }
        }

        private void findLuckyNumButton_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.userNameLabel.Text = nameTextBox.Text+"'s";
            switch (favColorBox.SelectedIndex)
            {
                case 0:
                    resultsForm.luckyNumlabel.ForeColor = Color.Pink;
                    break;
                case 1:
                    resultsForm.luckyNumlabel.ForeColor = Color.Blue;
                    break;
                case 2:
                    resultsForm.luckyNumlabel.ForeColor = Color.Green;
                    break;
                case 3:
                    resultsForm.luckyNumlabel.ForeColor = Color.Red;
                    break;
                case 4:
                    resultsForm.luckyNumlabel.ForeColor= Color.Purple;
                    break;
            }
            resultsForm.ShowDialog();
        }
    }
}