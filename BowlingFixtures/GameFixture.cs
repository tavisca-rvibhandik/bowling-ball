using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
         [TestInitialize]
        public void First(){
          
         }

         [TestMethod]
         public void AllAreSpares()                 //Test for all strikes
         {
             Game game = new Game();
             for (int i = 0; i < 10; i++)
             
                 game.Roll(1);
                 game.Roll(9);
             if (game.cnt == 20)
                 Assert.AreEqual(game.GetFinalScore(), 200);
         }

        [TestMethod]
        public void AllAreStrikes()                 //Test for all strikes
        {
            Game game = new Game();
            for (int i = 0; i < 10; i++)
                game.Roll(10);
            if (game.cnt == 20)
               
            Assert.AreEqual(game.GetFinalScore(), 300);
        }

        [TestMethod]
        public void AllAreGutters()                 //Test for all strikes
        {
            Game game = new Game();
            for (int i = 0; i < 20; i++)
                game.Roll(0);
            Assert.AreEqual(game.GetFinalScore(), 0);
        }

        [TestMethod]
        public void IncorrectScoreException()           //Calculating total score
        {
            Game game = new Game();
            for (int i = 0; i < 5; i++)
            game.Roll(3);
            game.Roll(5);
            game.Roll(6);
            game.Roll(2);
            if (game.GetFinalScore() > 300)
                Assert.Fail("Incorrect Score.......");
        }

        [TestMethod]
        public void GameOverException()                 //Limiting number of rolls
        {
            Game game = new Game();
            if(game.cnt>21)
            {
                Assert.Fail("Game over....");
            }
        }

         [TestMethod]
         public void IncorrectFrameScore()              //Calculating score per frame
         {
             Game game = new Game();
             game.Roll(4);
             game.Roll(5);
                 
                 if (game.GetScore()>10)
                     Assert.Fail("Incorrect Frame Score.......");
         }
    }
}
