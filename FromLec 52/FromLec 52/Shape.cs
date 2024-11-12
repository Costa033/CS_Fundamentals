using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal abstract class Shape
    {
        public abstract double CalcArea();

        public virtual void PrintArea()
        {
            Console.WriteLine($" The Area=\t{CalcArea()}");
        }


        public void PrintType()
        {
            Console.WriteLine("Shape");
        }


    }
}
