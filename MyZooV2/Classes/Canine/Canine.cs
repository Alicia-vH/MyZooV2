using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Canine
{

    //Canines
    abstract public class Canine : Animal
    {
        public override void Roam()
        {
            Console.WriteLine("I am a canine roaming around.");
        }
    }

    


}
