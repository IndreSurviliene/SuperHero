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

        public int HeroID { get; set; }

        public HeroType Type { get; set; }

        public int DeedTime { get; set; }

        public Hero()
        {
            Name = "John";
            Surname = "Smith";
            Nickname = "Powerhero";
            HeroID = 1111;
            Type = HeroType.Hero;
            DeedTime = 10;
        }
        public Hero (string Name, string Surname, string Nickname, int HeroID, HeroType Hero, int DeedTime)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.HeroID = HeroID;
            this.Type = Hero;
            this.DeedTime = DeedTime;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Nickname: {Nickname}\n HeroID: {HeroID}\n Type: {Type}\n Deedtime: {DeedTime}");
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
    }
}
