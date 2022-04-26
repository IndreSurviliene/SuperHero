using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{ 
    internal class Villains : Person
    {
        public int VillainID { get; set; }

        public double CrimeTime { get; set; }

        public Villains()
        {
            //Name = "Ben";
            //Surname = "Clark";
            //Nickname = "Angrybird";
            //Age = 22;
            VillainID = 111111;
            CrimeTime = 10;
        }
        
        public Villains (string Name, string Surname, string Nickname, int Age, int HeroID, int CrimeTime)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.Age = Age;
            this.VillainID = HeroID;
            this.CrimeTime = CrimeTime;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"VillainID: {VillainID}\n CrimeTime: {CrimeTime}\n");
        }
        public int CalculatedLevelOfCrime()
        {
            int level = 0;
            if (CrimeTime >= 10)
            {
                level = 1;
            }
            if (CrimeTime >= 20 && CrimeTime <= 40)
            {
                level = 2;
            }
            if (CrimeTime >= 40)
            {
                level = 3;
            }
            return level;
        }
    }
}

