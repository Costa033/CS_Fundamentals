using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Circle : Shape
    {
        public double radius { get; set; }  
        public override double CalcArea()
        {
            return Math.PI * radius * radius;
        }

        public new void PrintType()
        {
            Console.WriteLine("Circular");

        }



    }
}
