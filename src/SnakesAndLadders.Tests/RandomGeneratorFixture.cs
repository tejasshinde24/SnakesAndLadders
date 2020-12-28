using Xunit;

namespace SnakesAndLadders.Tests
{
    public class RandomGeneratorFixture
    {
        [Fact]
        public void RandomGenerator_ShouldReturnNumber_LessThanSeven()
        {
            var diceThrow = RandomGenerator.GetRandomDiceNumber();
            Assert.True(diceThrow < 7);
            Assert.True(diceThrow > 0);
        }

        [Fact]
        public void RandomGenerator_ShouldReturnNumber_GreaterThanZero()
        {
            var diceThrow = RandomGenerator.GetRandomDiceNumber();
            Assert.True(diceThrow > 0);
        }

        [Fact]
        public void RandomGenerator_ShouldReturnNumber_InRangeOneToSix()
        {
            var diceThrow = RandomGenerator.GetRandomDiceNumber();
            Assert.InRange<int>(diceThrow, 1, 6);
        }
    }
}
