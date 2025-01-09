namespace SquareofNumsBetween10to100
{
    internal class Program
    { /*Finding perfect square numbers between 10 and 1000*/
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if ((i * i) > 10 && (i * i) <= 1000)
            //    {
            //        Console.WriteLine(Math.Pow(i, 2));
            //    }

            //}
            //Console.ReadLine();

            for (int i = 4; (i * i) <= 1000; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
    }
}
