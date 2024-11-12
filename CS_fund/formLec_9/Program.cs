using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Transactions;

using CSharp_Fundamentals.Core;



namespace formLec_9
{
    internal class Program
    {

        public enum gender
        {
            Male = 3, 
            female,
        }

        public enum colorz
        {
            white=32, 
            black, 
            yellow,
            orange, 
            lelaah
        }

        /*
        public enum weekdays
        {
            saturday,
            sunday, monday,
            tuesday, wendesday,
                thursday=33, friday,
                

        }

        */



        [Flags]
        public enum WeekDays
        {
            None        = 0b_0000_0000,              //0,       
            saturday    = 0b_0000_0010,              //1,
            monday      = 0b_0000_0100,              //2,
            tuesday     = 0b_0000_1000,              //4,
            wendesday   = 0b_0001_0000,              //8,
            thursday    = 0b_0010_0000,              //16,
            friday      = 0b_0100_0000,              //32,
        }



        static void Main(string[] args)
        {
            /*
            Console.Title = "Welcome man";
            string name;
            Console.Write("please enter your name\t");
            name=Console.ReadLine();
            Console.WriteLine($"Hello, {name} !");

            Console.WriteLine($"the length of ur name is {name.Length }\t");

            Console.WriteLine($"Name to upper case\t {name.ToUpper()}");
            Console.WriteLine($"Name to lower case\t {name.ToLower()}");

            Console.WriteLine(name.StartsWith("Co"));

            Console.WriteLine(name.StartsWith("co"));
            Console.WriteLine(name.StartsWith("coSTA", StringComparison.OrdinalIgnoreCase));    //never mind if it is Upper or Lower 

            Console.WriteLine(name.EndsWith("KE"));
            Console.WriteLine(name.EndsWith("keKe", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(name.Contains("Os"));
            Console.WriteLine(name.Contains("OS", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(name.Replace("Costa", "Essam"));
            Console.WriteLine(name.Replace("Costa", "Essam",StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\n\n*****************************\n");

            string myName = " ";
            Console.Write("please enter your name :\t");
            myName = Console.ReadLine();
            Console.Write($"Hello {myName}, please enter the name you want to replace:");
            string OldName = Console.ReadLine();
            Console.Write("Hello please enter the name you want to replace With:");
            string NewName = Console.ReadLine();

            Console.WriteLine(myName.Replace(OldName, NewName,StringComparison.OrdinalIgnoreCase)+"\t^_^");

            */


            /*
                                                                  //Lecture 10

            // int a = 0;
            // int b = 50;
            // int c = -50;

            //uint ua = 0;
            //uint ub = 50;
            ////uint uc = -50;
            ///



            //int           long            Double                Ushort  
            //Uint          Ulong           float                 short              

            // 1-Memory size      2-Maximum value       3-minimum value 

            //int
            Console.WriteLine($"the memory size of int is : {sizeof(int)}");
            Console.WriteLine($"the minimum value integer can store {int.MinValue}");
            Console.WriteLine($"the Maximum value integer can store {int.MaxValue}");

            Console.WriteLine("****************************************************************");

            //uint
            Console.WriteLine($"the memory size of uint is : {sizeof(uint)}");
            Console.WriteLine($"the minimum value uinteger can store {uint.MinValue}");
            Console.WriteLine($"the Maximum valueu integer can store {uint.MaxValue}");

            Console.WriteLine("****************************************************************");


            //Double
            Console.WriteLine($"the memory size of double is : {sizeof(double)}");
            Console.WriteLine($"the minimum value Double can store {double.MinValue}");
            Console.WriteLine($"the Maximum value Double can store {double.MaxValue}");

            Console.WriteLine("****************************************************************");

            //Float
            Console.WriteLine($"the memory size of float is : {sizeof(float)}");
            Console.WriteLine($"the minimum value Float can store {float.MinValue}");
            Console.WriteLine($"the Maximum value Float can store {float.MaxValue}");

            Console.WriteLine("****************************************************************");


            //Long
            Console.WriteLine($"the memory size of long is : {sizeof(long)}");
            Console.WriteLine($"the minimum value Long can store {long.MinValue}");
            Console.WriteLine($"the Maximum value Long can store {long.MaxValue}");

            Console.WriteLine("****************************************************************");

            //uLong
            Console.WriteLine($"the memory size of ulong is : {sizeof(ulong)}");
            Console.WriteLine($"the minimum value uLong can store {ulong.MinValue}");
            Console.WriteLine($"the Maximum value uLong can store {ulong.MaxValue}");

            Console.WriteLine("****************************************************************");
            */



            //Lecture 11


            //Lecture 12


            //Lecture 13


            //Lecture 14


            //Lecture 15


            //Lecture 16

            /*
            // string -> int
            Console.Write("please enter your birth year :\t");
            string year = Console.ReadLine();
            int x = int.Parse(year);
            Console.WriteLine($"your age now in 2024 is : {2024 - x}");


            // string -> Double
            Console.Write("please enter your birth year :\t");
            string year_ = Console.ReadLine();
            double y = double.Parse(year_);
            Console.WriteLine($"your age now in 2024 is : {2024 - y}");
            */


            //Lecture 17

            /*
            Console.Write("please enter a num to check it :\t");
            string v = Console.ReadLine();
            int num = int.Parse(v);

            if (num == 0)
                Console.WriteLine("Zero is not odd nor even");
            else if (num % 2 == 0)
                Console.WriteLine($"number {num} you entered is Even");
            else
                Console.WriteLine($"number {num} you entered is Odd");
            */


            //Lecture 18


            //Lecture 19
            /*
            int[] videos = { 5, 69, 8, 4, 1, 2, 3, 6 };
            Console.WriteLine(videos[1]);
            Array.Sort(videos);
            Console.WriteLine(videos[1]);
            Console.WriteLine("**************************************\n\n");

            //int[] videos_2 = { };                   // Error because of the number of indexs
            int[] videos_2 = new int[8];


            Array.Copy(videos, videos_2, videos.Length);
            Console.WriteLine(videos_2[1]);
            */


            //Lecture 20

            /*
            int x = 0;
            for (int c=0;c<10;c+=2)
            {
                Console.WriteLine(x);
                x++;
            }
            */

            //Assignment 1

            /*
            // for printing Alphabet letters
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alphabet.Length;i++)
            {
                Console.WriteLine(alphabet[i]);
            }

            // for printing alphapet ASCII code
            string alphabet2 = "Abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alphabet2.Length; i++)
            {
                Console.WriteLine((int)alphabet[i]);
            }


            // for from 0 ---> 9 ASCII 
            string nums = "0123456789";
            for (int c=0;c<=9;c++)
            {
                Console.WriteLine((int)nums[c]);
            }
            */


            //Assignment 2

            /*
            Console.WriteLine("please enter five number:");
            int[] nums = new int[5];
            string trans;
            for (int i=0;i<5;i++)
            {
               trans = Console.ReadLine();
                nums[i] = int.Parse(trans);
            }

            Console.WriteLine("the array u entered before sorting");

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("******************************\n\n");
            Array.Sort(nums);
            Console.WriteLine("the array u entered After sorting\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums[i]);
            }

            */



            // Lecture 21

            /*
             
            for(int i=1;i<=10;i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} is Even");
                else
                    Console.WriteLine($"{i} is Odd");
                
            }

            // the same code is :
            for (int i = 1; i <= 10; i++)
            {
                string stat = (i % 2 == 0 ? $"{i} is Even" : $"{i} is Odd");

                Console.WriteLine(stat);
            }
            */


            //LECTURE 22

            /*
             
            string nums = "123456789";
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(nums[i]);
            }

            // here we can use FOREACH
            Console.WriteLine("\n *******************************************************\n\n with FOREACH\n");
            foreach(char item in nums)
            {
                Console.WriteLine(item);
            }

            // for print ASCII

            Console.WriteLine("\n *******************************************************\n\n with FOREACH Print ASCII\n");

            foreach (int item2 in nums)
            {
                Console.WriteLine(item2);
            }


            foreach (char item3 in nums)
                Console.WriteLine($"{item3} in ASCII = {(int)item3}");

            */


            //LECTURE 23

            // Assignment 1

            /*
            Console.Write("pls enter the array size: ");

            //string p = Console.ReadLine();
            //int[] nums = new int[int.Parse(p)];

            // in another way

            int arrSize = int.Parse(Console.ReadLine());
            int[] nums = new int[arrSize];
            
            //string trans;
            for (int d= 0;d < nums.Length;d++)
            {
                Console.WriteLine($"enter the {d + 1} num in the array");
                //trans = Console.ReadLine();
                nums[d] = int.Parse(Console.ReadLine());
            }

             //int[] nums2 = new int[int.Parse(p)];
            int[] nums2 = new int[nums.Length];
            int u = 0;
            for(int r=(nums.Length-1);r>=0;r--)
            {
                nums2[u] = nums[r];
                u++;
            }

            int f = 1;
            foreach (int item2 in nums)
            {
                Console.WriteLine($"the {f} item in array is: {item2}");
                f++;
            }
            int fe = 1;
            foreach (int item4 in nums2)
            {
                Console.WriteLine($"the {fe} item in array is: {item4}");
                fe++;
            }

                                                    //Assignment 2

            double sum = 0;
            foreach (int itemAv in nums2)
            {
                sum += itemAv;
            }

            Console.WriteLine($"***********************************************\n\nthe Average of the array u entered is = {sum / arrSize}");

            */


            //LECTURE 24


            //LECTURE 25
            /*
            Console.WriteLine("please enter a string");
            string sen=Console.ReadLine();
            Console.WriteLine("if u want to convert it to Upper case enter #1");
            Console.WriteLine("if u want to convert it to Lower case enter #2");
            Console.WriteLine("if u want to convert it to print it enter #3");

            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine(sen.ToUpper());
                    break;
                case 2:
                    Console.WriteLine(sen.ToLower());
                    break;
                case 3:
                    Console.WriteLine(sen);
                    break;
                default: 
                    Console.WriteLine("un valid optiion");
                    break;
            }
            */

            //LECTURE 26

            /*
            int[] numbers = { 1, 2, 33, 2, 62 };
            double ang =Calc_Average_Nums(numbers,false,true);            //First Way
            double AVG = Calc_Average_Nums(numbers, PrintSum: true);       //Second Way
            Console.WriteLine($"the Average from the main =\t{ang}");
            Console.WriteLine($"the Average from the main =\t{AVG}");
            */


            //Lecture 27
            /*
            int[] eng_scores = { 33, 23, 40, 50, 49 };
            double eng_avg = Calc_Average_Nums(eng_scores,true, true);
            */


            //Lecture 28


            /*
             
            Console.Write("please enter the number of items you want to make calculations on them:\t");
            int arrSize = int.Parse(Console.ReadLine());
            int[] nums = new int[arrSize];
            int i = 0;
            for (;i < arrSize;i++)
            {
                Console.Write($"please enter the item number {i+1}:\t");
                nums[i] = int.Parse(Console.ReadLine());

            }
            Print_Arr(nums);

            int small=Find_SmaLLestNum(nums);
            Console.WriteLine($"The smallest number in the array is =\t{small}");

            int biggest = Find_GreatesttNum(nums);
            Console.WriteLine($"The Greatest number in the array is =\t{biggest}");

            Calc_Average_Nums(nums,true);
            */




            // Lecture 30


            /*
            Console.WriteLine("please enter a word to check if it is palindrome or not?");
            string wordd = Console.ReadLine();
            char[] worda = new char[wordd.Length];

            for (int i=0;i<worda.Length;i++)
            {
                worda[i] = wordd[i];
            }

            for (int i = 0; i < worda.Length; i++)
            {
                Console.Write(worda[i]);
            }


            //Console.WriteLine();


            //char[] palindrom = new char[worda.Length];
            //bool IS_palin = false;

            //for (int i = 0; i < worda.Length; i++)
            //{
            //    palindrom[i] = worda[i];
            //}

            //for (int i = 0; i < worda.Length; i++)
            //{


            //    if (palindrom[(worda.Length - i - 1)] == worda[i])
            //    {
            //        IS_palin = true;
            //    }
            //    else
            //    {
            //        IS_palin = false;
            //        break;
            //    }



            //}


            //if (IS_palin == true)
            //    Console.WriteLine("the Word is Palindrome");
            //else
            //    Console.WriteLine("the Word is NOT Palindrome");



            bool tof = IS_Palindrome(worda);

            //if (tof == true)
            //    Console.WriteLine("palindrom");
            //else
            //    Console.WriteLine("Non Palindrome");
            */




            // Lecture 31


            //Lecture 32



            //Lecture 33

            /*
            string str = "Hello MR {0}, My name is {1}";
            Console.WriteLine(str);
            str = string.Format(str, "A7AA", "3MK Cost@");
            Console.WriteLine(str);
            double slas = 10000.5;
            string str2 = "i'm {0}, and my salary is {1:C8}";
            str2 = string.Format(str2, "ENG.Costa", slas);
            Console.WriteLine(str2);
            */



            //Lecture 34



            /*
            Console.WriteLine("please enter a series of nums with separate k letter");
            string stt = Console.ReadLine();

            string[] sttNum = stt.Split("k");
            int sum = 0;
            for(int i=0;i<sttNum.Length;i++ )
            {
                sum += int.Parse(sttNum[i]);
            }

            Console.WriteLine($"Sum is =\t{sum}");


            string[] sba7 = { "sba70", "ya", "Costa" };
            string sb = string.Join(" ", sba7);
            Console.WriteLine(sb);
            */


            //Lecture 35

            /*
            StringBuilder sb = new StringBuilder(4069);
            Console.WriteLine($"the length of StringBuilder =\t{ sb.Length}");
            Console.WriteLine($"the Capacity of StringBuilder =\t{ sb.Capacity}");
            Console.WriteLine($"the MaxCapacity of StringBuilder =\t{ sb.MaxCapacity}");

            sb.Append("Hello ");
            sb.Append("ya ");
            sb.AppendLine("M3rtheen ");
            sb.Append("3MK ");
            sb.Append("Costa");

            Console.WriteLine($"the length of StringBuilder =\t{sb.Length}");
            Console.WriteLine($"the Capacity of StringBuilder =\t{sb.Capacity}");
            Console.WriteLine($"the MaxCapacity of StringBuilder =\t{sb.MaxCapacity}");

            Console.WriteLine(sb.ToString());
            */


            //Lecture 36



            //Lecture 37


            /*
            Student Ahmed= new Student();
            Student Costa= new Student();

            Console.Write("enter your name");
            Ahmed.Name = Console.ReadLine();
            Console.Write("enter your Phone Number");
            Ahmed.PhoneNumber = Console.ReadLine();
            Console.Write("enter your Address");
            Ahmed.Address = Console.ReadLine();


            Student[] studentSS= new Student[5];
            studentSS[0] = Ahmed;
            studentSS[1] = Costa;
            */


            //Lecture 38


            /*
            Student Costa = new Student("Abdo","01154202525","Zaki hawwas");

            Console.WriteLine($"first name:\t{Costa.Name}");
            Console.WriteLine($"first PhoneNumber:\t{Costa.PhoneNumber}");
            Console.WriteLine($"first Address:\t{Costa.Address}");

            */


            //Lecture 39


            /*
            Student s1 = new Student { Name="Costa"};
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.PhoneNumber);
            s1.PhoneNumber = "01254566";
            Console.WriteLine(s1.Address);
            Console.WriteLine(s1.PhoneNumber);
            s1.Address = "MMMMMMMMMMFFFf";
            Console.WriteLine(s1.Address);
            //s1.Name = "jooo";

            */


            //Lecture 40


            //Lecture 41


            /*
            var student1 = new Student();
            */




            //Lecture 42



            //Lecture 43



            //Lecture 44




            //Lecture 45


            /*
            // REF
            bool Successful = true;
            var Resault = divideREF(10, 0, ref Successful);
            Console.WriteLine($"result=\t{Resault}");
            Console.WriteLine($"IsSucessful=\t{Successful}");

            Console.WriteLine("******************************************");
            //OUT
            bool Successful3 = true;
            var Resault2 = divideOUT(10, 0, out Successful3);
            Console.WriteLine($"result=\t{Resault}");
            Console.WriteLine($"IsSucessful=\t{Successful}");

            Console.WriteLine("******************************************");

            Console.Write("please enter a num:\t");
            var Numerical_Input = int.TryParse(Console.ReadLine(), out int number);    //TryParse is very important Method
            Console.WriteLine($"Numerical_Input=\t{Numerical_Input}");
            Console.WriteLine($"number=\t{number}");

            */


            //Lecture 46


            /*
            try
            {

                Console.WriteLine(divide(10, 5));
                Console.WriteLine(divide(10, 0));

                Console.WriteLine("sba700");
            }

            catch (Exception ex) 
            {
                Console.WriteLine("you divided on Zero0o ya ngm");
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor= ConsoleColor.White;
            }
            Console.WriteLine("sba700");
            Console.WriteLine("sba700");


            try
            {
                Console.WriteLine("please enter a num");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Num=\t{num}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("u didn't write a number");
            }

            Console.WriteLine("sba700*****************************************************\n\n");



            // WE MADE THE EXCEPTION

            Console.WriteLine("please enter 5 letters");
            string g=Console.ReadLine();

            try
            {
                if (g.Length != 5)
                    throw new Exception("you must enter 5 letters");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(ex.ToString() );
                Console.ForegroundColor = ConsoleColor.White;
            }
            */




            //Lecture 47


            //gender gender1= gender.Male;
            // gender gender12= gender.female;

            // Console.WriteLine($"{gender1.ToString()} is =\t {(int)gender1}");



            /* foreach(var coloz in Enum.GetNames(typeof(colorz)) )
             {
                 Console.WriteLine($"{coloz} =\t{(int)Enum.Parse(typeof(colorz), coloz)}");
             }

             string colorName = "BlaCk";
              colorz c33 = (colorz)Enum.Parse(typeof(colorz), colorName, true);
              Console.WriteLine($"{c33} = {(int)c33}");
             */

            /*
            while(true){
                Console.WriteLine("please choose an option:");
                Console.WriteLine("[1] change background color\t\t\t[2] change foreground color");
                string selectedOption = Console.ReadLine();

                foreach (var col in Enum.GetNames(typeof(ConsoleColor)))                   // GetNames
                {
                    Console.WriteLine($"{col} =  {(int)Enum.Parse(typeof(ConsoleColor), col)}");
                }

                Console.WriteLine($"select the color you want");
                string colNum = Console.ReadLine();


                ConsoleColor cl = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colNum, true);

                if (int.Parse(selectedOption) == 1)
                    Console.BackgroundColor = cl;
                else if (int.Parse(selectedOption) == 2)
                    Console.ForegroundColor = cl;
                else
                    Console.WriteLine("invalid Option");

                Console.WriteLine("this message is a test for color change");
            }

            */


            //  RRRRREEEEEEEVVVVVVIIIIIIISSSSSSSSSSSSSIIIIIIIIIIIIOOOOOOOOOOOOOOOON
            //REvision 47


            /*
            weekdays day1 = weekdays.friday;

            Console.WriteLine($"{day1.ToString()} = {(int)day1}");


            // LOOP

            foreach(var days in Enum.GetNames(typeof(weekdays)))
            {
                Console.WriteLine($"{days} = {(int)Enum.Parse(typeof(weekdays), days)}");
            }

            Console.WriteLine("*****************************************\n\n");
            string Search_day = "ThuRsday";

            //weekdays day2 = (weekdays)Enum.Parse(typeof(weekdays), Search_day);   // kda lw katb elyoum with upper case m4 hy4taghal
            weekdays day2 = (weekdays)Enum.Parse(typeof(weekdays), Search_day,true);    // kda lw katb elyoum with upper case  hy4taghal 3la tooooool

            Console.WriteLine($"{day2.ToString()} = {(int) day2}");


            // From User
            Console.Write("please enter a day u want to search for:\t");
            string S_D = Console.ReadLine();

            weekdays day33 = (weekdays)Enum.Parse(typeof(weekdays), S_D, true);
            Console.WriteLine($"The day you search for is {day33} = {(int)day33}");



            Console.WriteLine("\n\n*****************************************\n");

            while (true)
            {
                Console.WriteLine("Choose one Choice\n [1] change background clolr\t\t\t\t[2] change foreground color");
                int UserChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Here are the colors we can change to it:");

                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                {
                    Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(ConsoleColor), color)}");
                }

                Console.Write("please enter a color name: ");
                string SelectedColor = Console.ReadLine();

                ConsoleColor NewColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), SelectedColor, true);

                if (UserChoice == 1)
                    Console.BackgroundColor = NewColor;

                else if (UserChoice == 2)
                    Console.ForegroundColor = NewColor;
                else
                    Console.WriteLine("Invalid option");

            }
            */

            //Lecture 48


            /*
            WeekDays d1 = WeekDays.friday | WeekDays.saturday;
            Console.WriteLine(d1);

            WeekDays d2 = WeekDays.tuesday | WeekDays.thursday;

            WeekDays d3 = (d1 | d2);
            Console.WriteLine(d3);

            WeekDays d4 = d3 & WeekDays.friday;
            Console.WriteLine(d4);

            Console.WriteLine(d2 & ~WeekDays.friday &~WeekDays.tuesday);

            Console.WriteLine(d3 ^ WeekDays.wendesday);
            Console.WriteLine(d3 ^ WeekDays.wendesday^WeekDays.thursday);
            */




            //Lecture 49


            /*
            while (true)
            {
                Console.Write("[1] Generate random numbers\t\t\t\t[2]Generate random string\nPlease choose:\t");
                var select = Console.ReadLine();

                if (int.Parse(select) == 1)
                    GenerateRandomNumber();
                else if (int.Parse(select) == 2)
                    GenerateRandomString();
                else
                {
                    Console.WriteLine("Invalid option");
                    break;
                }
                Console.WriteLine("************************************************");
            }
            */


            // Assignment of lecture 49
            /*
            while(true)
            {

            
            Console.Write("[1] Generate random numbers\t\t\t\t[2]Generate random string\nPlease choose:\t");
            var select = Console.ReadLine();

            if (int.Parse(select) == 1)
            {
                int mn, mx;
                Console.Write("enter the minimum value:\t");
                mn = int.Parse(Console.ReadLine());
                Console.Write("enter the Maximum value:\t");
                mx = int.Parse(Console.ReadLine());
                GenerateRandomNumberUserDefined(mn, mx);

            }
            else if (int.Parse(select) == 2)
            {
                Console.Write("please enter the string length:\t");
                int LengthString=int.Parse(Console.ReadLine());
                    if(LengthString<=0)
                    {
                        Console.WriteLine("Can't generate a string with zero or negative number of letters");
                        break;
                    }

                   

                    Console.Write("Do you want the string include Capital letters? (true OR false)");
                    bool CapitalL=bool.Parse(Console.ReadLine());
                    Console.Write("Do you want the string include Small letters? (true OR false)");
                    bool Smallle = bool.Parse(Console.ReadLine());
                    Console.Write("Do you want the string include Numbers? (true OR false)");
                    bool Numbersss = bool.Parse(Console.ReadLine());
                    Console.Write("Do you want the string include Symbols? (true OR false)");
                    bool Symbools = bool.Parse(Console.ReadLine());

                    GenerateRandomStringUserDefined(LengthString,CapitalL,Smallle,Numbersss,Symbools);
            }
            else
            {
                Console.WriteLine("Invalid option");
                break;
            }
            Console.WriteLine("************************************************");


            }

            */



            //Lecture 50


            /*
            while (true)
            {
                Console.Write(">>>");
                var Input = Console.ReadLine().Trim();
                var SpaceLocation = Input.IndexOf(' ');

                var Command = Input.Substring(0, SpaceLocation).ToLower();
                var Path = Input.Substring(SpaceLocation + 1).Trim();

                Console.WriteLine(Command);
                Console.WriteLine(Path);


                if(Command=="list")
                {
                    Console.WriteLine("The Directories:");
                    foreach(var Dir in Directory.GetDirectories(Path))
                    {
                        Console.WriteLine(Dir);
                    }

                    Console.WriteLine("The Files:");
                    foreach (var Dir in Directory.GetFiles(Path))
                    {
                        Console.WriteLine(Dir);
                    }
                }


                else if(Command=="info")
                {
                    if (Directory.Exists(Path))
                    {
                        var DirInfo = new DirectoryInfo(Path);
                        Console.WriteLine("Path is For Directory" );
                        Console.WriteLine($"Creation time : {DirInfo.CreationTime}" );
                        Console.WriteLine($"Last write time in : {DirInfo.LastWriteTime}" );
                      
                    }

                    else if (File.Exists(Path))
                    {
                        var FileeInfo = new FileInfo(Path);
                        Console.WriteLine("Path is For File");
                        Console.WriteLine($"Creation time : {FileeInfo.CreationTime}");
                        Console.WriteLine($"Last write time in : {FileeInfo.LastWriteTime}");
                        Console.WriteLine($"Size in bytes : {FileeInfo.Length}");

                    }
                    else
                        Console.WriteLine("the Path is not Right!!!");


                }


                else if (Command == "mkdir")
                {
                    Directory.CreateDirectory(Path);
                }



                else if (Command == "print")
                {
                    var texto=File.ReadAllText(Path);
                    Console.WriteLine(texto);
                }



                else if (Command == "write")
                {
                    File.WriteAllText(Path, "mayten elle faaat");
                }


                else if (Command == "append")
                {
                    File.AppendAllText(Path,"a777laa msa 3leke");
                }


                else if (Command == "remove")
                {
                    if(Directory.Exists(Path))
                        Directory.Delete(Path);
                    if(File.Exists(Path))
                        File.Delete(Path);
                }


                else if (Command=="exit")
                {
                    break;
                }



            }


            */



            //Lecture 51


            while (true)
            {
                Console.WriteLine("please enter math expresion");
                var input = Console.ReadLine();
                var expr = ExpressionParser.Parsez(input);
                Console.WriteLine($"Left side=   {expr.LeftSideOperand}\t\t \t\t the operation is:  {expr.Symbol}\t\t \t the right side:  {expr.RightSideOperand}");


                Console.WriteLine($" {input} = {Evaluate_Expresion(expr)}");
            
            }






        }



