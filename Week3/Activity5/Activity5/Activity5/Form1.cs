using System.IO;
namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamWriter outputFile;
            outputFile = File.CreateText(@"C:\Users\arlet\source\repos\outputStatics.txt");

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                try
                {

                    inputFile = File.OpenText(openFileDialog1.FileName);
                    string longestWord = "";
                    string mostVowelWord ="";
                    int longestVowel = 0;
                    string firstWord = "z";
                    string lastWord = "";
                    //Loop to read file lines
                    while (!inputFile.EndOfStream)
                    {
                        //converting words to lower
                        string line = inputFile.ReadLine();
                        string lowerLine = line.ToLower();
                        outputTextBox.AppendText(lowerLine.ToString() + " ");
                        outputFile.WriteLine(lowerLine);


                        //Finding longest word in file
                        if (line.Length > longestWord.Length)
                        {
                            longestWord = line;
                        }

                        //find word w/ most vowels
                        int vowels = 0;

                        for (int index = 0; index < line.Length; index++)
                        {
                            if (lowerLine[index] == 'a' || lowerLine[index] == 'e' || lowerLine[index] == 'i' || lowerLine[index] == 'o' || lowerLine[index] == 'u')
                            {
                                vowels += 1;
                            }

                        }
                        if (vowels > longestVowel)
                        {
                            longestVowel = vowels;
                            mostVowelWord = lowerLine;
                        }

                        //find first & last word alphabetically
                        if (String.Compare(firstWord, lowerLine) > 0)
                        {
                            firstWord = lowerLine;
                        }

                        if (String.Compare(lastWord, lowerLine) < 0)
                        {
                            lastWord = lowerLine;
                        }
                    }
                    //write to textbox
                    longWordTextBox.Text = longestWord.ToString();
                    voweltextBox.Text = mostVowelWord;
                    firstTextBox.Text = firstWord;
                    LastWordTextBox.Text = lastWord;
                    //write to output file
                    outputFile.WriteLine("Longest Word in File is " + longestWord.ToString());
                    outputFile.WriteLine("Word with most vowels is " + mostVowelWord.ToString());
                    outputFile.WriteLine("First Word Alphabetically is " + firstWord.ToString());
                    outputFile.WriteLine("Last Word Alphabetically is " + lastWord.ToString());
                    inputFile.Close();
                    outputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
            else 
            { 
                MessageBox.Show("Operation Cancelled"); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void firstWordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}