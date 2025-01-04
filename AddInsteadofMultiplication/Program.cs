namespace AddInsteadofMultiplication
{
    internal class Program
    {/*Finding multiplication using addition*/
        static void Main(string[] args)
        {
            int result = 0, num1, num2;
            Console.Write("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = num1; num1 > 0; num1--)
            //{
            //    result = result + num2;
            //}

            while (num1 > 0)
            {
                result = result + num2;
                num1 -= 1;
            }


            Console.WriteLine("Result: "+result);
        }
    }
}
