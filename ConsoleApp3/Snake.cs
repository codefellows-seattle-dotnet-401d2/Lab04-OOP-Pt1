using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Snake : Reptile
    {
        bool canShedSkin;

        Snake()
        {
            canShedSkin = true;
        }

        public void ShedSkin() {
            Console.Write("The snake sheds it's skin so it can continue growing.");
        }
    }
}
