using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "PowerHero";
            int age = 33;
            string power1 = "fast runner";
            string power2 = "good swimmer";
            string power3 = "strong body";

            Console.WriteLine("********************");
            Console.WriteLine($"Hero: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Superpowers: {power1}, {power2}, {power3}");
            Console.WriteLine("********************");

            Console.WriteLine("***************FINANCIAL INFO******************");

            int deedTimeInHours1 = 10;
            int deedTimeInHours2 = 20;
            int deedTimeInHours3 = 30;

            int result = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3; // - Total time spent on deeds
            Console.WriteLine($"Total time spend on deed: {result}");

            int result2 = result / 3; // - Average time spent on one deed
            Console.WriteLine($"Average time spend on deed: {result2}");

            double salary = 2000; //monthly
            double cookieCost = 2;
            double hour = 24;
            bool isEvil = false;

            double dailySalary = Math.Round(salary / 30, 2); //-- monthlySalary
            Console.WriteLine($"Hero earns daily {dailySalary}");

            double boughtCookies = Math.Floor(salary / cookieCost); //-- Add boughtCookies calculation
            double gotCookiesPerHour = boughtCookies / hour; //- How many cookies Hero will get. 5 cookies per hour
            Console.WriteLine($"The hero gets {gotCookiesPerHour} cookies per hour");
            

            if (!isEvil) 
            {
                Console.WriteLine("Wins and gets salary");
            }
            else
            {
                Console.WriteLine("Looses and doesn't get salary");
            }

            //--isEvil or not



 
        }
    }
}
