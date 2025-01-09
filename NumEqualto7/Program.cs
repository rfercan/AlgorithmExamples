namespace NumEqualto7
{
    internal class Program
    {/* finding the sum of negative numbers,
 the product of even numbers and the piece of numbers equal to 7*/
        static void Main(string[] args)
        {
            int num, negative = 0, even = 1, equal = 0;

            for (int i = 0; i < 25; i++)
            {

                Console.Write("enter num : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                    even *= num;

                else if (num < 0)
                    negative += num;

                else if (num == 7)
                    equal++;
            }
            Console.WriteLine("Even : "+even+ " "+"Negative : "+negative+ " "+"Equal: "+equal);
        }
    }
}
