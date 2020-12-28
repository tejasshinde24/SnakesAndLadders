namespace SnakesAndLadders
{
    public static class Game
    {
        public static int Start(bool isCrookedDice = false)
        {
            int updatedPosition = 0;
            while (updatedPosition < 100)
            {
                var numberOnDice = RandomGenerator.GetRandomDiceNumber(isCrookedDice);
                updatedPosition = DiceThrow.Turn(updatedPosition, numberOnDice);
            }

            return updatedPosition;
        }
    }
}
