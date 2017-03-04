using System;
using System.Collections.Generic;

namespace Ass02
{
    class Desk
    {
        public Player[] players;
        public Card[] cards;

        public Desk()
        {
            // Init
            int i;
            players = new Player[4];
            for( i = 0; i < players.Length; i++ )
            {
                players[i] = new Player
                {
                    name = "Player " + (i + 1),
                    cards = new List<Card>()
                };
            }
            cards = new Card[52];
            i = 0;
            foreach( string rank in Card.Ranks )
            {
                foreach( string suit in Card.Suits )
                {
                    cards[i] = new Card
                    {
                        rank = rank,
                        suit = suit
                    };
                    i++;
                }
            }
        }

        public void shuffleCards()
        {
            int i = 52;
            Random random = new Random();
            while (i > 1)
            {
                i--;
                int newPos = random.Next(i + 1);
                Card card = cards[newPos];
                cards[newPos] = cards[i];
                cards[i] = card;
            }
            // Remove All Card
            for (i = 0; i < 4; i++)
            {
                players[i].cards.Clear();
            }

            for (i = 0; i < 52; i += 4)
            {
                players[0].cards.Add(cards[i]);
                players[1].cards.Add(cards[i + 1]);
                players[2].cards.Add(cards[i + 2]);
                players[3].cards.Add(cards[i + 3]);
            }
            Console.WriteLine("Shuffle Done!");
        }

        public void showCards()
        {
            foreach ( Player player in players )
            {
                player.showCards();
            }
        }

    }
}
