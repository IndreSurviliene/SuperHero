using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Districts
    {
        public string Title { get; set; }

        public string City { get; set; }

        public int DistrictID { get; set; }

        //public List<Heroes>  HeroesInTheDistrict { get; set; }
        public List<Person> PeopleInTheDistricts { get; set; }

        public Districts(string title, string city, int districtID, List<Person> peopleInTheDistricts)
        {
            this.Title = title;
            this.City = city;
            this.DistrictID = districtID;
            PeopleInTheDistricts = peopleInTheDistricts;
        }
        public void PrintListOfPeople()
        {
            for (int i = 0; i < PeopleInTheDistricts.Count; i++)
            {
                Console.WriteLine($"{i}.{PeopleInTheDistricts[i].Nickname}");
            }
        }
        public void PrintListOfHeroes()
        {
                foreach (Person person in PeopleInTheDistricts)
                {
                    if (person is Heroes)
                    {
                        Console.WriteLine(person.Nickname);
                    }
                }
        }
        public void PrintListOfVillains()
        {
            foreach (Person person in PeopleInTheDistricts)
            {
                if (person is Villains)
                {
                    Console.WriteLine(person.Nickname);
                }
            }
        }
        public void AddHero(Heroes hero)
        {
            Console.WriteLine($"We have added to {Title} hero {hero.Nickname}");
            PeopleInTheDistricts.Add(hero);
        }
        public void AddVillain(Villains villain)
        {
            Console.WriteLine($"We have added to {Title} villain {villain.Nickname}");
            PeopleInTheDistricts.Add(villain);
        }
        public void RemoveHero(int position)
        {
            Console.WriteLine($"We removed the hero {PeopleInTheDistricts[position].Nickname} from {Title}");
            PeopleInTheDistricts.RemoveAt(position);
        }
        public void RemoveVillain(int position)
        {
            Console.WriteLine($"We removed the villain {PeopleInTheDistricts[position].Nickname} from {Title}");
            PeopleInTheDistricts.RemoveAt(position);
        }
        public double CalculateAvgLevelInDistrict()
        {
            double maxHeroLevel = 0;
            int heroCount = 0;
            foreach (Person person in PeopleInTheDistricts)
            {
                if (person is Heroes)
                {
                    maxHeroLevel += person.CalculatedLevelOfDeed();
                    heroCount++;
                }
            }
            var averageHeroLevel = maxHeroLevel / heroCount;
            return averageHeroLevel;
        }
        public int CalculateMaxVillainLevelInDistrict()
        {
            int maxLevel = 0;
            foreach (Person person in PeopleInTheDistricts)
            {
                if (person is Villains)
                {
                    Villains villain = (Villains)person;
                    if (maxLevel < villain.CrimeTime)
                    {
                        maxLevel = (int)villain.CrimeTime;
                    }
                }
            }
            return maxLevel;
        }
        public void PrintMaxLevelVillainInDistrict()
        {
            int maxLevel = 0;
            string maxVillainName = string.Empty;
            var villainList = PeopleInTheDistricts.Where(person => person is Villains).ToList();
            foreach (Person person in villainList)
            {
                Villains villain = (Villains)person;
                if (maxLevel < villain.CrimeTime)
                {
                    maxLevel = (int)villain.CrimeTime;
                    maxVillainName = villain.Nickname;
                }
            }
            Console.WriteLine($"The max crime time in {Title} is {maxVillainName} with {maxLevel} hours");
        }
        public void PrintInformationAboutDistrict()
        {
            Console.WriteLine($"========={City}=========");
            Console.WriteLine($"District: {Title}");
            Console.WriteLine($"ID: {DistrictID}");
            Console.WriteLine($"People in the district:");
            foreach (Person people in PeopleInTheDistricts)
            {
                people.PrintInfo();
            }
        }
        public void PrintInfo()
        {
            for (int i = 0; i < PeopleInTheDistricts.Count; i++)
            {
                Console.WriteLine($"{i}.{PeopleInTheDistricts[i].Nickname}");
            }
        }
    }
}
