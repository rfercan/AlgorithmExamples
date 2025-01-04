namespace ExtractInsteadofDivide
{/*Finding division using subtraction*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num1,num2;

            Console.Write("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 =Convert.ToInt32(Console.ReadLine());

            for ( i = 1; num1 > num2; i++)
            {
                num1 = num1 - num2;
            }
            Console.WriteLine("Result :" + i);
        }
    }
}
