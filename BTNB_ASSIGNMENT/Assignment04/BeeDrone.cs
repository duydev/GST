using System;

namespace Assignment04
{
    class BeeDrone : Bee
    {
        public BeeDrone()
        {
            minHealth = 50F;
        }

        public override string ToString()
        {
            string output = "";
            output += "Type: Drone" + Environment.NewLine;
            output += base.ToString();
            return output;
        }

    }
}
