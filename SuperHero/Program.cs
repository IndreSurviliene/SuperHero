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
            Heroes Powerhero = new Heroes("John", "Smith", "Powerhero", 33, 1111, "Good swimmer, fast runner, strong body", 10, 1000);
            Heroes Spiderman = new Heroes("Ben", "Snow", "Spiderman", 27, 2222, "Good climber, fearless, jumps high", 15, 1500);
            Heroes Batman = new Heroes("Will", "White", "Batman", 45, 3333, "Flies high, fast, furious", 20, 2000);
            Heroes Superwoman = new Heroes("Ann", "Rose", "Superwoman", 23, 4444, "Knows everything, does everything, can code", 25, 2500);
            Heroes Supercat = new Heroes("Mary", "Jones", "Supercat", 25, 5555, "Superfast, superstrong, superclever", 30, 3000);
            Heroes Flash = new Heroes("Mark", "Hilton", "Flash", 21, 6666, "Moves fast, runs fast, think fast", 35, 3500);
            Heroes Eagle = new Heroes("Rock", "Jakob", "Eagle", 39, 7777, "Flies, hunts, sleep less", 40, 4000);

            List<Heroes> listOfHeroes = new List<Heroes>();
            listOfHeroes.Add(Powerhero);
            listOfHeroes.Add(Spiderman);
            listOfHeroes.Add(Batman);
            listOfHeroes.Add(Superwoman);
            listOfHeroes.Add(Supercat);
            listOfHeroes.Add(Flash);
            listOfHeroes.Add(Eagle);

            Villains Angrybird = new Villains("Rob", "Clark", "Angrybird", 22, 111111, 10);
            Villains Joker = new Villains("Jack", "White", "Joker", 47, 222222, 20);
            Villains Badass = new Villains("Tom", "Wolf", "Badass", 35, 333333, 30);

            List<Villains> listOfVillains = new List<Villains>();
            listOfVillains.Add(Angrybird);
            listOfVillains.Add(Joker);
            listOfVillains.Add(Badass);

            List<Person> PeopleInTheDistricts = new List<Person>();
            PeopleInTheDistricts.Add(Powerhero);
            PeopleInTheDistricts.Add(Spiderman);
            PeopleInTheDistricts.Add(Batman);
            PeopleInTheDistricts.Add(Superwoman);
            PeopleInTheDistricts.Add(Supercat);
            PeopleInTheDistricts.Add(Flash);
            PeopleInTheDistricts.Add(Eagle);
            PeopleInTheDistricts.Add(Angrybird);
            PeopleInTheDistricts.Add(Joker);
            PeopleInTheDistricts.Add(Badass);

            List<Person> PeopleInAntakalnis = new List<Person>();
            PeopleInAntakalnis.Add(Powerhero);
            PeopleInAntakalnis.Add(Spiderman);
            PeopleInAntakalnis.Add(Batman);
            PeopleInAntakalnis.Add(Angrybird);
            PeopleInAntakalnis.Add(Joker);

            List<Person> PeopleInZirmunai = new List<Person>();
            PeopleInZirmunai.Add(Superwoman);
            PeopleInZirmunai.Add(Supercat);
            PeopleInZirmunai.Add(Flash);
            PeopleInZirmunai.Add(Eagle);
            PeopleInZirmunai.Add(Badass);

            Districts Antakalnis = new Districts("Antakalnis", "Vilnius", 1010, PeopleInAntakalnis);
            Districts Zirmunai = new Districts("Zirmunai", "Vilnius", 2020, PeopleInZirmunai);
            List<Districts> listOfDistricts = new List<Districts>();
            
            bool isMenuRunning = true;
            do
            {
                string menuItems;

                Console.WriteLine($"Welcome to the superheros and villains application!");
                Console.WriteLine($"Select what to do:");
                Console.WriteLine($"1 - Show list of people");
                Console.WriteLine($"1.1 - Show people in a choosen district");
                Console.WriteLine($"2.1 - Show list of superheroes");
                Console.WriteLine($"2.2 - Show list of villains");
                Console.WriteLine($"3 - Show information about the specific hero");
                Console.WriteLine($"4.1 - Adding a superhero");
                Console.WriteLine($"4.2 - Adding a villain");
                Console.WriteLine($"5.1 - Deleting a superhero");
                Console.WriteLine($"5.2 - Deleting a villain");
                Console.WriteLine($"6 - OOP superhero");
                Console.WriteLine($"7 - Information about the districts");
                Console.WriteLine($"8 - Exit");

                menuItems = Console.ReadLine();

                switch (menuItems)
                {
                    case "1":
                        Console.WriteLine("============List=of=people============");
                        for (int i = 0; i < PeopleInTheDistricts.Count; i++)
                        {
                          Console.WriteLine($"{i}. {PeopleInTheDistricts[i].Nickname}");
                        }
                        Console.WriteLine("===========================================");
                        break;
                    case "1.1":
                        Console.WriteLine("Choose a district");
                        Console.WriteLine($"1 - people in Antakalnis");
                        Console.WriteLine($"2 - people in Zirmunai");
                        string showMenu = Console.ReadLine();
                        if (showMenu == "1")
                        {
                            Console.WriteLine("********** people in Antakalnis ***************");
                            Antakalnis.PrintInfo();
                            Console.WriteLine("********************************************* \n \n");
                        }
                        else if (showMenu == "2")
                        {
                            Console.WriteLine("********** people in Zirmunai ****************");
                            Zirmunai.PrintInfo();
                            Console.WriteLine("********************************************* \n \n");
                        }
                        break;
                    case "2.1":
                        Console.WriteLine("============List=of=heroes=============");
                        Antakalnis.PrintListOfHeroes();
                        Zirmunai.PrintListOfHeroes();
                        Console.WriteLine("========================================");
                        break;
                    case "2.2":
                        Console.WriteLine("============List=of=villains============");
                        
                        Antakalnis.PrintListOfVillains();
                        Zirmunai.PrintListOfVillains();
                        Console.WriteLine("========================================");
                        break; 
                    case "3":
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
                        string showMenu1 = Console.ReadLine();
                        if (showMenu1 == "1")
                        {
                            Console.WriteLine("*************GENERAL INFO********************");
                            listOfHeroes[chosenNumber].PrintInfo();
                            Console.WriteLine("********************************************* \n \n");
                        }
                        else if (showMenu1 == "2")
                        {
                            Console.WriteLine("**************FINANCIAL INFO*****************");
                                listOfHeroes[chosenNumber].PrintFinancialInformation();
                            Console.WriteLine("********************************************* \n \n");
                        }
                        break;
                    case "4.1":
                        Console.WriteLine("What is the new superhero name?");
                        string superHeroName = Console.ReadLine();
                        Heroes newHero = new Heroes();
                        newHero.Nickname = superHeroName;
                        Antakalnis.AddHero(newHero);
                        break;
                    case "4.2":
                        Console.WriteLine("What is the new villain name?");
                        string villainName = Console.ReadLine();
                        Villains newVillain = new Villains();
                        newVillain.Nickname = villainName;
                        Antakalnis.AddVillain(newVillain);
                        break;
                    case "5.1":
                        Console.WriteLine($"Select a superhero you want to delete");
                        Antakalnis.PrintInfo();
                        int.TryParse(Console.ReadLine(), out int positionToRemove);
                        Antakalnis.RemoveHero(positionToRemove);
                        Console.WriteLine($"You have deleted {positionToRemove} superhero");
                        break;
                    case "5.2":
                        Console.WriteLine($"Select a villain you want to delete");
                        Antakalnis.PrintInfo();
                        int.TryParse(Console.ReadLine(), out int positionToRemove2);
                        Antakalnis.RemoveVillain(positionToRemove2);
                        Console.WriteLine($"You have deleted {positionToRemove2} villain");
                        break; 
                    case "6": 
                        foreach (Heroes hero in listOfHeroes)
                        {
                            if (hero.CalculatedLevelOfDeed() > 1)
                            {
                                Console.WriteLine($"{hero.Nickname} is higher than level 1");
                            }
                        }
                        Console.WriteLine($"Average hero level in {Antakalnis.Title} is: {Antakalnis.CalculateAvgLevelInDistrict()}");
                        Console.WriteLine($"Average hero level in {Zirmunai.Title} is: {Zirmunai.CalculateAvgLevelInDistrict()}");

                        Console.WriteLine("******************************");
                        foreach (Villains villain in listOfVillains)
                        {
                            if (villain.CalculatedLevelOfCrime() > 1)
                            {
                                Console.WriteLine($"{villain.Nickname} is higher than level 1");
                            }
                        }
                        Console.WriteLine("******************************");
                        Console.WriteLine($"The max crime time in {Antakalnis.Title} is {Antakalnis.CalculateMaxVillainLevelInDistrict()}");
                        Antakalnis.PrintMaxLevelVillainInDistrict();
                        Console.WriteLine($"The max crime time in {Zirmunai.Title} is {Zirmunai.CalculateMaxVillainLevelInDistrict()}");
                        Zirmunai.PrintMaxLevelVillainInDistrict();
                        break; 
                    case "7":
                        Console.WriteLine("Information about the districts:");
                        Antakalnis.PrintInformationAboutDistrict();
                        Zirmunai.PrintInformationAboutDistrict();
                        break;
                    case "8":
                        isMenuRunning = false;
                        Console.WriteLine($"Good bye!");
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
