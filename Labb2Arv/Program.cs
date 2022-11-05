using System;

namespace Labb2Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            Lion lejon = new Lion();
            lejon.getName();
            lejon.getAge();
            lejon.getOrigin();
            lejon.makeSound();
            lejon.getCost();
            lejon.FavouritePray();
            Console.WriteLine("_________________________________________________________");

            Bear bear = new Bear();
            bear.makeSound();
            bear.getAge();
            bear.getOrigin();
            bear.getGender();
            bear.getCost();

            Console.WriteLine("__________________________________________________________");

            PolarBear polarbear = new PolarBear();
            polarbear.getName();
            polarbear.makeSound();
            polarbear.getGender();
            polarbear.getCost();
            polarbear.GetAttacks();
            polarbear.getOrigin();

            Console.WriteLine("____________________________________________________________");

            PandaBear pandaBear = new PandaBear();
            pandaBear.getName();
            pandaBear.GetHidingSpot();
            pandaBear.getOrigin();
            pandaBear.makeSound();


            Console.WriteLine("Register new animals to the zoo ?");
            Console.WriteLine();

            Console.WriteLine("How old is the animal? ");
            int addAnimalAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much did it cost to buy this animal? ");
            int addAnimalCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the name of this animal? ");
            string addAnimalName = Console.ReadLine();
            Console.WriteLine("Is it a Male or a Female? ");
            string addGender = Console.ReadLine();
            Console.WriteLine("Where is this animal from? ");
            string addOrigin = Console.ReadLine();

            Animals newAnimal = new Animals(addAnimalAge, addAnimalCost, addAnimalName, addGender, addOrigin);
            newAnimal.newAnimalRegister();








        }



        
    }
}
