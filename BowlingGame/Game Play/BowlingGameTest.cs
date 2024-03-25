using System;
using Xunit;

namespace BowlingGame.Game_Play
{
    public class BowlingGamesTest
    {
        private BowlingGame myGame;

        public BowlingGamesTest()
        {
            myGame = new BowlingGame();
        }

        private void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                myGame.Roll(pins);
            }
        }

        private void rollSpare()
        {
            myGame.Roll(6);
            myGame.Roll(4);
        }

        [Fact]
        private void Roll_GutterGame_ScoreZero()
        {
            rollMany(20, 0);
            Assert.Equal(0, myGame.Score());
        }

        [Fact]
        public void Roll_TestAllOnes_ScoreAddsOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, myGame.Score());
        }

        [Fact]
        public void Roll_TestOneSpare_ScoreInvolvesSpareCalculation()
        {
            rollSpare();
            myGame.Roll(4);
            rollMany(17, 0);
            Assert.Equal(18, myGame.Score());
        }

        [Fact]
        public void Roll_TestOneStrike_ScoreInvolvesStrikeCalculation()
        {
            myGame.Roll(10);
            myGame.Roll(4);
            myGame.Roll(5);
            rollMany(17, 0);
            Assert.Equal(28, myGame.Score());
        }

        [Fact]
        public void Roll_TestPerfectGame_PerfectBowlingScore()
        {
            rollMany(12, 10);
            Assert.Equal(300, myGame.Score());
        }

        [Fact]
        public void TestRandomGameNoExtraRoll()
        {
            myGame.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 });
            Assert.Equal(131, myGame.Score());
        }

        [Fact]
        public void TestRandomGameWithSpareThenStrikeAtEnd()
        {
            myGame.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 1, 10 });
            Assert.Equal(143, myGame.Score());
        }

        [Fact]
        public void TestRandomGameWithThreeStrikesAtEnd()
        {
            myGame.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 10, 10, 10 });
            Assert.Equal(163, myGame.Score());
        }
    }
}
