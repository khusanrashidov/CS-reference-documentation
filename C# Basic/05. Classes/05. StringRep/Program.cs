using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // Every class in C# inherits from Object, which means
            // that every class inherits the ToString() method
            int x = 1000;
            Console.WriteLine(x.ToString());

            // if you don't override the method, the default behavior just prints
            // the name of the class and the namespace
            object a = new object();
            Console.WriteLine(a.ToString());

            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1);
            
            Console.WriteLine(b1.ToString('B'));
            Console.WriteLine(b1.ToString('F'));
        }
    }
}
