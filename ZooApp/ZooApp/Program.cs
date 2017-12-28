﻿using System;
using ZooApp.Classes;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the world of Inheritance!");

            Reptilia reptilia = new Reptilia();
            reptilia.DoActivity();

            SouthPacific southPacificAquaria = new SouthPacific();
            southPacificAquaria.Speed = 30;

            Console.Write("Setting speed and checking if it's a match then we found Nemo! - Result: ");
            southPacificAquaria.CanNemoSwim(30);

            Zebra someZebra = new Zebra();
            someZebra.CheckMinimumDangerLevel();

            Console.ReadLine();
        }
    }
}
