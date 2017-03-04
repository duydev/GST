using System;

namespace Ass02
{
    class Card
    {
        public static string[] Suits = { "♥", "♦", "♣", "♠" };
        public static string[] Ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public string rank;
        public string suit;

        public void printCard()
        {
            if( suit == "♥" || suit == "♦")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" " + rank + suit);
                Console.ResetColor();
            } else
            {
                Console.Write(" " + rank + suit);
            }
        }

    }
}