        static public double Evaluate_Expresion(ExpressionOperands input)
        {

            //Addition
            if(input.Symbol==OperationSymbols.addition)
            {
                return input.LeftSideOperand + input.RightSideOperand;
            }

            //Subtraction
            else if (input.Symbol == OperationSymbols.subtraction)
            {
                return input.LeftSideOperand - input.RightSideOperand;
            }

            //Multiblication
            else if (input.Symbol == OperationSymbols.multiblication)
            {
                return input.LeftSideOperand * input.RightSideOperand;
            }

            //Division
            else if (input.Symbol == OperationSymbols.division)
            {
                return input.LeftSideOperand / input.RightSideOperand;
            }

            //Modulus
            else if (input.Symbol == OperationSymbols.modulus)
            {
                return input.LeftSideOperand % input.RightSideOperand;
            }


            //Power
            else if (input.Symbol == OperationSymbols.power)
            {
                return Math.Pow(input.LeftSideOperand,input.RightSideOperand);
            }


            //Sin
            else if (input.Symbol == OperationSymbols.sin)
            {
                return Math.Sin(input.RightSideOperand);
            }


            //Cos
            else if (input.Symbol == OperationSymbols.cos)
            {
                return Math.Cos(input.RightSideOperand);
            }


            //Tan
            else if (input.Symbol == OperationSymbols.tan)
            {
                return Math.Tan(input.RightSideOperand);
            }


            return 0;
        }





