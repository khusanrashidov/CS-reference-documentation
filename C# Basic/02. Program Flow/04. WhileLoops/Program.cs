using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            // basic while loop executes while the gate condition is true
            Console.WriteLine("Basic while() loop:");
            while (inputStr != "exit") {
                inputStr = Console.ReadLine();

                Console.WriteLine("You entered: {0}", inputStr);
            }
            Console.WriteLine();

            // the do-while loop always executes at least one time
            Console.WriteLine("The  do-while() loop:");
            do {
                inputStr = Console.ReadLine();

                Console.WriteLine("You entered: {0}", inputStr);
            } while (inputStr != "exit");
            Console.WriteLine();
        }
    }
}
