using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Arv
{
     class Animals
    {
        public int Age;
        public float Cost;
        public string Name;
        public string Gender;
        public string Origin;

        public Animals(int age = 0, float cost= 0, string name = "Unknown", string gender = "Female", string origin = "Unknown")
        {
            this.Age = age;
            this.Cost = cost;
            this.Name = name;
            this.Gender = gender;
            this.Origin = origin;
        }

        public void getGender()
        {
            Console.WriteLine($"{Gender} is the gender of this animal");

        }
        public void getName()
        {
            Console.WriteLine($"This animals name is {Name} ");

        }

        public void getOrigin()
        {
            Console.WriteLine($"{Name} is from {Origin} ");
        }

        public void getAge()
        {
            Console.WriteLine($"{Name} is {Age} Years old ");
        }

        public void getCost()
        {
            Console.WriteLine($"The animal {Name} has cost the zoo {Cost} kr to buy.... ");
        }
        
        public void newAnimalRegister()
        {
            Console.WriteLine($"{Name} that cost {Cost} to buy and has an age of {Age} and is a {Gender} from {Origin} has been added to the system....   " );
        }

    }
}
