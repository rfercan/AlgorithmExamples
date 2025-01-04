namespace Mod2Nums
{/*Finding the mode of the entered numbers*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num1 >= num2)
            {
                // num1 = num1 - num2;
                num1 = num1 % num2;
            }

            //for (int i = 0; num1 >= num2; i++) 
            //{
            //       // num1 = num1 - num2;
            //        num1 = num1 % num2;
            //}


            Console.WriteLine("Result: "+num1);
        }
    }
}
