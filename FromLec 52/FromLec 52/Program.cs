using System.Collections;
using System.Text;

namespace FromLec_52
{
    internal class Program
    {
        private const string Path_Passwords = @"H:\\courses\\Programming\\C#\\Fundamentals_Mohamed_ElMahdy\My_Passwords.txt";
        private static readonly Dictionary<string, string> PasswordRead = new();

        static void Main(string[] args)
        {
            /*
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
            */


            // Lecture 55      Interfaces

            /*
            Idevice d1 = new Computer();
            d1.TurnOFF();
            d1.TurnON();

            d1= new Mobile();
            d1.TurnOFF();
            d1.TurnON();


            IRestart res1 = new Computer();
            res1.restart();

            Idevice res5 = new Computer();
            res5.restart();
            Computer r2= new Computer();
            r2.restart();

            */



            //Lecture 56      DS Array list


            /*
            ArrayList l1= new ArrayList();
            l1.Add(1);
            l1.Add("Sba7oo");
            l1.Add(true);

            l1.AddRange(new int[] { 1, 2, 3, 4 });


            // Not Worked corrected bec of  INT
            //foreach(int i in l1)
            //{
            //    Console.WriteLine(i);
            //}

            foreach(var item in l1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n**************************************************************\n");
            l1.RemoveRange(2, 3);

            foreach(var itm in l1)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine("\n\n**************************************************************\n");

            l1.InsertRange(2, new int[] { 13, 32, 33 });
            l1.Insert(3, "r5ama");
            

            foreach (var itm in l1)
            {
                Console.WriteLine(itm);
            }
            Console.WriteLine($"the 33 member is in index={l1.IndexOf(33)}");

            Console.WriteLine("\n\n**************************************************************\n");

            int x = (int)l1[l1.IndexOf(33)];
            Console.WriteLine($"X = {x}");

            */


            //Lecture 57    


            /*
            var G_list = new List<int>();
            G_list.Add(5);
            G_list.AddRange(new int[] {55,41,66,33});
            foreach (int item in G_list)
            {
                Console.WriteLine(item);
            }
            G_list.Add(-33);
            G_list.Add(0);
            int c = 0;
            foreach (int ite in G_list)
            {
                
                G_list[c] += 33;
                c++;

            }

            Console.WriteLine("\n\n*******************************************************************************************************\n");
            foreach(int item in G_list)
            {
                Console.WriteLine(item);
            }

            */



            // Lecture 58


            /*
            var CommandStack = new Stack<AppendTextCommand>();


           

            var Original = "";

            while (true)
            {
                Console.WriteLine("please enter a command to append or write exit to exit and undo to undo");
                var input = Console.ReadLine();

                if (input.Equals("exit",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                else if (input.Equals("undo",StringComparison.OrdinalIgnoreCase))
                {
                    if(CommandStack.Count>0)
                    {
                        var command = CommandStack.Pop();
                        Original = command.UndoExcute();
                    }
                }

                else
                {
                    var command = new AppendTextCommand(Original, input);
                    Original = command.excuteAppend();
                    CommandStack.Push(command);
                }

            

            }
            */



            //Lecture 59 
            //Password Manager



            //website=password

            ReadPasswords();

            while(true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("[1] List all passwords.");
                Console.WriteLine("[2] Add/Change passwords.");
                Console.WriteLine("[3] Get Password.");
                Console.WriteLine("[4] Delete password");

                Console.WriteLine("*******************************************************************");


                string SelectedOption = Console.ReadLine();

                if(SelectedOption=="1")
                {
                    ListPasswords();
                }

                else if (SelectedOption.Trim() =="2")
                {
                    Add_ChangePasswords();
                }

                else if (SelectedOption.Trim() == "3")
                {
                    GetPassword();
                }

                else if (SelectedOption.Trim() == "4")
                {
                    DeletePassword();
                }

                else
                {
                    Console.WriteLine("Invalid Option");
                    break;
                }





            }








        }


        //To Save Passwords after any Changes
        private static void SavePasswords()
        {
            var strngBlder = new StringBuilder();
            foreach(var item in PasswordRead)
            {
                strngBlder.AppendLine($"{item.Key}={Encrypt.Encrypt0(item.Value)}");
            }


            File.WriteAllText(@"H:\\courses\\Programming\\C#\\Fundamentals_Mohamed_ElMahdy\My_Passwords.txt", strngBlder.ToString());
        }





        //To Read Passwords
        private static void ReadPasswords()
        {
            if (File.Exists(@"H:\\courses\\Programming\\C#\\Fundamentals_Mohamed_ElMahdy\My_Passwords.txt"))
            {
                var ReadAllPass = File.ReadAllText(@"H:\\courses\\Programming\\C#\\Fundamentals_Mohamed_ElMahdy\My_Passwords.txt");
                foreach (var item in ReadAllPass.Split(Environment.NewLine))
                {
                    if(!string.IsNullOrEmpty(item))
                    {
                        var Website_Name = item.Substring(0, item.IndexOf("="));
                        var Passwordoo = item.Substring(item.IndexOf("=") + 1);
                        PasswordRead.Add(Website_Name, Encrypt.Decrypt( Passwordoo));
                    }


                }
            }



        }







        // To delete Passwords
        private static void DeletePassword()
        {
            Console.Write("please enter the website name:\t");
            var webName = Console.ReadLine();

            if (PasswordRead.ContainsKey(webName))
            {
                PasswordRead.Remove(webName);
                SavePasswords();
            }
            else
                Console.WriteLine("Website name is not found");
        }







        //To Get Password
        private static void GetPassword()
        {
            Console.Write("please enter the website name:\t");
            var webName = Console.ReadLine();

            if (PasswordRead.ContainsKey(webName))
                Console.WriteLine($"the {webName} password is {PasswordRead[webName]}");
            else
                Console.WriteLine("Website Password is not found");

        }







        // To Add or Change Password
        private static void Add_ChangePasswords()
        {
            Console.Write("please enter the website name:\t");
            var k = Console.ReadLine();
            Console.WriteLine();
            Console.Write("please enter the PassWord:\t");
            var p = Console.ReadLine();
            Console.WriteLine();

            if (!PasswordRead.ContainsKey(k))
                PasswordRead.Add(k, p);
            else
            {
                PasswordRead[k] = p;
            }

            SavePasswords();

        }








        //To Print Website/Passwords List
        private static void ListPasswords()
        {
            foreach(var item in PasswordRead)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }






    }


     class AppendTextCommand
    {

        private string Original;
        private string Appended;


        public AppendTextCommand(string ori,string appendd)
        {
            Original = ori;
            Appended = appendd;
        }

        public string excuteAppend()
        {
            Original += Appended;
            Console.WriteLine(Original);

            return Original;
        }


        public string UndoExcute()
        {
            Original = Original.Substring(0, (Original.Length - Appended.Length));
            Console.WriteLine(Original);

            return Original;
        }






    }
        




}