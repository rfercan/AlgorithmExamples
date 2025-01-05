namespace HowManyDigitstoNum
{/*Finding how many digits the entered number*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result= 1;
            Console.Write("Enter a num: ");
            num=Convert.ToInt32(Console.ReadLine());

            //for (int i = result; num >= 9; result++)
            //{
            //    num = num / 10;

            //}

            while (num >= 9) {

                num = num / 10;
                result++;
            }
                  
            
            
            Console.WriteLine(result);
          
        }
    }
}
