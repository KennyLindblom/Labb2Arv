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
            
            
        }
    }
}
