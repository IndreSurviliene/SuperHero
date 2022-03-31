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
            
            Hero Powerhero = new Hero("John", "Smith", "Powerhero", 1111, HeroType.Hero, 10);
            Hero Spiderman = new Hero("Ben", "Snow", "Spiderman", 2222, HeroType.Hero, 15);
            Hero Batman = new Hero("Will", "White", "Batman", 3333, HeroType.Villain, 20);
            Hero Superwoman = new Hero("Ann", "Rose", "Superwoman", 4444, HeroType.Hero, 25);

            Powerhero.PrintInfo();
            Spiderman.PrintInfo();
            Batman.PrintInfo();
            Superwoman.PrintInfo();

            List<Hero> listOfHeroes = new List<Hero>();
            listOfHeroes.Add(Powerhero);
            listOfHeroes.Add(Spiderman);
            listOfHeroes.Add(Batman);  
            listOfHeroes.Add(Superwoman);

            District antakalnis = new District ("Antakalnis", "Vilnius", 01, listOfHeroes);

            /*for (int i = 0; i < metropole.Count; i++)
            {
                Console.WriteLine(metropole[i].Nickname);
            }*/
            
            //metropole.RemoveAt(0);

            var foundHero = listOfHeroes.Find(find => find.Name == "John");
            Console.WriteLine($"We found {foundHero.Name}");
            foundHero.PrintInfo(); //Prints all info about John

            //var foundHero2 = metropole.Find(find => find.CalculatedLevel == 1); //doesn't work


            string[] superHeroNameList = { "Powerhero", "Spiderman", "Batman", "Superwoman" };
            string[] superHeroAgeList = { "33", "27", "45", "23" };
            string[] superHeroPowerList = { "Good swimmer, fast runner, strong body", "Good climber, not affraid of height, jumps well", "Flies high, fast, furious", "Knows everything, does everything, can code" };


            double[,] deedTimeInHours2D = { { 10, 20, 30 }, { 15, 25, 35 }, {20, 30, 40 }, {25, 35, 45} };
            double[] deedTimeInHoursList = new double[superHeroNameList.Length];
            double[] averageDeedTimeList = new double[superHeroNameList.Length];

            for (int d = 0; d < superHeroNameList.Length; d++)
            {
               deedTimeInHoursList[d] = deedTimeInHours2D[d, 0] + deedTimeInHours2D[d, 1] + deedTimeInHours2D[d, 2];
               averageDeedTimeList[d] = deedTimeInHoursList[d] / 3;
            }

            double[] salary = { 2000, 3000, 4000, 5000 };
            double[] dailySalaryList = new double[superHeroNameList.Length];
        
            for (int s = 0; s < salary.Length; s++) 
            {
                dailySalaryList[s] = Math.Round(salary[s] / 30, 2);
            }

            double cookies = 2;
            double hour = 24;

            double[] boughtCookiesList = new double[superHeroNameList.Length];
            double[] gotCookiesPerHourList = new double[superHeroNameList.Length];

            for (int c = 0; c < salary.Length; c++)
            {
                boughtCookiesList[c] = Math.Floor(salary[c] / cookies);
                gotCookiesPerHourList[c] = Math.Floor(boughtCookiesList[c] / hour);
            }
 

            bool isMenuRunning = true;
            do
            {
                string menuItems;

                Console.WriteLine($"Welcome to the superhero application!");
                Console.WriteLine($"Select what to do:");
                Console.WriteLine($"1 - Show a list of superheroes");
                Console.WriteLine($"2 - Show specific hero");
                Console.WriteLine($"3 - Adding a superhero");
                Console.WriteLine($"4 - Deleting a superhero");
                Console.WriteLine($"5 - OOP hero");
                Console.WriteLine($"6 - Exit");
                Console.WriteLine($"7 - Information about district");

                menuItems = Console.ReadLine();

                switch (menuItems)
                {
                    case "1":
                        Console.WriteLine("============List=of=superheroes============");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        Console.WriteLine("===========================================");
                        break;

                    case "2":
                        Console.WriteLine($"Please choose a superhero by number");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        Console.WriteLine($"You have chosen {superHeroNameList[chosenNumber]}");

                        Console.WriteLine("Choose what type of info to show");
                        Console.WriteLine($"1 - GENERAL INFO");
                        Console.WriteLine($"2 - FINANCIAL INFO");
                        string showMenu = Console.ReadLine();


                        if (showMenu == "1")
                        {
                            Console.WriteLine("*************GENERAL INFO********************");
                            Console.WriteLine($"Hero: {superHeroNameList[chosenNumber]}");
                            Console.WriteLine($"Age: {superHeroAgeList[chosenNumber]}");
                            Console.WriteLine($"Superpowers: {superHeroPowerList[chosenNumber]}");
                            Console.WriteLine("********************************** \n \n");
                        }
                        else if (showMenu == "2")
                        {
                            Console.WriteLine("**************FINANCIAL INFO*****************");

                            Console.WriteLine($"Time spent on deeds: {deedTimeInHoursList[chosenNumber]}");
                            Console.WriteLine($"Average time spend on deed: { averageDeedTimeList[chosenNumber]} hours");
                            Console.WriteLine($"Hero earns daily: {dailySalaryList[chosenNumber]} Eur");
                            Console.WriteLine($"The hero gets {boughtCookiesList[chosenNumber]} cookies");
                            Console.WriteLine($"The hero gets {gotCookiesPerHourList[chosenNumber]} cookies per hour \n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("What is the new superhero name?");
                        string superHeroName = Console.ReadLine();
                        superHeroNameList = superHeroNameList.Append(superHeroName);
                        Console.WriteLine($"SuperHero {superHeroName} Added!");
                        break;
                case "4":
                        Console.WriteLine($"Select a hero you want to delete");
                        
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }

                        int.TryParse(Console.ReadLine(), out int chosenNumber2);
                        superHeroNameList = superHeroNameList.Remove(chosenNumber2);
                        Console.WriteLine($"You have deleted {chosenNumber2} hero");
                        break; 
                case "5": 
                        //Console.WriteLine($"{hero.Name} level is {hero.CalculatedLevel()}");

                        foreach (Hero hero in listOfHeroes)
                        {
                            if (hero.CalculatedLevel() > 1)
                            {
                                Console.WriteLine($"{hero.Nickname} is higher than level 1");
                            }
                            Console.WriteLine($"The average of level of heroes inside {antakalnis.Title} is: {antakalnis.CalculateAvgLevelInDistrict()}");  
                        }
                        break; 
                    case "6":
                        isMenuRunning = false;
                        Console.WriteLine($"Good bye!");
                        break;
                    case "7":
                        antakalnis.PrintInformationAboutDistrict();
                        break;
                    default:
                    Console.WriteLine($"Please choose from the available menu");
                    break;
            }
            } 
            while (isMenuRunning);

            
            bool isEvil = false;
            if (!isEvil) 
            {
                Console.WriteLine("The Hero is not evel and gets his salary");
            }
            else
            {
                Console.WriteLine("The hero is evel and doesn't get his salary");
            }

           

            char deedGrade = 'A';
            Console.WriteLine("Enter a letter from A to H");
            string charString = Console.ReadLine();

            switch (deedGrade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! You are so brave");
                    break;
                case 'C':
                    Console.WriteLine("Good, but you can do better");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! You should choose your bad or good side!");
                    break;
                case 'F':
                case 'G':
                    Console.WriteLine("Bad, you are true villain");
                    break;
            }
         
                




 
        }
    }
}
