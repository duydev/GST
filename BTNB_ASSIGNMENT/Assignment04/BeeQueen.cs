using System;

namespace Assignment04
{
    class BeeQueen : Bee
    {

        public BeeQueen()
        {
            minHealth = 20F;
        }

        public override string ToString()
        {
            string output = "";
            output += "Type: Queen" + Environment.NewLine;
            output += base.ToString();
            return output;
        }

    }
}
