namespace C_sharp_fund_console_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string statmentToPrint = "Hello Fucken World";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(statmentToPrint);

            Console.BackgroundColor= ConsoleColor.Gray;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Write("sjlnlg");

            Console.Title = "Essam";
            Console.Write("\tCosta\n");
            Console.ReadKey();
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor=ConsoleColor.White;


            bool f = false;
            Boolean ff = true;
            bool result = f && ff;
            bool result3 = f || ff;
            bool result4 = ! ff;        //false
            bool result5 = f ^ ff;      // true
            Console.Write("the AND result is"); 
            Console.WriteLine(result);
            Console.Write("the OR result 3 is");
            Console.WriteLine(result3);
            Console.Write("the NOT result 4 is");
            Console.WriteLine(result4);
            Console.Write("the XOR result 5 is");
            Console.WriteLine(result5);

            f = true;
            result= f && ff;
            Console.Write("the result is");
            Console.WriteLine(result);

            Console.WriteLine("\n\n\n\n******************************************************\n\n\n");

            char x = 'A';
            Console.WriteLine((int)x);
            x = 'B';
            Console.WriteLine((int)x);
            x = 'C';
            Console.WriteLine((int)x);
            x = 'D';
            Console.WriteLine((int)x);
            x = 'E';
            Console.WriteLine((int)x);
            x = 'F';
            Console.WriteLine((int)x);
            x = 'G';
            Console.WriteLine((int)x);
            x = '0';
            Console.WriteLine((int)x);
            x = '1';
            Console.WriteLine((int)x);
            x = '2';
            Console.WriteLine((int)x);
            Console.WriteLine(x);
            Console.WriteLine(x);


            Console.WriteLine("\n\n\n\n******************************************************\n\n\n");

            string k = "Costa";
            Console.WriteLine($"hello {k}\t today we want to start learning c#");
            Console.WriteLine("hello " + k +"\t today we want to start learning c#");

            string l = @"\n\t if you go too 
this fuckin glaa
you will die";
            Console.WriteLine(l);






        }
    }
}