using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        abstract public string SkinTexture { get => SkinTexture; set => SkinTexture = value; }

        abstract public bool LaysEggs { get => LaysEggs; set => LaysEggs = value; }

        abstract public bool WarmBlood { get => WarmBlood; set => WarmBlood = value; }
    }
}
