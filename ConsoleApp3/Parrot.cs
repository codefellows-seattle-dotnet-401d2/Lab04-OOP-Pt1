using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Parrot : Bird
    {
        public string featherColors;

        Parrot()
        {
            featherColors = "red and blue and yellow!";    
        }

        public void FeatherChecker()
        {
            Console.WriteLine($"The parrot's feathers are {featherColors}!");
        }
    }
}
