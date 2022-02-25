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
        }
    }
}
