using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Reptile : Animal
    {
        override public string SkinTexture { get; set; } = "scales";

        override public bool LaysEggs { get; set; } = true;

        override public bool WarmBlood { get; set; } = false;

    }
}
