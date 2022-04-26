using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    /*public enum HeroType
    {
        Hero,
        Villain,
    }*/
    internal class Heroes : Person
    {
        public int HeroID { get; set; }

        //public HeroType Type { get; set; }

        public double DeedTime { get; set; }

        public string SuperHeroPowers { get; set; }

        public double Salary { get; set; }

        public string listOfHeroes { get; set; }
        public List<Person> PeopleInTheDistricts { get; set; }

        public Heroes()
        {
            Name = "John";
            Surname = "Smith";
            Nickname = "Powerhero";
            Age = 33;
            HeroID = 1111;
            //Type = HeroType.Hero;
            //superHeroPowerList = new List<string>();
            SuperHeroPowers = "Good swimmer, fast runner, strong body";
            DeedTime = 10;
            Salary = 1000;
        }
        public Heroes(string Name, string Surname, string Nickname, int Age, int HeroID, string SuperHeroPowers, double DeedTime, double Salary) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Nickname = Nickname;
            this.Age = Age;
            this.HeroID = HeroID;
            //this.Type = Hero;
            this.SuperHeroPowers = SuperHeroPowers;
            //this.superHeroPowerList = superHeroPowerList;
            this.DeedTime = DeedTime;
            this.Salary = 1000;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"HeroID: {HeroID}\n Superpowers: {SuperHeroPowers}\n Deedtime: {DeedTime}\n");
        }

        public int CalculatedLevelOfDeed()
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
        {
            /*double[,] deedTimeInHours = { { 10, 20, 30 }, { 15, 25, 35 }, { 20, 30, 40 }, { 25, 35, 45 }, { 30, 40, 50 }, { 35, 45, 55 }, { 40, 50, 60 } };
            double[] deedTimeInHoursList = new double[listOfHeroes.Length];
            double[] averageDeedTimeList = new double[listOfHeroes.Length];
            for (int d = 0; d < listOfHeroes.Length; d++)
            {
                deedTimeInHoursList[d] = deedTimeInHours[d, 0] + deedTimeInHours[d, 1] + deedTimeInHours[d, 2];
                averageDeedTimeList[d] = deedTimeInHoursList[d] / 3;
            }*/
            double[] Salary = { 1000, 1500, 2000, 2500, 3000, 3500, 4000 };
            double dailySalary = 0;
            for (int s = 0; s < listOfHeroes.Length; s++)
            {
                dailySalary = Math.Round(Salary[s] / 30, 2);
            }
            double cookies = 2;
            double hour = 24;
            double boughtCookies = 0;
            double gotCookiesPerHour = 0;
            /*for (int c = 0; c < listOfHeroes.Length; c++)
            {
                boughtCookies = Math.Floor(dailySalary[c] / cookies);
                gotCookiesPerHour = Math.Floor(boughtCookies[c] / hour);
            }*/

            //Console.WriteLine($"Time spent on deeds: {deedTimeInHoursList}");
            //Console.WriteLine($"Average time spend on deed: { averageDeedTimeList} hours");
            Console.WriteLine($"Hero earns daily: {dailySalary} Eur");
            Console.WriteLine($"The hero gets {boughtCookies} cookies");
            Console.WriteLine($"The hero gets {gotCookiesPerHour} cookies per hour");
        }
    }
}
