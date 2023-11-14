using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Feline
{
    public class Lion : Feline
    {

        public Lion(string Sound, string Food)
        {
            _sound = Sound;
            _food = Food;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"My noise as a lion is {_sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"As a lion, I like to eat {_food}");
        }
    }
}
