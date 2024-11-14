using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Mobile : Idevice , IRestart
    {
        public void TurnON()
        {
            Console.WriteLine("Mobile turn on");
        }
        public void TurnOFF()
        {
            Console.WriteLine("Mobile turn off");
        }

        public void restart()
        {
            Console.WriteLine("Mobile Restarted");
        }
    }
}
