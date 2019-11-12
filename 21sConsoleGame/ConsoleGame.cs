using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21sConsoleGame
{
    public class ConsoleGame :_21s.Game
    {
        public static Card[] GameCards = new Card[]{
            new Card("♠2",2),new Card("♠3",3),new Card("♠4",4),new Card("♠5",5),new Card("♠6",6),
            new Card("♠7",7),new Card("♠8",8),new Card("♠9",9),new Card("♠10",10),
            new Card("♠Jack",10), new Card("♠Queen",10),new Card("♠King",10),new Card("♠Ace",11),
            new Card("♠2",2),new Card("♠3",3),new Card("♠4",4),new Card("♠5",5),new Card("♠6",6),
            new Card("♠7",7),new Card("♠8",8),new Card("♠9",9),new Card("♠10",10),
            new Card("♠Jack",10), new Card("♠Queen",10),new Card("♠King",10),new Card("♠Ace",10),
            new Card("♥2",2),new Card("♥3",3),new Card("♥4",4),new Card("♥5",5),new Card("♥6",6),
            new Card("♥7",7),new Card("♥8",8),new Card("♥9",9),new Card("♥10",10),
            new Card("♥Jack",10), new Card("♥Queen",10),new Card("♥King",10),new Card("♥Ace",10),
            new Card("♦2",2),new Card("♦3",3),new Card("♦4",4),new Card("♦5",5),new Card("♦6",6),
            new Card("♦7",7),new Card("♦8",8),new Card("♦9",9),new Card("♦10",10),
            new Card("♦Jack",10), new Card("♦Queen",10),new Card("♦King",10),new Card("♦Ace",10)
          };

        public ConsoleGame(Player _player, Player _dealer): base(_player, _dealer, GameCards) { }

        protected override void GetStatus()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Cards in Deck: {Deck.Count}");
            Console.WriteLine($"Player {Player.Name}, current score {Player.Score}");
            Console.WriteLine("Cards");
            foreach (var card in Player.Cards)
            {
                Console.Write($"{card.Description} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Dealer {Player.Name}, current score {Dealer.Score}");
            Console.WriteLine("Cards");
            foreach (var card in Dealer.Cards)
            {
                Console.Write($"{card.Description} ");
            }
            Console.WriteLine("");



            Console.WriteLine($"Current player {ActivePlayer.Name}");

            if (Winner != null)
            {
                Console.WriteLine($"Game Winner {Winner.Name}");
            }

        }

    }
}
