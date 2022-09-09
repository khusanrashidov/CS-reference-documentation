using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = {1,2,3,4};
            int[] sales = {100000, 150000, 200000, 225000};
            double[] intlMixPct = {.386, .413, .421, .457};
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting information
            Console.WriteLine("{0}", str1);

            // Specifying Numerical formatting
            // General format is {index[,alignment]:[format]}
            // Common types are N (Number), G (General), F (Fixed-point), 
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
            // C (Currency in local format)
            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

            // Add a number after the format to specify precision
            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

            // Formatting with alignment and spacing
            Console.WriteLine("Sales by Quarter:");
            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",quarters[0],quarters[1],quarters[2],quarters[3]);
            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",sales[0],sales[1],sales[2],sales[3]);
            Console.WriteLine("International Sales:");
            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",intlMixPct[0],intlMixPct[1],intlMixPct[2],intlMixPct[3]);
        }
    }
}
