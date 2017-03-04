using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    class Program
    {
        public static int readInt()
        {
            int output;
            string input = "";
            while (!Int32.TryParse(input, out output))
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public static void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("/*******************/");
            Console.WriteLine("/*   Play Cards    */");
            Console.WriteLine("/*******************/");
            Console.WriteLine();
            Console.WriteLine("------------Function--------------");
            Console.WriteLine();
            Console.WriteLine("1. Shuffle Cards.");
            //Console.WriteLine("2. Show Cards.");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("Choose: ");
        }

        static void Main(string[] args)
        {
            int choose = -1;
            Desk desk = new Desk();
            int val;
            int? _val;
            while (choose != 0)
            {
                drawMenu();
                choose = readInt();
                Console.WriteLine();
                Console.WriteLine("------------Output--------------");
                Console.WriteLine();
                switch (choose)
                {
                    // Exit app
                    case 0:
                        break;
                    // Shuffer Cards
                    case 1:
                        desk.shuffleCard();
                        desk.showCard();
                        break;
                    // Show Cards
                    case 2:
                        desk.showCard();
                        break;
                    default:
                        Console.WriteLine("Wrong function number.");
                        break;
                }
                Console.Write("Please press any key to continue!");
                Console.ReadKey();
            }
        }
    }
}
