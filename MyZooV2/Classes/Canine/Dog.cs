using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Canine
{
    public class Dog : Canine
    {

        public Dog(string Sound, string Food)
        {
            _sound = Sound;
            _food = Food;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"My noise as a dog is {_sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"As a dog, I like to eat {_food}");
        }
    }
}
