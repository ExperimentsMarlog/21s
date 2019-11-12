using Xunit;
using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21s.Tests
{
    public class PlayerTests
    {
        [Fact()]
        public void PlayerTest()
        {
            var player = new Player("Bob");

            Assert.True(player.Name.Equals("Bob"), "The name should be Bob");
            Assert.True(!player.IsDealer, "Bob should not be dealer");
        }

        public void PlayerDealerTest()
        {
            var player = new Player("Dealer", true);

            Assert.True(player.Name.Equals("Dealer"), "The name should be Dealer");
            Assert.True(player.IsDealer, "Dealer should be dealer");
        }


        [Fact()]
        public void AddCardTest()
        {
            var player = new Player("Bob");
            var count = player.AddCard(new Card("123", 1));

            Assert.True(count == 1, "The number of player's cards should be 1");
        }

        [Fact()]
        public void AddCardListTest()
        {
            var player = new Player("Bob");
            var count = player.AddCard(new Card[] { new Card("123", 1), new Card("123", 2) });
            Assert.True(count ==2, "The number of player's cards should be 2");
        }

        [Fact()]
        public void RemoveAllCardsTest()
        {
            var player = new Player("Bob");
            var count = player.AddCard(new Card[] { new Card("123", 1), new Card("123", 2) });
            player.RemoveAllCards();

            Assert.True(player.Cards.Count==0, "The number of player's cards should be 0");
        }
    }
}