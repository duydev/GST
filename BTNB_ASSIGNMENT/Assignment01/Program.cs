using System;

namespace Assignment01
{
    class Program
    {

        public int readInt()
        {
            int output;
            // Read number as string in stdin
            string input = "";
            while( !Int32.TryParse( input, out output ) )
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public void drawMenu()
        {
            Console.Clear();
            Console.WriteLine("/* STACK */");
            Console.WriteLine("Function:");
            Console.WriteLine("1. Print Stack");
            Console.WriteLine("2. Push");
            Console.WriteLine("3. Pop");
            Console.WriteLine("4. Get");
            Console.WriteLine("0. Exit");
        }

        public void printStack(MyStack<int> myStack)
        {

            Console.WriteLine( myStack.ToString() );
        }


        static void Main(string[] args)
        {
            // Init App
            Program app = new Program();
            MyStack<int> myStack = new MyStack<int>();
            int choose = -1;
            int? value;
            while( choose != 0 )
            {
                app.drawMenu();
                choose = app.readInt();
                switch( choose )
                {
                    case 0:
                        // Exit
                        Console.WriteLine("Goodbye!");
                        break;
                    case 1:
                        // Print Stack
                        app.printStack(myStack);
                        break;
                    case 2:
                        // Push
                        myStack.Push( app.readInt() );
                        app.printStack(myStack);
                        break;
                    case 3:
                        // Pop
                        value = myStack.Pop();
                        if( value != null )
                        {
                            Console.WriteLine("Value: " + value);
                        }
                        app.printStack(myStack);
                        break;
                    case 4:
                        // Get
                        value = myStack.Get();
                        if (value != null)
                        {
                            Console.WriteLine("Value: " + value);
                        }
                        app.printStack(myStack);
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
