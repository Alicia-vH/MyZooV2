using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Feline
{
    //Felines
    abstract public class Feline : Animal
    {
        public override void Roam()
        {
            Console.WriteLine("I am a feline roaming around.");
        }
    }

 
}
