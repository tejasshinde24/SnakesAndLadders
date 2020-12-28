using System;

namespace SnakesAndLadders
{
    public static class DiceThrow
    {
        public static int Turn(int currentPosition, int numberOnDice)
        {
            ValidateThrow(currentPosition, numberOnDice);
            if (currentPosition + numberOnDice > 100)
            {
                //do nothing as player can't move 
            }
            else
            {
                currentPosition += numberOnDice;
            }

            return currentPosition;
        }

        private static void ValidateThrow(int currentPosition, int numberOnDice)
        {
            if (currentPosition < 0 || currentPosition >= 100)
            {
                throw new ArgumentException("Invalid Argument", nameof(currentPosition));
            }

            if (numberOnDice <= 0 || numberOnDice > 6)
            {
                throw new ArgumentException("Invalid Argument", nameof(numberOnDice));
            }
        }
    }
}
