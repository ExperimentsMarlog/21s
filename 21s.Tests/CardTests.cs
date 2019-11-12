using Xunit;
using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21s.Tests
{
    public class CardTests
    {
        [Fact()]
        public void CardTest()
        {
            var card = new Card("123", 1);
            
            Assert.True(card.Description.Equals("123"), "Card description is not correct");
            Assert.True(card.BaseWeight == 1, "Card baseweight is not correct");
        }

        [Fact()]
        public void GetWeightTest()
        {
            var card = new Card("123", 1);
            Assert.True(card.GetWeight()==1, "Method GetWeight returns bad result");
        }
    }
}