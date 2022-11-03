using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Labb2Arv
{
     class Lion : Animals
    {
        public string color;
        public Lion(int age = 10, float cost = 120400, string name = "Leo", string gender = "Female", string origin = "Zambia ", string color = "Yellow")
        {
            this.Age = age;
            this.Cost = cost;
            this.Name = name;
            this.Gender = gender;
            this.Origin = origin;
            this.color = color;
            
            
          


        }
        public void makeSound()
        {
            Console.WriteLine($"The Lion Makes the sound raaaaarw and is {color}  ");
        }

        public void FavouritePray()
        {

            Console.WriteLine($"{Name} favorite snack is Antilop");
        }



    }
}
