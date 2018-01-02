using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Demi : Dog
    {
        bool goodDog = true;
       
        void Bark()
        {
            Console.WriteLine("Everyone knows Demi doesn't bark!");
        }
    }
}
