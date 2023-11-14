using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Canine
{
    public class Wolf : Canine
    {

        public Wolf(string Sound, string Food)
        {
            _sound = Sound;
            _food = Food;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"My noise as a wolf is {_sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"As a wolf, I like to eat {_food}");
        }
    }



}
