using System;

namespace SnakesAndLadders
{
    public static class RandomGenerator
    {
        private static readonly Random _random = new Random();
        private static readonly int _min = 1;
        private static readonly int _max = 6;

        public static int GetRandomDiceNumber()
        {
            return _random.Next(_min, _max); 
        }
    }
}
