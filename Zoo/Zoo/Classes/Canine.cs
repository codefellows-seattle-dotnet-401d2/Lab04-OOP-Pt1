using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract public class Canine : Mammal
    {
        public override string Food { get; set; } = "meat";

        public override string SkinTexture { get; set; } = "fur";
    }
}