        private const string Buffer = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";
        private const string BufferMain = "abcdefghijklmnopqrstuvwxyz,ABCDEFGHIJKLMNOPQRSTUVWXYZ,0123456789,!@#$%^&*()_+";


        static void GenerateRandomString()
        {
            var rnd = new Random();
            var StringBuilder_16 = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                var rnd_Index = rnd.Next(0, (Buffer.Length - 1));
                StringBuilder_16.Append(Buffer[rnd_Index]);
            }


            Console.WriteLine($"Random string is : {StringBuilder_16}");

        }

        private static void GenerateRandomStringUserDefined(int stringLength,bool CapitalL,bool Smalll, bool Nums,bool Symbols)
        {
            var stRnd=new StringBuilder();
            var rndom = new Random();
            string[] Mchoices=BufferMain.Split(",");

            var ChoosedBuffer = new StringBuilder();
            if (CapitalL)
            {
                ChoosedBuffer.Append(Mchoices[1]);

            }
            if (Smalll)
            {
                ChoosedBuffer.Append(Mchoices[0]);

            }
            if (Nums)
            {
                ChoosedBuffer.Append(Mchoices[2]);

            }
            if (Symbols)
            {
                ChoosedBuffer.Append(Mchoices[3]);

            }

            for (int i=0;i<stringLength;i++)
            {
                var rndomSelect=rndom.Next(0, (ChoosedBuffer.Length-1));
                stRnd.Append(ChoosedBuffer[rndomSelect]);
            }

            

            
            Console.WriteLine($"the string Generated:\t{stRnd}");
        }

