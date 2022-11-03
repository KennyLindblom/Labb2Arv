using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Arv
{
     class Bear : Animals
    {
        public string texture;

        public Bear(int age = 5, float cost = 200, string name = "Björne", string gender = "Female", string origin = "Russia ",  string texture = "Hairy")
        {
            this.Age = age;
            this.Cost = cost;
            this.Name = name;
            this.Gender = gender;
            this.Origin = origin;
            this.texture = texture;
            
        }
        public void makeSound()
        {
            Console.WriteLine($"The bear {Name} makes the sound rawrawrwa ");
        }


    }
}
