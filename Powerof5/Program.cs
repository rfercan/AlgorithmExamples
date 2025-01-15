using System;

namespace Powerof5
{
    internal class Program
    {
        static void Main(string[] args)
        {/*find power of 5*/
            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine(number + " is not positive.");
                return;
            }

            while (number > 1)
            {
                if (number % 5 != 0)
                {
                    Console.WriteLine("The number is not a power of 5.");
                    return;
                }
                number /= 5;
            }

            Console.WriteLine("The number is a power of 5.");
        }
    }
}
