using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class District
    {
        public string Title { get; set; }

        public string City { get; set; }

        public int DistrictID { get; set; }

        public List<Hero>  HeroesInTheDistrict { get; set; }

        public District(string title, string city, int districtID, List<Hero> heroesInTheDistrict)
        {
            this.Title = title;
            this.City = city;
            this.DistrictID = districtID;
            HeroesInTheDistrict = heroesInTheDistrict;
        }

        public void AddHero(Hero hero)
        {
            Console.WriteLine($"We have added to {Title} hero {hero.Nickname}");
            HeroesInTheDistrict.Add(hero);
        }
        
        public void RemoveHero(int position)
        {
            Console.WriteLine($"We removed the hero {HeroesInTheDistrict[position].Nickname} from {Title}");
            HeroesInTheDistrict.RemoveAt(position);
        }
        public float CalculateAvgLevelInDistrict()
        {
            float totalHeroLevel = 0f;
            foreach (Hero hero in HeroesInTheDistrict)
            {
                totalHeroLevel += hero.CalculatedLevel();
            }
            float averageLevelInDistrict = totalHeroLevel / HeroesInTheDistrict.Count;

            return averageLevelInDistrict;
        }

        public void PrintInformationAboutDistrict()
        {
            Console.WriteLine($"========={City}=========");
            Console.WriteLine($"District: {Title}");
            Console.WriteLine($"ID: {DistrictID}");
            Console.WriteLine($"Heros:");
            foreach (Hero hero in HeroesInTheDistrict)
            {
                hero.PrintInfo();
            }
        }

            public void PrintInfo ()
            {
               for (int i = 0; i < HeroesInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i}.{HeroesInTheDistrict[i].Nickname}");
            }
            }
        }




    

    }
