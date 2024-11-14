using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Computer : Idevice , IRestart
    {
     
        public void TurnON()
        {
            Console.WriteLine("Computer turn on");

        }

        public void TurnOFF()
        {
            Console.WriteLine("Computer turn off");

        }

        void IRestart.restart()
        {
            Console.WriteLine("Computer Restarted [IRestarted]");
        }

        void Idevice.restart()
        {
            Console.WriteLine("Computer Restarted [Idevice]");
        }

        public void restart()
        {
            Console.WriteLine("Normal restart");
        }

    }
}
