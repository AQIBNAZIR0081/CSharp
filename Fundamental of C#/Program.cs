using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace FirstC_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Null-Coalescing Operator
            Object? obj1 = null;                  // declair as nullable
            Object obj2 = obj1 ?? new Object();
            Console.WriteLine(obj2);

            // Contain Method
            string example = "Helloworld";
            Console.WriteLine((example).Contains("world"));

            // Substring Method
            string myName = "aqibnazir";
            Console.WriteLine((myName).Substring(0, 4));

            // String Formate  in Currency
            int myNum = 1000;
            Console.WriteLine(string.Format("The form Cost is {0:C}", myNum));

            /********************STRING BUILDER ******************************************/

            // StringBuilder class is from System.String 
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World");
            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append(" nice to see you"); // append the string to current string
            }
            String s = stringBuilder.ToString(); // convert the object to string
            Console.WriteLine(s);

            //Append line method in StringBuilder Object
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("Hello world");  // append the string to new line
            sb2.AppendLine("Hello world");
            Console.WriteLine(sb2.ToString());

            // Insert String to StringBuilder
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("My name is nazir");
            sb1.Insert(11, "aqib");              // insert the word in string at specific index
            Console.WriteLine(sb1.ToString());

            // Remove Method in StringBuilder
            StringBuilder sb3 = new StringBuilder("Hello World!");
            sb3.Remove(6, 6);
            Console.WriteLine(sb3.ToString());

            // Replace Method in StringBuilder
            StringBuilder sb4 = new StringBuilder("This is C# Code");
            sb4.Replace("C#", "HelloWorld");          // Replace the old value with new value
            Console.WriteLine(sb4.ToString());
            Console.WriteLine(sb4.Length.ToString());  // Check the length of the String

            /****************************** STRING ***************************************/

            // String IndexOf
            string hello = "myname";
            Console.WriteLine("The IndexOf 'a' in myname is "+""+hello.IndexOf("a"));
            Console.WriteLine("Convert the string 'myname' to Upper case is "+""+hello.ToUpper());
            Console.WriteLine("The Insert method is used to insert in string 'myname' is "+""+hello.Insert(6,"aqib"));
            Console.WriteLine("The Remove method is used to Remove in string 'myname' is "+""+hello.Remove(0,4));

            // Verbatim Identifier (@)
            string @if = "1234";
            Console.WriteLine(@if);

            // Interpolated String ($)
            string name = "aqib";
            Console.WriteLine($"My name is {name}.");

            // Char array
            char[] carray = new char[] { 'T','h','e'};
            foreach(char chr in carray)
            {
                Console.WriteLine(chr);
            }

            // Validating String
            string? str = null;   // the ? mark indicate that the data type is nullable
            Console.WriteLine("To check the value of string, which is 'null', is empty or null = "+string.IsNullOrEmpty(str));

            /****************************** BOOLEAN **************************************/

            // Boolean structure
            bool n = true;
            bool m = false;
            bool? v = null;
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(v);

            // Logical Operator
            bool st = false;
            Console.WriteLine(!st);
            Console.WriteLine(false || true);
            Console.WriteLine(true && false);

            // Compound Assignment support only AND(&), OR(|), XOR (^)
            bool exa = true;
            exa &= true;
            Console.WriteLine("\nCompound Assignment with AND(&) operator = "+exa);

            bool exa1 = false;
            exa1 |= true;
            Console.WriteLine("Compound Assignment with OR(|) operator = " + exa1);

            bool exa2 = true;
            exa2 ^= true;
            Console.WriteLine("Compound Assignment with XOR(^) operator = " + exa2);

            // Boolean Flag technique
            bool flag = false;
            List<int> list = new List<int>(){ 1,2,3};
            foreach(int i  in list)
            {
                if(i == 3)
                {
                    flag = true;
                }
            }
            if(flag) { 
            Console.WriteLine("3 was found!");
            }


            /******************************* TYPES ***************************************/

            // Anonymous Type
            var arr = new[]
            {
                new { Id = 1, firstname = "John", lastname = "Smith"},
                new { Id = 1, firstname = "Josh", lastname = "Buttler"},
                new { Id = 1, firstname = "Dale", lastname = "Philip"}
            };

            var student = new { Id = 1, FirstName = "Aqib", LastName = "Nazir" };
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);


            // Dynamic Type
            dynamic num = 1;
            Console.WriteLine("\nDynamic Type automatically determine the type of variable "+ num) ;

            dynamic MyDynamic = 100;
            Console.WriteLine("Value:{0},Type:{1}", MyDynamic, MyDynamic.GetType());       
            MyDynamic = "Hello World!";
            Console.WriteLine("Value:{0},Type:{1}", MyDynamic, MyDynamic.GetType());
            MyDynamic = 2.3f;
            Console.WriteLine("Value:{0},Type:{1}", MyDynamic, MyDynamic.GetType());
            MyDynamic = DateTime.Now;
            Console.WriteLine("Value:{0},Type:{1}", MyDynamic, MyDynamic.GetType());


            // Values Type
            static void ChangeValue(int x)
            {
                x = 200;
                Console.WriteLine(x);
            }

            int i = 100;
            Console.WriteLine("\n\nValue type are:- ");
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);


            // Reference Type
            
            Person person = new Person();
            person.Name = "OldPerson";
            ChangeReferenceType(person);
            Console.WriteLine(person.Name);


            /*************************** BOXING/UNBOXING *********************************/

            // Boxing (implicit conversion)
            int i = 10;
            object o = i; //performs boxing  , assign the value of int to object
            Console.WriteLine(o);

            ArrayList arrlist = new ArrayList();
            list.Add(10); // boxing
            list.Add("Bill");
            Console.WriteLine(arrlist);


            // Unboxing (explicit conversion) convert a reference type to value
            object O = 10;
            int @ref = (int )O;  // unboxing
            Console.WriteLine(@ref);

            int val = 30;    // does not change in value
            object v = val;
            v = 20;
            Console.WriteLine(val);

            // invalid casting
            int b = 14;
            object c = b;  // boxing
            double d = (double)c;  // runtime error

            // valid casting
            int t = 19;
            object w = t;
            double n = (double)(int)w;
            Console.WriteLine(n);


            /**************************** DATE-AND-TIME **********************************/
            DateTime dt = new DateTime();// create datetime object
            Console.WriteLine(dt.ToString());

            DateTime dt1 = new DateTime(); // assign default date
            Console.WriteLine(dt1.ToString());

            DateTime dt2 = new DateTime(1000,1,23); // assign year,month,day
            Console.WriteLine(dt2.ToString());

            DateTime dt3 = new DateTime(2020, 2, 12, 4, 55, 32); // assign year, month, day, hours, minutes, second
            Console.WriteLine(dt3.ToString());

            DateTime dt4 = DateTime.UtcNow; // Coordinated Universal Time
            Console.WriteLine(dt4);


            // Ticks
            DateTime dt5 = new DateTime(3155378975999999999);
            string maxd = "12/30/9999  11:59:59";
            string mind = "1/1/0001  00:00:01";
            Console.WriteLine($"Time Represented by Static nanosecond input numbers, is: { dt5.ToString()}");
            Console.WriteLine($"The max value for time is: '{DateTime.MaxValue.Ticks}', which is equal to {maxd} ");
            Console.WriteLine($"The min value for time is: '{DateTime.MinValue.Ticks}', which is equal to {mind} ");

            // Formating date and time

            Console.WriteLine("Current Date and time is: "+DateTime.Now.ToString());
            
            Console.WriteLine("Date are formated like 'date/month/year' is: "+ DateTime.Now.ToString("MM/dd/yyyy"));

            Console.WriteLine("Date are formated like 'Sunday, 02 March 2010' is: "+ DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            
            Console.WriteLine("Date are formated like 'Sunday, 02 March 2010 12:44:23' is: "+ DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss"));
            
            Console.WriteLine("Date are formated like '02/12/2020 03:23 (PM/AM)' is: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"));


            // Time Span

            DateTime dat = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dat.Add(ts);
            Console.WriteLine(newDate);     //1/1/2016 1:20:55 AM

            DateTime dat1 = new DateTime(2015, 12, 31);
            DateTime dat2 = new DateTime(2016, 2, 2);
            TimeSpan result = dat2.Subtract(dat1);
            Console.WriteLine(result);        //33.00:00:00


            // Change the Locla time to Universal time and Universal to Local

            Console.WriteLine(DateTime.Now.ToUniversalTime().ToString());

            Console.WriteLine(DateTime.Now.ToLocalTime().ToString());


            /************************** User Inpur and Files *****************************/
             // ReadLine()
             Console.WriteLine("Write some text: ");
             string? userInput = Console.ReadLine();
             Console.WriteLine(userInput);

             // Read()
             Console.WriteLine("Hit a key: ");
             int x = Console.Read();
             Console.WriteLine(Convert.ToChar(x));
            
             // Change the background color of console
             Console.WriteLine("g = 'green', r = 'red', b = 'blue', w = 'white'");
             int z = Console.Read();
             char userinput = (Convert.ToChar(z));

            while (userinput != 'x')
            {
                switch (userinput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("g = 'green', r = 'red', b = 'blue', w = 'white'");
                z = Console.Read();
                userinput = (Convert.ToChar(z));
            }


            //  Get the combination of key modifier
            ConsoleKeyInfo keyinfo;
            Console.TreatControlCAsInput = true;  
            do
            {
                keyinfo = Console.ReadKey();
                if((keyinfo.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    Console.Write("ALT +");
                }
                if((keyinfo.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    Console.Write("SHIFT +");
                }
                if((keyinfo.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    Console.Write("CTRL +");
                }
            }while (keyinfo.Key != ConsoleKey.Escape);


            // User numeric input
            Console.WriteLine("Enter a number:");
            do
            {
                string? Uinput = Console.ReadLine();
                int numer;
                if(!int.TryParse(Uinput,out numer))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invlaid input!");
                    Console.ResetColor();
                    Console.WriteLine("Please enter the correct input!");
                }
                else
                {
                    Console.WriteLine("Thanks... \nEnter the number:");
                }

            } while (true);


            // Working with file Create, Read and Write
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Example.txt"; // Create file path which was going to create

            if(!File.Exists(path))
            {
                File.Create(path);
            }

            FileStream fs = File.Open(path, FileMode.Append);  // Give the mode that what want to do with file.
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World!"); // convert the string to byte array.
            fs.Write(info, 0, info.Length);
            fs.Close();


            StreamReader sr = new StreamReader(path); // Implement TextReader that read character from a byte stream
            string line = sr.ReadToEnd();       // Read the file from Start to End
            Console.WriteLine(line);
        }
        
        static void ChangeReferenceType (Person p)
        {
            p.Name = "NewPerson";
        }

        public class Person()
        {
            public string Name { get; set; }
        }
    }
}