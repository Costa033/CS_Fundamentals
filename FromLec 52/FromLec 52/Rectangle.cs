using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public override double CalcArea()
        {
            return length * width;
        }

       
        public override void PrintArea()
        {
            base.PrintArea();
            Console.WriteLine($"this is from virtual {length}X{width}=\t {CalcArea()} ");
        }


        public new void PrintType()
        {
            Console.WriteLine("Rectangular");

        }

    }
}
