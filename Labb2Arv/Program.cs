using System;

namespace Labb2Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animals animals = new Animals();
            //Lion lejon = new Lion();
            //lejon.getName();
            //lejon.getAge();
            //lejon.getOrigin();
            //lejon.makeSound();
            //lejon.getCost();
            //lejon.FavouritePray();
            //Console.WriteLine("_________________________________________________________");

            //Bear bear = new Bear();
            //bear.makeSound();
            //bear.getAge();
            //bear.getOrigin();
            //bear.getGender();
            //bear.getCost();

            //Console.WriteLine("__________________________________________________________");

            //PolarBear polarbear = new PolarBear();
            //polarbear.getName();
            //polarbear.makeSound();
            //polarbear.getGender();
            //polarbear.getCost();
            //polarbear.GetAttacks();
            //polarbear.getOrigin();

            //Console.WriteLine("____________________________________________________________");

            //PandaBear pandaBear = new PandaBear();
            //pandaBear.getName();
            //pandaBear.GetHidingSpot();
            //pandaBear.getOrigin();
            //pandaBear.makeSound();


            //Console.WriteLine("Register new animals to the zoo ?");
            //Console.WriteLine();

            //Console.WriteLine("How old is the animal? ");
            //int addAnimalAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("How much did it cost to buy this animal? ");
            //int addAnimalCost = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What is the name of this animal? ");
            //string addAnimalName = Console.ReadLine();
            //Console.WriteLine("Is it a Male or a Female? ");
            //string addGender = Console.ReadLine();
            //Console.WriteLine("Where is this animal from? ");
            //string addOrigin = Console.ReadLine();

            //Animals newAnimal = new Animals(addAnimalAge, addAnimalCost, addAnimalName, addGender, addOrigin);
            //newAnimal.newAnimalRegister();

            mainMenu();








        }

        public static void mainMenu()
        {
            Console.WriteLine("1) Lion ");
            Console.WriteLine("2) Bear ");
            Console.WriteLine("3) PolarBear ");
            Console.WriteLine("4) PandaBear ");
            Console.WriteLine("5) Register new Animal ");

            Animals animals = new Animals();

            int userChoiceMenu = int.Parse(Console.ReadLine());

            switch(userChoiceMenu)
            {
                case 1:
                    Lion lejon = new Lion();
                    lejon.getName();
                    lejon.getAge();
                    lejon.getOrigin();
                    lejon.makeSound();
                    lejon.getCost();
                    lejon.FavouritePray();
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    break;

                    case 2:
                    Bear bear = new Bear();
                    bear.makeSound();
                    bear.getAge();
                    bear.getOrigin();
                    bear.getGender();
                    bear.getCost();
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    break;

                    case 3:
                    PolarBear polarbear = new PolarBear();
                    polarbear.getName();
                    polarbear.makeSound();
                    polarbear.getGender();
                    polarbear.getCost();
                    polarbear.GetAttacks();
                    polarbear.getOrigin();
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();

                    break;

                case 4:
                    PandaBear pandaBear = new PandaBear();
                    pandaBear.getName();
                    pandaBear.GetHidingSpot();
                    pandaBear.getOrigin();
                    pandaBear.makeSound();
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    break;

                case 5:

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
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    break;

                default:
                    Console.WriteLine("Invalid choice"); 
                    Console.ReadKey();
                    Console.Clear();
                    mainMenu();
                    break;
            }
        }



        
    }
}
