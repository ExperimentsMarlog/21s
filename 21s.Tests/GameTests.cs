using Xunit;
using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21s.Tests
{
    public class GameTests
    {
        static Card[] GameCards = new Card[] {
                new Card("1",1), new Card("2",2), new Card("3",3), new Card("4",4),
                new Card("5",5), new Card("6",6), new Card("7",7), new Card("8",8)
            };


        [Fact()]
        public void GameTest()
        {
            var game = new Game(new Player("Sam"), new Player("Dealer", true), GameCards);
            Assert.True(game.Player.Name.Equals("Sam"), "Player's name should be Sam");
            Assert.True(game.Dealer.Name.Equals("Dealer"), "Dealser's name should be Dealer");
            Assert.True(game.Dealer.IsDealer, "Dealer should be dealer");
        }

        [Fact()]
        public void NewGameTest()
        {
            var game = new Game(new Player("Sam"), new Player("Dealer"), GameCards);
            game.NewGame();
            Assert.True(game.Winner==null || game.Winner.Name.Equals("Sam"), "On init winner should be null or Sam is winner");

        }

        [Fact()]
        public void ActivePlayerStepTest()
        {
            var game = new Game(new Player("Sam"), new Player("Dealer"), GameCards);
            game.NewGame();
            game.ActivePlayerStep();
            Assert.True(game.Winner != null || game.ActivePlayer.Score < 21);
        }

        [Fact()]
        public void ChangePlayerTest()
        {
            var game = new Game(new Player("Sam"), new Player("Dealer"), GameCards);
            game.NewGame();
            game.ChangePlayer();
            Assert.True(game.ActivePlayer.Name.Equals("Dealer"), "ActivePlayer should be dealer");
        }

    }
}