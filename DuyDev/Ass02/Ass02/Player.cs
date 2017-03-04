using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    class Player
    {
        public string playerName;

        public List<Card> playerCards;
        
        public void showCard()
        {
            foreach( Card card in playerCards )
            {
                card.printCard();
                Console.Write(" ");
            }
            Console.WriteLine();
        } 
    }
}
