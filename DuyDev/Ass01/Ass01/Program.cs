using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass01
{
    class Program
    {
        public static int readInt()
        {
            int output;
            string input = "";
            while(!Int32.TryParse(input, out output))
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public static void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("/**************/");
            Console.WriteLine("/*   Stack    */");
            Console.WriteLine("/**************/");
            Console.WriteLine();
            Console.WriteLine("------------Function--------------");
            Console.WriteLine();
            Console.WriteLine("1. Print Stack.");
            Console.WriteLine("2. Push Stack.");
            Console.WriteLine("3. Pop Stack.");
            Console.WriteLine("4. Get Stack.");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("Choose: ");
        }

        public static void printStack(MyStack stack)
        {
            Console.WriteLine();
            Console.WriteLine("Stack Values:");
            if ( stack.stackValues.Count == 0 )
            {
                Console.Write("Stack empty!");
            } else
            {
                foreach( int v in stack.stackValues )
                {
                    Console.Write(v.ToString() + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int choose = -1;
            MyStack stack = new MyStack();
            int val;
            int? _val;
            while( choose != 0 )
            {
                drawMenu();
                choose = readInt();
                Console.WriteLine();
                Console.WriteLine("------------Output--------------");
                Console.WriteLine();
                switch(choose)
                {
                    // Exit app
                    case 0:                        
                        break;
                    // Print Stack
                    case 1:
                        printStack( stack );
                        break;
                    // Push Stack
                    case 2:
                        val = readInt();
                        stack.Push(val);
                        printStack(stack);
                        break;
                    // Pop Stack
                    case 3:
                        _val = stack.Pop();
                        if( _val != null )
                        {
                            Console.Write("Value: " + _val.ToString() );
                        } else
                        {
                            Console.WriteLine("Can not get element from empty stack!");
                        }
                        printStack(stack);
                        break;
                    // Get Stack
                    case 4:
                        _val = stack.Get();
                        if (_val != null)
                        {
                            Console.Write("Value: " + _val.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Can not get element from empty stack!");
                        }
                        printStack(stack);
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
