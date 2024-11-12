namespace FromLec_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var rec = new Rectangle { length = 50, width = 20 };
            //rec.PrintArea();

            //Circle circle= new Circle { radius=50};
            //circle.PrintArea();

            Shape s1= new Circle { radius=40};
            //s1.PrintArea();

            s1=new Rectangle { length=33, width=10 };
            s1.PrintArea();
            s1.PrintType();
            Rectangle r33 = new Rectangle();
            r33.PrintType();







        }
    }
}