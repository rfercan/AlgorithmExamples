using System.ComponentModel;

namespace CalculateAgeofPerson
{/*Calculating the age of the person*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYear, birthYear, age;

            Console.Write("Enter year of birth :");
            birthYear = Convert.ToInt32(Console.ReadLine());

            currentYear = DateTime.Now.Year;
            age = currentYear - birthYear;
            Console.WriteLine("Age :" +age);

           

        }
    }
}
