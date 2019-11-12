using _21s;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _21sConsoleGame
{
    class Program
    {
 
        private const string HelpString = "Use next Keys:\n" +
                "\tq - quit the game\n" +
                "\tn - new game\n" +
                "\tm - more cards\n" +
                "\td - dealer step\n";


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var game = new ConsoleGame(new Player("Sam"), new Player("Dealer", true));

            Console.WriteLine("Let's start the game\n " + HelpString
                );

            var c = Console.ReadKey(); Console.WriteLine();
            
            do
            {
                switch (c.KeyChar)
                {
                    case 'n':
                        {
                            game.NewGame();
                        }
                        break;
                    case 'm':
                        {
                            game.ActivePlayerStep();
                        }
                        break;
                    case 'q':
                        {
                            return;
                        }
                    case 'd':
                        {
                            game.ChangePlayer();
                            game.ActivePlayerStep();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine(HelpString);
                        }
                        break;
                }
                c = Console.ReadKey(); Console.WriteLine();
            }
            while ((c.KeyChar != 'q'));


        }
    }
}
