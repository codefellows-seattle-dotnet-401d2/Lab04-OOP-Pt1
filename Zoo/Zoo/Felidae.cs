using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Felidae : Carnivora
    {
        public bool PropertyOne { get; set; }
        public bool PropertyTwo { get; set; }
        public bool PropertyThree { get; set; }

        public string FirstMethod() => "Carnivora method call 1.";
        public string SecondMethod() => "Carnivora method call 2.";
        public string ThirdMethod() => "Carnivora method call 3.";
    }
}
