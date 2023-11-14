using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes
{
    abstract public class Animal
    {
        protected string _food;
        protected string _sound;

        public virtual void MakeNoise()
        {
            Console.WriteLine($"My noise is {_sound}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"I like to eat {_food}");
        }

        public virtual void Roam()
        {
            Console.WriteLine("I am roaming around.");
        }
    }
}
