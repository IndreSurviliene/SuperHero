using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public enum HeroType
    {
        Hero,
        Villain,
    }

    internal class Hero
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public int Age { get; set; }

        public int HeroID { get; set; }

        public HeroType Type { get; set; }

        public double DeedTime { get; set; }

        public string SuperHeroPowers { get; set; }

        //public List<string> superHeroPowerList { get; set; }

        
        public Hero()
        {
            Name = "John";
            Surname = "Smith";
            Nickname = "Powerhero";
            Age = 33;
            HeroID = 1111;
            Type = HeroType.Hero;
            //superHeroPowerList = new List<string>();
            SuperHeroPowers = "Good swimmer, fast runner, strong body";
            DeedTime = 10;
        }
        public Hero(string Name, string Surname, string Nickname, int Age, int HeroID, HeroType Hero, string SuperHeroPowers, double DeedTime) //List<string> superHeroPowerList
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.Age = Age;
            this.HeroID = HeroID;
            this.Type = Hero;
            this.SuperHeroPowers = SuperHeroPowers;
            //this.superHeroPowerList = superHeroPowerList;
            this.DeedTime = DeedTime;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Nickname: {Nickname}\n Age: {Age}\n HeroID: {HeroID}\n Type: {Type}\n Superpowers: {SuperHeroPowers}\n Deedtime: {DeedTime}\n");
        }
    public int CalculatedLevel()
        {
            int level = 0;
            if (DeedTime < 20)
            {
                level = 1;
            }
            if (DeedTime >= 20 && DeedTime <= 40)
            {
                level = 2;
            }
            if (DeedTime > 40)
            {
                level = 3;
            }

            return level;
        }
        public void PrintFinancialInformation()
        { }  
            
        }
    }
