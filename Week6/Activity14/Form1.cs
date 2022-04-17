namespace Activity14
{
    public partial class Form1 : Form
    {
        string imagePath = "C:/Users/Arlet/source/repos/Activity14/Images";
        public Form1()
        {
            InitializeComponent();
        }

         //Method will change displayed picture based on listbox selection
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
            switch (selectedItem)
            {
               
                case "Sonic":
                    characterPictureBox.Image = Image.FromFile(imagePath+"/sonic.png");
                    characterPictureBox.BackColor = Color.Transparent;
                    break;
                
                case "Tails":
                    characterPictureBox.Image = Image.FromFile(imagePath +"/tails.png");
                    break;
                //
                case "Knuckles":
                    characterPictureBox.Image = Image.FromFile(imagePath + "/knuckles.png");
                    break;
            }
        }

        //Method will change Ability label text to speed
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            abilityLabel.Text = "Speed";
        }
        //Method will change Ability label text to strength
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            abilityLabel.Text = "Strength";
        }
        //Method will change Ability label text to Fly
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            abilityLabel.Text = "Fly";
        }
        //Method will change like label based on character and if checkbox is selected
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    likesLabel.Text = "Likes: ChilliDogs";
                }
                if (listBox1.SelectedIndex == 1)
                {
                    likesLabel.Text = "Likes: Inventing";
                }
                if (listBox1.SelectedIndex == 2)
                {
                    likesLabel.Text = "Likes: Emeralds";
                }
            }
            else
            {
                likesLabel.Text = "";
            }
            

        }
        //Method will change species label based on character and if checkbox is selected
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    speciesLabel.Text = "Spieces: HedgeHog";
                }
                if (listBox1.SelectedIndex == 1)
                {
                    speciesLabel.Text = "Species: Fox";
                }
                if (listBox1.SelectedIndex == 2)
                {
                    speciesLabel.Text = "Species: Echidna";
                }
            }
            else
            {
                speciesLabel.Text = "";
            }
        }
        //Method will change height label based on character and if checkbox is selected
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    heightLabel.Text = "Height: 100cm";
                }
                if (listBox1.SelectedIndex == 1)
                {
                    heightLabel.Text = "Height: 80cm";
                }
                if (listBox1.SelectedIndex == 2)
                {
                    heightLabel.Text = "Height: 110 cm";
                }
            }
            else
            {
                heightLabel.Text = "";
            }
        }
    }
}