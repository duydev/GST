using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    class Card
    {
        public enum Suit { Clubs, Diamonds, Hearts, Spades };
        public enum Rank { Ace, Duece, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

        public Suit suit;

        public Rank rank;

        public void printCard()
        {
            string output = "";
            // Switch Suilt
            switch( suit )
            {
                case Suit.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    output += "♥";
                    break;
                case Suit.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    output += "♦";
                    break;
                case Suit.Spades:
                    output += "♣";
                    break;
                case Suit.Clubs:
                    output += "♠";
                    break;
            } 
            switch( rank )
            {
                case Rank.Ace:
                    output += "A";
                    break;
                case Rank.Duece:
                    output += "2";
                    break;
                case Rank.Three:
                    output += "3";
                    break;
                case Rank.Four:
                    output += "4";
                    break;
                case Rank.Five:
                    output += "5";
                    break;
                case Rank.Six:
                    output += "6";
                    break;
                case Rank.Seven:
                    output += "7";
                    break;
                case Rank.Eight:
                    output += "8";
                    break;
                case Rank.Nine:
                    output += "9";
                    break;
                case Rank.Ten:
                    output += "10";
                    break;
                case Rank.Jack:
                    output += "J";
                    break;
                case Rank.Queen:
                    output += "Q";
                    break;
                case Rank.King:
                    output += "K";
                    break;
            }
            Console.Write( output );
            Console.ResetColor();
        }
    }
}
