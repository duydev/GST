using System;

namespace Assignment04
{
    class Bees
    {
        private Bee[] bees;

        public void clear()
        {
            bees = new Bee[30];
        }

        public void displayInfo()
        {
            string output = "";
            if( bees == null )
            {
                output = "Empty Bees List. Plese Create Bee List Before!";
            } else
            {
                for (int i = 0; i < 30; i++)
                {
                    output += "- Info of Bee " + (i + 1) + Environment.NewLine;
                    output += bees[i].ToString();
                    output += Environment.NewLine;
                }
            }
            Console.WriteLine(output);
        }

        public void createBeeList()
        {
            clear();
            for (int i = 0; i < 30; i++)
            {
                if (i < 10)
                {
                    bees[i] = new BeeWorker();
                    continue;
                }
                else if (i < 20)
                {
                    bees[i] = new BeeQueen();
                    continue;
                }
                else
                {
                    bees[i] = new BeeDrone();
                }
            }
            displayInfo();
        }

        public void attackBees()
        {
            Random random = new Random();
            for(int i = 0; i < 30; i++)
            {
                bees[i].damage(random.Next(0, 80));
            }
            displayInfo();
        }

    }
}
