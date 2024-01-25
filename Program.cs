using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Functions
{
    public class Program
    {
        int constructExample;

        /****************************** Constructor *****************************/
        public Program(int num)
        {
            constructExample = num;
        }

        /**************************** Finalizer / Destructor ********************/
        ~Program()
        {

        }

        /**************************** Properties******************************/
        // One way to set Properties
        public string Id { get; set; }

        // Second way to set Properties
        private string id;
        public string Name
        {
            // by removing the get properties we can only write the value
            get
            {
                return id;
            }

            // by removing the set properties we can only read the value
            set
            {
                id = value;
            }
        }

        static void Main(string[] args)
        {

            Program pro = new Program(5);
            Console.Write(pro.constructExample); // access the variable using constructor object

            /* Program program = new Program();
             program.id = "1234";                 
             Console.WriteLine(program.id);*/




            ///<summary>
            ///Anonymous Function is a function with no name, no return type
            ///Anonymous Function used Lamda Expression which is denoted by '=>'
            /// </summary>

            /********************Anonymous Fun.and Lamda Expression***********************/

            // Statement Lamda
            Action action = () => Console.WriteLine("Hello world");
            action();

            // Expression Lamda
            Action debug = () =>
            {
                Console.WriteLine("Hi");
                Console.WriteLine("How are you");
                Console.WriteLine("What are you doing");
            };
            debug();

            // Variable in Lamda
            Action<string> action1 = (s) => Console.WriteLine(s);
            action1("Example");


            /********************* Func Delegation ************************/

            Func<int, int, int> multiply = (x, y) => { return x * y; };
            Console.WriteLine(multiply(3, 2));


        }


        /********************* Optional Parameters ************************/

        public class PrintMessage
        {
            static void Message(int requiredParameter, string optionalParametes = "hi, how do you do")
            {
                Console.WriteLine(optionalParametes);
            }

            // this Main method is used to understand the concept of Optional Parameters, but it is not actual Main method
            public static void Main(String[] args)
            {
                Message(6);   // here default value will be printed if required parameter is not peresent 
                Message(2, "Other message"); // here passing value will be printed
            }
        }



        ///<summary>
        ///Overriding method is used to override the 
        ///values of parent class method
        /// </summary>

        /********************* Overriding ************************/

        public class myName
        {
            public void Test()
            {
                Console.WriteLine("My name is");
            }
        }

        public class myName2 : myName
        {
            public void Test()
            {
                Console.WriteLine("Aqib nazir");
            }

            // this Main method is used to understand the concept of Overriding, but it is not actual Main method
            static void Main(String[] args)
            {
                myName2 mn2 = new myName2();
                mn2.Test();         // override the value of function of parent class
            }
        }




        /// <summary>
        /// Overloading can be possible by changing following properties 
        /// with same function name
        /// 1- number of parameter
        /// 2- order of parameter
        /// 3- type of parameter
        /// </summary>

        /******************** Overloading ***********************/
        void Ex() { }
        void Ex(int number) { }
        void Ex(int number1, int number2) { }
        void Ex(string word, string word1) { }
        void Ex(int number3, string word2) { }


    }




    /// <summary>
    /// > Extension Method is additional method that can be added to class
    /// without modifying or deriving from original class
    /// > Class which hold the Extension Method must be 'Static'
    /// > The first parameter of any extension method specifies the type
    /// that it is going to operate on Preceded by 'this' keyword
    /// </summary>

    /******************** Extension Method ***********************/
    public static class ExtensionMethod
    {
        public static bool GraterThan(this int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // this Main method is used to understand the concept of Extension Method, but it is not actual Main method
        static void Main(string[] args)
        {
            Console.WriteLine(2.GraterThan(1));
        }
    }


    /// <summary>
    /// > Async method is used to run the program simultaniosly without waiting 
    /// for one function to complete the execution
    /// </summary>

    /******************** Async, await Method ***********************/

    public class AsyncMethod
    {
        static async Task CookMeat()
        {
            Console.WriteLine("1- Make Meat");
        }

        static async Task CookVegetable()
        {
            Console.WriteLine("2- Make Vegetable");
        }
        static async Task MakeBread()
        {
            Console.WriteLine("3- Make Bread");
        }
        static async Task MakeSoup()
        {
            Console.WriteLine("4- Make Soup");
        }
        static async Task MakeSalad()
        {
            Console.WriteLine("5- Make Salad");
        }
        static async void MakeDinner()
        {
            await CookMeat();
            await CookVegetable();
            await MakeBread();
            await MakeSoup();
            await MakeSalad();
        }

        // this Main method is used to understand the concept of Async Funtion, but it is not actual Main method
        static void Main(String[] args)
        {
            MakeDinner();
        }
    }
}

