using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammal : Animal
    {
        override public string SkinTexture { get => SkinTexture; set => SkinTexture = value; } = "fur";

        override public bool LaysEggs { get => LaysEggs; set => LaysEggs = value; } = false;

        override public bool WarmBlood { get => WarmBlood; set => WarmBlood = value; } = true;

    }
}
