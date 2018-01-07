using System;


namespace Zoo
{

    public abstract class ZooClass 
    {
        public bool Animals { get; set; }

        public bool GiftShop { get; set; }

        public bool Cages { get; set; }

        public void Watch()
        {
            Console.WriteLine("Observe and learn!");
        }

        public void Pet()
        {
            Console.WriteLine("Let's pet some animals!");
        }

        public void Learn()
        {
            Console.WriteLine("So much learning at the zoo");
        }
    }
}
