using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // Output information using formatting
            Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}",
                year, make, model, miles, price);

            // Using string interpolation
            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles} miles and costs {price:C2}");

            // With inline expressions
            Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles *1.6:F2} kilometers and costs {price:C2}");
        }
    }
}
