namespace SumofEvenAndOddNumber
{
    /* Ratio of the sum of even numbers and odd numbers in the list*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0, sumOdd = 0;
            float result;
           
            List<int> list = new List<int>{ 1, 2, 3, 7, 10, 15, 17, 28, 31, 36, 41, 48, 50, 53, 56, 61, 65, 66, 70,81 };

            foreach (var item in list)
            {
                if (item%2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }
               

            }
            Console.WriteLine("Sum of Even: "+sumEven+ " Sum of Odd: "+sumOdd);
            result = sumEven / sumOdd;
            Console.WriteLine("Ratio is: " + result);
        }
    }
}
