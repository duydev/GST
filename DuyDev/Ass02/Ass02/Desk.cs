using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    class Desk
    {
        Player[] players;
        Card[] cards;

        public Desk()
        {
            int i;
            // Init Players
            players = new Player[4];
            // Set name for four players
            for(i = 0; i < players.Length; i++)
            {
                players[i] = new Player
                {
                    playerName = "Player " + (i + 1).ToString(),
                    playerCards = new List<Card>()
                };
            }
            // Init Cars
            cards = new Card[52];
            i = 0;
            foreach( Card.Suit suit in Enum.GetValues( typeof( Card.Suit ) ) )
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    cards[i] = new Card
                    {
                        suit = suit,
                        rank = rank
                    };
                    i++;
                }
            }
        }

        // Shuffle Cards 
        public void shuffleCard()
        {
            Random random = new Random();
            int i = 52;
            while( i > 1 )
            {
                i--;
                int newPos = random.Next( i + 1 );
                Card card = cards[newPos];
                cards[newPos] = cards[i];
                cards[i] = card;
            }
            // Remove All Card
            for(i = 0; i < 4; i++)
            {
                players[i].playerCards.Clear();
            }

            for (i = 0; i < 52; i+=4)
            {
                players[0].playerCards.Add(cards[i]);
                players[1].playerCards.Add(cards[i+1]);
                players[2].playerCards.Add(cards[i+2]);
                players[3].playerCards.Add(cards[i+3]);
            }
            Console.WriteLine("Shuffle Done!");
        }


        public void showCard()
        {
            if( players[0].playerCards.Count == 0 ) {
                Console.WriteLine("Please shuffle cards before!");
                return;
            }
            foreach( Player player in players )
            {
                Console.WriteLine("Cards of " + player.playerName + ":");
                player.showCard();
            }
        }

    }
}
