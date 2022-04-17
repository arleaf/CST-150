namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close application
            this.Close();
        }

        //Will Create a new game of TictacToe
        private void newGameButton_Click(object sender, EventArgs e)
        {
            int[,] game = generateGame();

            //display First Row
            label1.Text = returnXO(game, 0, 0);
            label2.Text = returnXO(game, 0, 1);
            label3.Text = returnXO(game, 0, 2);
           // display Second Row
            label4.Text = returnXO(game, 1, 0);
            label5.Text = returnXO(game, 1, 1);
            label6.Text = returnXO(game, 1, 2);
            //Display Third Row
            label7.Text = returnXO(game, 2, 0);
            label8.Text = returnXO(game, 2, 1);
            label9.Text = returnXO(game, 2, 2);

            label10.Text = determineWinner(game);
        }
        //This method will generate the 2D array and assign values to the array
        private int[,] generateGame()
        {
            //creating 2D array
            int ROWS = 3;
            int COLUMNS = 3;
            int[,] game = new int[ROWS, COLUMNS];
            Random random = new Random();
            int oCount = 0;
            int xCount = 0;
            //Going through the rows of the 2d array
            for (int row = 0; row < ROWS; row++)
            {
                //Going through the columns of previous row
                for (int column = 0; column < COLUMNS; column++)
                {
                    //Assigns each element a random number of 0 or 1 if x or o did not reach 5 (maximum turns)
                    if (xCount < 5 && oCount < 5)
                    {
                        game[row, column] = random.Next(0, 2);
                        if (game[row, column] == 0)
                        {
                            oCount++;
                        }
                        else
                        {
                            xCount++;
                        }
                    }
                    else if(xCount == 5)
                    {
                        game[row, column] = 0;
                    }
                    else if( oCount == 5)
                    {
                        game[row, column] = 1;
                    } 
                }
            }
            return game;
        }
        //This method will determine the winner of the game by summing rows, then columns
        private string determineWinner(int[,] game)

        //This method will read through the 2d array and return X if 1 or O if 0.
        //THis is for display Labels
        {
            //Sum Rows of the game. If sum is 0, O wins. If sum is 3, X wins
            for (int row = 0; row < game.GetLength(0); row++)
            {
                int total = 0;
                //TOtal the row
                for (int column = 0; column < game.GetLength(1); column++)
                {
                    total += game[row, column];
                }
                if(total == 0)
                {
                    return "O Wins";
                }
                else if (total == 3)
                {
                    return "X Wins";
                }
            }
            //Sum Columns of the game. If sum is 0, O wins. If sum is 3, X wins
            for (int col = 0; col < game.GetLength(1); col++)
            {
                int total = 0;
                //Total the columns
                for (int row = 0; row < game.GetLength(0); row++)
                {
                    total += game[row, col];
                }
                if (total == 0)
                {
                    return "O Wins";
                }
                else if (total == 3)
                {
                    return "X Wins";
                }
            }
            return "Tie";
        }
        private string returnXO(int[,] game, int row, int column)
        {
            
            if(game[row, column] == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}