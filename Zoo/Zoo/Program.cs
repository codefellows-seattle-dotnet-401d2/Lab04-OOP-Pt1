using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This zoo has 4 Mammals. 2 are Primates, 2 are Carnivora. Primates are Hominidae and Cebidae. Carnivora are Canidae and Felidae.\n");

            // Instantiate creatures for testing.
            Felidae cat = new Felidae();
            Canidae dog = new Canidae();
            Cebidae capuchin = new Cebidae();
            Hominidae ape = new Hominidae();

            Console.WriteLine("Test inherited Mammal method. All output should be the same.");
            Console.WriteLine("Felidae object: " + cat.GiveBirth());
            Console.WriteLine("Canidae object: " + dog.GiveBirth());
            Console.WriteLine("Cebidae object: " + capuchin.GiveBirth());
            Console.WriteLine("Hominidae object: " + ape.GiveBirth());
            Console.WriteLine("");

            Console.WriteLine("Test inherited Primate method. All output should be the same.");
            Console.WriteLine("Cebidae object: " + capuchin.UsePowerGrip());
            Console.WriteLine("Hominidae object: " + ape.UsePowerGrip());
            Console.WriteLine("");

            Console.WriteLine("Test inherited Carnivora method. All output should be the same.");
            Console.WriteLine("Felidae object: " + cat.Hunt());
            Console.WriteLine("Canidae object: " + dog.Hunt());
            Console.WriteLine("");

            Console.WriteLine("Test abstract Communicate method from Mammalia. All 4 are different implementations of the same method.");
            Console.WriteLine("Felidae object: " + cat.Communicate());
            Console.WriteLine("Canidae object: " + dog.Communicate());
            Console.WriteLine("Cebidae object: " + capuchin.Communicate());
            Console.WriteLine("Hominidae object: " + ape.Communicate());
            Console.WriteLine("");

            Console.Write("Press Enter to Exit program...");
            Console.ReadLine();
        }
    }
}
