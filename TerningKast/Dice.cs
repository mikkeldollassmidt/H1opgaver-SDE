using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningKast
{
    public class Dice
    {
        private int numberOfSides;
        public int NumberOfSides
        {
            get { return numberOfSides; }
            set { numberOfSides = value; }
        }

        // constructer. The dices always has 6 sides.
        public Dice()
        {
            numberOfSides = 6;
        }

        // Method for rolling dice.
        public int DiceRoll()
        {
            // new Random
            Random r = new Random();
            // diceRolling from 1, to sides of dice + 1, because of index in Next library.
            int diceRoll = r.Next(1, numberOfSides + 1);

            return diceRoll;
        }
    }
}
