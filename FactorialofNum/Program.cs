
using System.Diagnostics.Contracts;

namespace FactorialofNum
{/*Finding the factorial of the entered number*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int fac = 1, num;
            Console.Write("Enter a number :");
            num=Convert.ToInt32(Console.ReadLine());

            for (int i = num; i > 1; i--) {
                fac = fac * i;
               
            }
            Console.WriteLine("Factorial:" + fac);
        }
    }
}
