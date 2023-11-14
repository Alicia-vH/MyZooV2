using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Hippo
{

    //Hippo
    public class Hippo : Animal
    {

        public Hippo(string Sound, string Food)
        {
            _sound = Sound;
            _food = Food;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"My noise as a hippo is {_sound}");
        }

        public override void Eat()
        {
            Console.WriteLine($"As a hippo, I like to eat {_food}");
        }
    }

}
