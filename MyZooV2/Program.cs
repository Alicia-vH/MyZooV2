using MyZooV2.Classes;
using MyZooV2.Classes.Canine;
using MyZooV2.Classes.Hippo;
using MyZooV2.Classes.Feline;

namespace MyZooV2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Lion("Roar", "Meat");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();

            Console.WriteLine("---------------------");

            animal = new Tiger("Another roar", "Meat");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();

            Console.WriteLine("---------------------");

            animal = new Cat("Meow", "Cat food");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();

            Console.WriteLine("---------------------");

            animal = new Wolf("Howl", "Meat");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();

            Console.WriteLine("---------------------");

            animal = new Dog("Woof", "Dog biscuits");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();

            Console.WriteLine("---------------------");

            animal = new Hippo("Something", "smth");
            animal.MakeNoise();
            animal.Eat();
            animal.Roam();
        }

    }
}