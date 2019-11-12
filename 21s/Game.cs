using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _21s
{
    public class Game
    {


        //private members
        IList<Card> gameCards;

        IList<Player> players = null;
        Deck deck = null;
        Player winner = null;
        Player dealer = null;
        Player player = null;
        Player activePlayer = null;

        //public members

        public Player ActivePlayer {
            get {
                return activePlayer;
            }
            protected set
            {
                activePlayer = value;
            }
        }

        public Player Player
        {
            get
            {
                return player;
            }
        }
        public Player Dealer
        {
            get
            {
                return dealer;
            }
        }
        public Player Winner
        {
            get
            {
                return winner;
            }
        }

        public Deck Deck{
            get
            {
                return deck;
            }
        }

        //constructor
        public Game(Player _player, Player _dealer, IList<Card> _gameCards)
        {
            gameCards = _gameCards;
            dealer = _dealer;
            player = _player;
            players = new List<Player>(new[] { player, dealer });
        }


        //private methods
        void InitLayout()
        {
            deck = new Deck(gameCards.ToList(), true);
            foreach (var player in players)
            {
                player.AddCard(deck.GetCard(2));
            }


            if (ActivePlayer.Score == 21)
                winner = ActivePlayer;

            GetStatus();
        }

        //public methods
        public void NewGame()
        {
            player.RemoveAllCards();
            dealer.RemoveAllCards();

            winner = null;
            activePlayer = player;

            InitLayout();
        }



        public void ActivePlayerStep()
        {
            if (winner == null)
            {
                do
                {
                    ActivePlayer.AddCard(deck.GetCard());
                    if (ActivePlayer.Score >= 21)
                        break;
                }
                while ((!ActivePlayer.IsDealer && ActivePlayer.Score <17) || 
                        (ActivePlayer.IsDealer && (ActivePlayer.Score > player.Score || ActivePlayer.Score>=21))
                        );

                if (ActivePlayer.Score == 21)
                {
                    winner = ActivePlayer;
                }
                else if (ActivePlayer.Score > 21)
                {
                    if (ActivePlayer.IsDealer)
                    {
                        // we search winner among other players
                        winner = player;
                    }
                    else
                    {
                        winner = dealer;
                    }
                }
            }

            GetStatus();
        }

        public void ChangePlayer()
        {
            if (activePlayer == player)
                activePlayer = dealer;
            else
                activePlayer = player;
        }


        //protected
        protected virtual void GetStatus()
        {
            Debug.WriteLine("-----------------------");
            Debug.WriteLine($"Cards in Deck: {deck.Count}");
            foreach (var player in players)
            {
                Debug.WriteLine($"Player {player.Name}, current score {player.Score}");
                Debug.WriteLine("Cards");
                foreach (var card in player.Cards)
                {
                    Debug.Write($"{card.Description} ");
                }
                Debug.WriteLine("");
            }

            Debug.WriteLine($"Current player {ActivePlayer.Name}");

            if (winner != null)
            {
                Debug.WriteLine($"Game Winner {winner.Name}");
            }
            
        }


    }
}
