using Xunit;

namespace SnakesAndLadders.Tests
{
    public class GameFixture
    {
        [Fact]
        public void PlayGame_WithCrookedDice_ShouldReturn_LastPosition100_AfterCompletion()
        {
            var isCrookedDice = true;
            var lastValidPosition = Game.Start(isCrookedDice);
            Assert.Equal(100, lastValidPosition);
        }

        [Fact]
        public void PlayGame_WithOutCrookedDice_ShouldReturn_LastPosition100_AfterCompletion()
        {
            var lastValidPosition = Game.Start();
            Assert.Equal(100, lastValidPosition);
        }
    }
}
