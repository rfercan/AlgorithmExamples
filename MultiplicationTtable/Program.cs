namespace MultiplicationTtable
{
    internal class Program
    {/*printing the multiplication table*/
        static void Main(string[] args)
        {
            int i, j, result;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (j = 1; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine(i + " * " + j + " = " + result);
                }
            }
                
               
            Console.ReadLine();
        }
    }
}
