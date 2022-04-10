using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice
{
    internal class Dice
    {
        private int sides;

        //Constructor which takes # of sides
        public Dice(int sides)
        {
            if (sides >= 4 && sides<= 20)
            {
                //sets the parameter to the dice property sides
                this.sides = sides;
            }
            else
            {
                MessageBox.Show("Enter number between 4-20");
            }
        }

        //Method to roll Dice. Returns random number or face of the Dice
        public int rollDie()
        {
            Random rand = new Random();
            // returning random number
            return rand.Next(1,sides+1);
        }
    }
}
