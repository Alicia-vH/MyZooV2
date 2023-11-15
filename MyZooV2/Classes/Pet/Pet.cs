using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZooV2.Classes.Pet
{
    abstract public class Pet
    {

        protected string _play;
        protected string _friendly;


        public void BeFriendly()
        {
            Console.WriteLine("The pet is jumping and wagging it's tail.");
        }

        public void Play()
        {
            Console.WriteLine("The pet is chasing the ball");
        }
    }
}
