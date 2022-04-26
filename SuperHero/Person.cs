using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public int Age { get; set; }


        public Person()
        {
            Name = "Bob";
            Surname = "Brown";
            Nickname = "Man";
            Age = 18;
        }
        public Person(string Name, string Surname, string Nickname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.Age = Age;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Nickname: {Nickname}\n Age: {Age}");
        }
        public int CalculatedLevelOfDeed()
        {
            int level = 0;
            double DeedTime = 0;
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



