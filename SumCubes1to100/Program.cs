namespace SumCubes1to100
{
    /*Finding the sum of the cubes of numbers from 1 to 100*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
              
            for ( int num = 1; num <= 101; num++)
            {
               
                    sum += (num * num * num);
              
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
