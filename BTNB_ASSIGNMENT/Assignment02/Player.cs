using System;
using System.Collections.Generic;

namespace Assignment02
{
    class Player
    {
        public string name;
        public List<Card> cards;

        public void showCards()
        {
            Console.WriteLine("Card of " + name);
            foreach( Card card in cards )
            {
                card.printCard();
            }
            Console.WriteLine();
        }
    }
}
