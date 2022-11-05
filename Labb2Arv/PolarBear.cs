using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Arv
{
     class PolarBear : Bear
    {
        public int Attacks;
        public PolarBear(int age = 12, float cost = 53030, string name = "Isak", string gender = "Male", string origin = "North Pole ", string texture = "Hairy", int attacks = 2)
        {
            this.Age = age;
            this.Cost = cost;
            this.Name = name;
            this.Gender = gender;
            this.Origin = origin;
            this.texture = texture;
            this.Attacks = attacks;

        }

        public void GetAttacks()
        {
            Console.WriteLine($"{Name} has attacked {Attacks} Zoo keeprs ");
        }

        public new void makeSound()
        {
            Console.WriteLine($"{Name} makes the sound oOoooOowww");


        }

    }
}
