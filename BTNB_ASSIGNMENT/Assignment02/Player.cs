using System;
using System.Collections.Generic;

namespace Ass02
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
