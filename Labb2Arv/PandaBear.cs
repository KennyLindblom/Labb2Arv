using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Arv
{
     class PandaBear : PolarBear
        
    {
        public int injurys;

        public PandaBear(int age = 4, float cost = 2000000, string name = "Juan", string gender = "Male", string origin = "China ", string texture = "Hairy", int attacks =0, int injurys = 5)
        {
            this.Age = age;
            this.Cost = cost;
            this.Name = name;
            this.Gender = gender;
            this.Origin = origin;
            this.texture = texture;
            this.Attacks = attacks;
            this.injurys = injurys;
        }

        public void GetHidingSpot()
        {
            Console.WriteLine($"{Name} loves to hide high up in the trees, {injurys} injurys have come from falling down the trees");
        }

        public new void makeSound()
        {
            Console.WriteLine($"{Name} is a mute and has yet to make any sounds. ");
        }

    }
}
