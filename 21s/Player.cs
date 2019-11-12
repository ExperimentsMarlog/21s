using System;
using System.Collections.Generic;
using System.Text;

namespace _21s
{
    public class Player
    {
        private List<Card> _players_cards;
       
        //public properties
        public string Name { get; protected set; }
        public bool IsDealer { get; protected set; }

        public int Score
        {
            get
            {
                var result = 0;
                foreach (var card in _players_cards)
                {
                    result += card.GetWeight();
                }

                return result;
            }

        }

        public IList<Card> Cards => _players_cards;


        //constructors
        public Player(string _name, bool _isDealer = false)
        {
            Name = _name;
            IsDealer = _isDealer;
            _players_cards = new List<Card>();
        }

        //public methods
        public int AddCard(Card card)
        {
            _players_cards.Add(card);
            return _players_cards.Count;
        }

        public int AddCard(IEnumerable<Card> card)
        {
            _players_cards.AddRange(card);
            return _players_cards.Count;
        }

        public void RemoveAllCards()
        {
            _players_cards.Clear();
        }


 

    }
}
