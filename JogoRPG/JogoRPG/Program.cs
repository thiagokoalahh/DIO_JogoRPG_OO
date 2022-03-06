using JogoRPG.src.Entities;
using JogoRPG.src.Entities.Classes;
using System;
using System.Collections.Generic;

namespace JogoRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 10, "Knight");
            Ninja ninja = new Ninja("Zed", 10, "Ninja");
            WhiteWizard whiteWizard = new WhiteWizard("Jennica", 10, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Tatay", 10, "Black Wizard");

            List<BaseHero> heroes = new List<BaseHero>();
            heroes.Add(knight);
            heroes.Add(ninja);
            heroes.Add(blackWizard);
            heroes.Add(whiteWizard);

            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero);
                Console.WriteLine(hero.Attack());
                Console.WriteLine();
            }

        }
    }
}
