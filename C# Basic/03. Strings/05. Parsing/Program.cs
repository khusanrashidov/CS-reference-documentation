using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            // The Parse function attempts to parse a string into a number
            // but it might throw an exception, so we need to catch that
            int targetNum;
            try {
                // Use Parse to try a simple integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine($"{targetNum}");

                // Use Parse to try a floating point number
                // This only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"{targetNum}");

                // Use Parse to try a number with thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine($"{targetNum}");

                // Use Parse to try a number with thousands marker AND decimal
                targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
                Console.WriteLine($"{targetNum}");

                // This works with other types too, like bool
                Console.WriteLine($"{bool.Parse("True")}");

                // Or floating point numbers
                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }
            catch {
                Console.Write("Conversion failed");
            }

            // The TryParse function is similar but handles the exceptions for us
            bool succeeded = false;
            succeeded = Int32.TryParse(numStr1, out targetNum);
            if (succeeded) {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