        private static void GenerateRandomNumberUserDefined(int minValue, int maxValue)
        {
            var rnd = new Random();
            var Value = rnd.Next(minValue, maxValue);
            Console.WriteLine($"the random value =\t  {Value}");

        }

        static void GenerateRandomNumber()
        {
            var rnd = new Random();
            var value = rnd.Next(1000, 9999);
            Console.WriteLine($"Random Number : {value}");
        }






        











        static double divide(int a, int b)
        {
            return a / b;
        }

        static double divideREF(double dividend, double divisor, ref bool IS_successful)
        {
            if(divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero");
                IS_successful = false;
                return 0;
            }
            IS_successful= true;
            return dividend / divisor;
        }

        static double divideOUT(double dividend, double divisor, out bool IS_successful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero");
                IS_successful = false;
                return 0;
            }
            IS_successful = true;
            return dividend / divisor;
        }

        /// <summary>
        /// method to calculate the sum and return the average of array os nums
        /// </summary>
        /// <param name="j">the array of nums we calculate it's anerage</param>
        /// <param name="PrintAvg">Printing Average or not</param>
        /// <param name="PrintSum">Printing Sum or not</param>
        /// <returns> returns the average value</returns>
        static double Calc_Average_Nums(int[] j, bool PrintAvg=false , bool PrintSum=false)
        {
            double sum=0.0;
            bool print = PrintAvg;
            bool Psum = PrintSum;
            foreach(int i in j)
            {
                sum+=i;
            }
            if (PrintAvg == true)
                Console.WriteLine($"the average of the array =\t{sum / j.Length}");
            if (Psum == true)
                Console.WriteLine($"the sum of nums is =\t{sum}");
            
            return sum / j.Length;
        }

        /// <summary>
        /// Method to print an array
        /// </summary>
        /// <param name="a2">the array u want to print</param>
        static void Print_Arr(int[]a2)
        {
            int i = 0;
            foreach (int item in a2)
                Console.WriteLine($"the item #{++i}=\t {item}");
        }

        /// <summary>
        /// Method to find the smallest number of an array
        /// </summary>
        /// <param name="k5">the array we want to seach on it</param>
        /// <returns>return the smallest item value</returns>
        static int Find_SmaLLestNum(int[] k5)
        {
            int small = k5[0];
            foreach(int item in k5)
            {
                if (small > item)
                    small = item;
            }

            return small;
        }

        /// <summary>
        /// Method to find the greatest number of an array
        /// </summary>
        /// <param name="k6">the array we want to seach on it</param>
        /// <returns>return the Greatest item value</returns>
        static int Find_GreatesttNum(int[] k6)
        {
            int big = k6[0];
            foreach (int item in k6)
            {
                if (big < item)
                    big = item;
            }

            return big;
        }

        /// <summary>
        /// Method to check if the word is palindrome or not
        /// </summary>
        /// <param name="word">the word array you want to check it</param>
        /// <returns>return true if it palindrome and false if it not</returns>
        static bool IS_Palindrome(char[] word)
        {
            char[] palindrom = new char[word.Length];
            bool IS_palin = false;

            for (int i = 0; i < word.Length; i++)
            {
                palindrom[i] = word[i];
            }
            

            for (int i=0 ; i<word.Length ; i++)
            {
                
               if (palindrom[(word.Length-i-1)] == word[i])
                {
                    IS_palin = true;
                }
               else
                {
                        IS_palin = false;
                        break;
                }

                
            }


            if (IS_palin == true)
                Console.WriteLine("the Word is Palindrome");
            else
                Console.WriteLine("the Word is NOT Palindrome");

            return IS_palin;
        }

    }
}