using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass01
{
    class MyStack
    {
        public List<int> stackValues;

        public MyStack()
        {
            stackValues = new List<int>();
        }

        public void Push(int value)
        {
            stackValues.Add(value);
        }

        public int? Pop()
        {
            // Check stack is null or not
            if (stackValues.Count == 0)
            {
                return null;
            }
            int value = stackValues.Last();
            stackValues.RemoveAt(stackValues.Count - 1);
            return value;
        }

        public int? Get()
        {
            // Check stack is null or not
            if( stackValues.Count == 0 )
            {
                return null; 
            }
            // Get the last element
            return stackValues.Last();
        }
    }
}
