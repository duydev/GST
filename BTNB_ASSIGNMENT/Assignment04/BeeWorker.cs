using System;

namespace Assignment04
{
    class BeeWorker : Bee
    {
        public BeeWorker()
        {
            minHealth = 70F;
        }

        public override string ToString()
        {
            string output = "";
            output += "Type: Worker" + Environment.NewLine;
            output += base.ToString();
            return output;
        }

    }
}
