using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammal : Animal
    {
        override public string SkinTexture { get; set; } = "fur";

        override public bool LaysEggs { get; set; } = false;

        override public bool WarmBlood { get; set; } = true;

    }
}
