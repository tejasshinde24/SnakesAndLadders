using System;

namespace SnakesAndLadders
{
    public static class RandomGenerator
    {
        private static readonly Random _random = new Random();

        public static int GetRandomDiceNumber(bool isCrookedDice = false)
        {
            if (isCrookedDice)
            {
                return _random.Next(1,4) * 2;
            }
            else
            {
                return _random.Next(1, 7);
            }
        }
    }
}
