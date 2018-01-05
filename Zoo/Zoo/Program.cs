using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            DireWolf fluffy = new DireWolf();
            fluffy.BornMsg();

            Console.Read();

            fluffy.Call();

            Console.Read();

            Snake dangernoodle = new Snake();
            dangernoodle.BornMsg();

            Console.Read();

            dangernoodle.Call();

            Console.Read();

            Chameleon larry = new Chameleon();
            larry.BornMsg();

            Console.Read();

            larry.Call();

            Console.Read();

            Housecat Ferdinand = new Housecat();
            Ferdinand.Call();

            Console.Read();

            Console.WriteLine(Ferdinand.Name + " has " + Ferdinand.Legs + " legs.");

            Console.Read();

            Console.WriteLine(dangernoodle.Name + " has " + dangernoodle.Legs + " legs.");
            dangernoodle.Call();

            Console.Read();


        }
    }
}
