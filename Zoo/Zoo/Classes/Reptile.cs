using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Reptile : Animal
    {
        override public string SkinTexture { get => SkinTexture; set => SkinTexture = value; } = "scales";

        override public bool LaysEggs { get => LaysEggs; set => LaysEggs = value; } = true;

        override public bool WarmBlood { get => WarmBlood; set => WarmBlood = value; } = false;

    }
}
