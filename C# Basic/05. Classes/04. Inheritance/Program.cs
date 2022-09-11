using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some publications
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, 39.95m);
            Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

            Console.WriteLine($"{b1.Name}, {b1.Author}");
            Console.WriteLine($"{m1.Name}, {m1.Publisher}");

            // Property validation logic will prevent an empty name
            // b1.Name = "";

            // Call the override functions
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescription());
            Console.WriteLine(m1.Price);
        }
    }
}
