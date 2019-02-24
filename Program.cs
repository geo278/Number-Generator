using System;

namespace numberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            generateRandomNumber();
        }

        static void generateRandomNumber() {
            long time01 = DateTime.Now.Ticks;
            ulong time1 = (ulong) time01;

            Console.WriteLine("Please enter lower bound.");
            string lower = Console.ReadLine();
            int lower0 = Convert.ToInt32(lower);
            Console.WriteLine("Please enter upper bound.");
            string upper = Console.ReadLine();
            int upper0 = Convert.ToInt32(upper);
            Console.WriteLine("Generating value . . .");

            long time02 = DateTime.Now.Ticks;
            ulong time2 = (ulong) time02;

            if (lower0 < upper0) {
                ulong timeDifference = (time2 - time1)*(time2 - time1);
                ulong boundaryDifference = (ulong) upper0 - (ulong) lower0;
                long output = (long) lower0 + (long)timeDifference % (long)boundaryDifference;

                Console.WriteLine("The result is: " + output);

            } else if (lower0 == upper0) {
                Console.WriteLine(lower0);
            } else {
                Console.WriteLine("The lower boundary must be smaller than or equal to the upper boundary.");
                generateRandomNumber();
            }
        }
    }
}
