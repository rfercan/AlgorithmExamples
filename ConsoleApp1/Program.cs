namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, bas, top;

            Console.Write("sayi gir");
            sayi = Convert.ToInt32(Console.ReadLine());

            bas = sayi % 10;
            top = bas * bas * bas;

            if (top == sayi)
            {
                Console.WriteLine("eşit");

            }
            else
            {
                Console.WriteLine("eşit değil");
            }









            }
    }
}
