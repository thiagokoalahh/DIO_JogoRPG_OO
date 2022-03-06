using JogoRPG.src.Entities.Classes;
using System;

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

            Console.WriteLine(knight);
            Console.WriteLine();
            Console.WriteLine(ninja);
            Console.WriteLine();
            Console.WriteLine(whiteWizard);
            Console.WriteLine();
            Console.WriteLine(blackWizard);

            Console.WriteLine();
        }
    }
}
