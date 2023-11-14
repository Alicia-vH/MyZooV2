using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Feline
{


    public class Tiger : Feline
    {

        public Tiger(string Sound, string Food)
        {
            _sound = Sound;
            _food = Food;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"My noise as a tiger is {_sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"As a tiger, I like to eat {_food}");
        }
    }

}
