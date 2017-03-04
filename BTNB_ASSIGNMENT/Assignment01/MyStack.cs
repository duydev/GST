using System;
using System.Linq;

namespace Ass01
{
    class MyStack<T> where T : struct
    {
        protected T[] stackValues;

        public void Push( T value )
        {
            // If stack is null
            if( stackValues == null )
            {
                stackValues = new T[1];
                stackValues[0] = value;
            }
            else // Or has Items
            {
                int numElement = stackValues.Length;
                T[] temp = new T[numElement + 1];
                Array.Copy(stackValues, temp, numElement);
                temp[numElement] = value;
                stackValues = temp;
            }
        }

        public T? Pop() 
        {
            T? value = null;
            // If stack has Items
            if( stackValues != null )
            {
                int numElement = stackValues.Length - 1;
                value = stackValues[numElement];
                if( numElement == 0 )
                {
                    stackValues = null;
                }
                else
                {
                    T[] temp = new T[numElement];
                    Array.Copy(stackValues, temp, numElement);
                    stackValues = temp;
                }

            }
            return value;
        }

        public T? Get()
        {
            T? value = null;
            // If stack has Items
            if (stackValues != null)
            {
                value = stackValues.Last();
            }
            return value;
        }
    }
}
