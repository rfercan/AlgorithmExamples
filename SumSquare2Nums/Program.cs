namespace SumSquare2Nums
{ /*Finding the sum of the square of two numbers */
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum,num1,num2;
            Console.Write("Enter num1: " );
            num1=Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter num2: ");
            num2=Convert.ToInt32( Console.ReadLine() ) ;

            sum = (num1*num1) + (num2*num2);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
