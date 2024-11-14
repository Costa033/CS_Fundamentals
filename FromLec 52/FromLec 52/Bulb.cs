using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Bulb : Idevice
    {
        public void restart()
        {
            Console.WriteLine("Bulb Can't Restart");
        }

        public void TurnOFF()
        {
            Console.WriteLine("Bulb turn on");
        }

        public void TurnON()
        {
            Console.WriteLine("Bulb turn off");
        }
    }
}
