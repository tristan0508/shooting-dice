using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int roll = 0;

            while(true)
            {
                string msg = $"Enter a number between 1-{DiceSize} for a roll: ";
                Console.WriteLine(msg);
                var number = Console.ReadLine();
                try{
                    roll = int.Parse(number);
                }
                catch(FormatException) {}

                if(roll >= 1 && roll <= DiceSize) break;
            }
            return roll;
        }
     
    }
}