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

            Hero Powerhero = new Hero("John", "Smith", "Powerhero", 33, 1111, HeroType.Hero, "Good swimmer, fast runner, strong body", 10);
            Hero Spiderman = new Hero("Ben", "Snow", "Spiderman", 27, 2222, HeroType.Hero, "Good climber, fearless, jumps high", 15);
            Hero Batman = new Hero("Will", "White", "Batman", 45, 3333, HeroType.Villain, "Flies high, fast, furious", 20);
            Hero Superwoman = new Hero("Ann", "Rose", "Superwoman", 23, 4444, HeroType.Hero, "Knows everything, does everything, can code", 25);

            List<Hero> listOfHeroes = new List<Hero>();
            listOfHeroes.Add(Powerhero);
            listOfHeroes.Add(Spiderman);
            listOfHeroes.Add(Batman);
            listOfHeroes.Add(Superwoman);

            District antakalnis = new District("Antakalnis", "Vilnius", 1010, listOfHeroes);

            //List<string> superHeroesPowerList = new List<string>();

            string[] superHeroNameList = { "Powerhero", "Spiderman", "Batman", "Superwoman" };

            double[,] deedTimeInHours2D = { { 10, 20, 30 }, { 15, 25, 35 }, { 20, 30, 40 }, { 25, 35, 45 } };
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
                        for (int i = 0; i < listOfHeroes.Count; i++)
                        {
                            Console.WriteLine($"{i}. {listOfHeroes[i].Nickname}");
                        }
                        Console.WriteLine("===========================================");
                        break;

                    case "2":
                        Console.WriteLine($"Please choose a superhero by number");
                        for (int i = 0; i < listOfHeroes.Count; i++)
                        {
                            Console.WriteLine($"{i}. {listOfHeroes[i].Nickname}");
                        }
                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        Console.WriteLine($"You have chosen {listOfHeroes[chosenNumber].Nickname}");

                        Console.WriteLine("Choose what type of info to show");
                        Console.WriteLine($"1 - GENERAL INFO");
                        Console.WriteLine($"2 - FINANCIAL INFO");
                        string showMenu = Console.ReadLine();

                        if (showMenu == "1")
                        {
                            Console.WriteLine("*************GENERAL INFO********************");
                            listOfHeroes[chosenNumber].PrintInfo();
                            Console.WriteLine("********************************************* \n \n");
                        }
                        else if (showMenu == "2")
                        {
                            Console.WriteLine("**************FINANCIAL INFO*****************");
                            Console.WriteLine($"Time spent on deeds:{deedTimeInHoursList[chosenNumber]}");
                            Console.WriteLine($"Average time spend on deed: {averageDeedTimeList[chosenNumber]} hours");
                            Console.WriteLine($"Hero earns daily: {dailySalaryList[chosenNumber]} Eur");
                            Console.WriteLine($"The hero gets {boughtCookiesList[chosenNumber]} cookies");
                            Console.WriteLine($"The hero gets {gotCookiesPerHourList[chosenNumber]} cookies per hour");
                            Console.WriteLine("********************************************* \n \n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("What is the new superhero name?");
                        string superHeroName = Console.ReadLine();
                        Hero newHero = new Hero();
                        newHero.Nickname = superHeroName;
                        antakalnis.AddHero(newHero);

                        break;
                    case "4":
                        Console.WriteLine($"Select a hero you want to delete");
                        antakalnis.PrintInfo();
                        int.TryParse(Console.ReadLine(), out int positionToRemove);
                        antakalnis.RemoveHero(positionToRemove);
                        Console.WriteLine($"You have deleted {positionToRemove} hero");
                        break;
                    case "5":

                        foreach (Hero hero in listOfHeroes)
                        {
                            if (hero.CalculatedLevel() > 1)
                            {
                                Console.WriteLine($"{hero.Nickname} is higher than level 1");
                            }
                        }
                        Console.WriteLine($"The average of level of heroes inside {antakalnis.Title} is: {antakalnis.CalculateAvgLevelInDistrict()}");
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

            /*
            Powerhero.PrintInfo();
            Spiderman.PrintInfo();
            Batman.PrintInfo();
            Superwoman.PrintInfo();

            LOOP for lists (vietoj Length - COUNT)
            for (int i = 0; i < metropole.Count; i++)
            {
                Console.WriteLine(metropole[i].Nickname);
            }

            TO FIND something:
            var foundHero = listOfHeroes.Find(find => find.Name == "John");
            Console.WriteLine($"We found {foundHero.Name}");
            foundHero.PrintInfo(); //Prints all info about John

            var foundHero2 = metropole.Find(find => find.CalculatedLevel == 1); doesn't work


            string[] superHeroAgeList = { "33", "27", "45", "23" };
            string[] superHeroPowerList = { "Good swimmer, fast runner, strong body", "Good climber, fearless, jumps high", "Flies high, fast, furious", "Knows everything, does everything, can code" };
            
            GENERAL INFO
            Console.WriteLine($"Hero nickname: {listOfHeroes[chosenNumber].Nickname}");
            Console.WriteLine($"Name and Surname: {listOfHeroes[chosenNumber].Name} {listOfHeroes[chosenNumber].Surname}");
            Console.WriteLine($"Age: {listOfHeroes[chosenNumber].Age}");
            Console.WriteLine($"HeroID: {listOfHeroes[chosenNumber].HeroID}");
            Console.WriteLine($"Superpowers: {listOfHeroes[chosenNumber].Superpowers}");
            Console.WriteLine($"Hero type: {listOfHeroes[chosenNumber].Type}");
            Console.WriteLine("********************************** \n \n");



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
            */
        }
    }
}
