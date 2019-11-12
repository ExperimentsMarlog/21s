using Xunit;
using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21s.Tests
{
    public class DeckTests
    {
        [Fact()]
        public void DeckTest()
        {
            var deck = new Deck();
            Assert.True(deck.IsEmpty, "Default Constructor created bad object");
        }

        [Fact()]
        public void DeckConstructorTestWithList()
        {
            var input = new List<Card>();
            input.Add(new Card("Card1", 1));
            input.Add(new Card("Card2", 2));

            var deck = new Deck(input);

            Assert.True(!deck.IsEmpty, "Internal Stack was initialized");
            Assert.True(deck.Count == 2, "Internal Stack should have 2 elements");
        }


        [Fact()]
        public void AddCardTest()
        {
            var deck = new Deck();
            deck.AddCard(new Card("123", 1));

            Assert.True(!deck.IsEmpty, "Deck was empty");
            Assert.True(deck.Count == 1, "Deck should contain 1 element");
            Assert.True(deck.Count == 1, "Deck should contain 1 element");

            var topCard = deck.GetCard();
            Assert.True(topCard.Description.Equals("123"), "Top Card description was wrong");
            Assert.True(topCard.GetWeight() == 1, "Top Card weight was wrong");

        }

        [Fact()]
        public void GetCardTest()
        {
            var deck = new Deck();
            deck.AddCard(new Card("123", 1));

            var topCard = deck.GetCard();
            Assert.True(topCard.Description.Equals("123"), "Top Card description was wrong");
            Assert.True(topCard.GetWeight() == 1, "Top Card weight was wrong");
        }

        [Fact()]
        public void GetCardWithNumberTest()
        {
            var deck = new Deck();
            deck.AddCard(new Card("123", 1));
            deck.AddCard(new Card("456", 2));
            deck.AddCard(new Card("789", 3));

            var topCard = deck.GetCard(2);
            Assert.True(!deck.IsEmpty && deck.Count==1, "Deck should have only 1 element");
        }

        [Fact()]
        public void ShuffleDesckTest()
        {
            var deck = new Deck();
            deck.AddCard(new Card("123", 1));
            deck.AddCard(new Card("456", 2));
            deck.AddCard(new Card("789", 3));

            deck.ShuffleDeck();

            Assert.True(!deck.IsEmpty && deck.Count == 3, "Deck should have 3 element");

        }
    }
}