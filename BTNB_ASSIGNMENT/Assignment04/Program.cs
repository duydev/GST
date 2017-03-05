using System;

namespace Assignment04
{
    class Program
    {
        public int readInt()
        {
            int output;
            // Read number as string in stdin
            string input = "";
            while (!Int32.TryParse(input, out output))
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("/* BEE */");
            Console.WriteLine("Function:");
            Console.WriteLine("1. Create bee list");
            Console.WriteLine("2. Attack bees");
            Console.WriteLine("0. Exit");
        }

        static void Main(string[] args)
        {
            // Init App
            Program app = new Program();
            Bees bees = new Bees();
            int choose = -1;
            int? value;
            while (choose != 0)
            {
                app.drawMenu();
                choose = app.readInt();
                switch (choose)
                {
                    case 0:
                        // Exit
                        Console.WriteLine("Goodbye!");
                        break;
                    case 1:
                        // Create Bee Lists
                        bees.createBeeList();
                        break;
                    case 2:
                        // Attack Bees
                        bees.attackBees();
                        break;
                    default:
                        Console.WriteLine("Wrong function number. Please choose it again!");
                        break;
                }
                Console.WriteLine("Please press any key to continue!");
                Console.ReadKey();
            }
        }
    }
}
