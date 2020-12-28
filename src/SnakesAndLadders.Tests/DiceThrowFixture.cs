using System;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class DiceThrowFixture
    {
        [Fact]
        public void DiceThrow_ShouldMovePlayer_ForThePositionsOnDo()
        {
            var diceThrow = RandomGenerator.GetRandomDiceNumber();
            var updatedPosition = DiceThrow.Turn(1, diceThrow);
            var expectedPosition = 1 + diceThrow;
            Assert.Equal(expectedPosition, updatedPosition);
        }

        [Theory]
        [InlineData(-1,2)]
        [InlineData(100, 2)]
        [InlineData(102, 2)]
        [InlineData(1, 0)]
        [InlineData(2, 7)]
        public void DiceThrow_ShouldThrowException_ForInvalidPositionAndNumberOnDice(int currentPosition, int numberOnDice)
        {
            Assert.Throws<ArgumentException>(()=>DiceThrow.Turn(currentPosition, numberOnDice));
        }
    }
}
