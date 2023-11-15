using MyZooV2.Classes;
using MyZooV2.Classes.Canine;
using MyZooV2.Classes.Hippo;
using MyZooV2.Classes.Feline;
using System.Globalization;

namespace MyZooV2
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>()
            {


                new Lion("Roar", "Meat"),
                new Tiger("Another Roar", "Meat"),
                new Cat("Meow", "Cat food"),

                new Wolf("Howl", "Meat"),
                new Dog("Woof", "Dog biscuits"),

                new Hippo("Something loud", "Whatever"),

            };

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                animal.Eat();
                animal.Roam();

                Console.WriteLine("-----------------------");
            }

          
        }

    }
}