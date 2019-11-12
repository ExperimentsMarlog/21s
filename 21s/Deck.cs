using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21s
{
    public class Deck
    {
        private Stack<Card> _deck;


        public bool IsEmpty
        {
            get
            {
                return _deck == null || _deck.Count <= 0;
            }
        }

        public int Count
        {
            get
            {
                return IsEmpty ? 0 : _deck.Count;
            }
        }


        //constructor
        public Deck() {
            _deck = new Stack<Card>();
        }

        public Deck(IList<Card> cards_set, bool toShuffle = false)
        {
            if (toShuffle)
            {
                cards_set.Shuffle<Card>();
            }

            _deck = new Stack<Card>();

            foreach (var card in cards_set)
            {
                AddCard(card);
            }
        }



        //Public Methods
        public void AddCard(Card card)
        {
            _deck.Push(card);
        }

        public Card GetCard()
        {
            if (IsEmpty)
                return null;
            else
            {
                return _deck.Pop();
            }
        }

        public IEnumerable<Card> GetCard(int count)
        {
            if (count <= 0 || IsEmpty)
                return null;

            var result = new List<Card>();
            for(int i=0; i<count; i++)
            {
                if (IsEmpty)
                    break;
                result.Add(_deck.Pop());
            }
            return result.Count > 0 ? result : null;
        }


        public void ShuffleDeck()
        {
            var copy = new Card[_deck.Count];
            _deck.CopyTo(copy, 0);
            copy.Shuffle<Card>();
            _deck.Clear();
            foreach (var card in copy)
            {
                _deck.Push(card);
            }

            copy = null;
        }



    }
}
