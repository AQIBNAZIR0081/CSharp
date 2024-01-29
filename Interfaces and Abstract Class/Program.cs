using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;


namespace Interface_and_Abstruct_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });

            foreach (Money money in wallet)
            {
                Console.WriteLine("Bill: " + money.amount);
            }
        }

    }

    /// <!--
    /// > Create the Interface use keyword 'Interface'
    /// > It is convient way to write the Name of Interface with Latter 'I'
    /// > Define the Method in Class body, where Interface is define, rather than in Interface body
    /// > An interface can contain declarations of methods, properties, indexers, and events.
    /// > An interface cannot contain constructors and fields.
    /// > Interface members are by default abstract and public.
    /// > Interface members must be implemented with the public modifier
    /// -->

    /*********************** Interface *************************/

    class Interfaces : IExample
    {

        public void Example()
        {
            Console.WriteLine("Hello, World!");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }

    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }



    ///<!--
    ///> INotifyPropertyChange Interface let us know that the value has changed
    ///> It relay on ComponentModel namespace
    ///> denoted as keyword 'INotifyPropertyChange'
    /// -->

    /********************** INotifyPropertyChange Interface ************************/

    class Examples : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }




    ///<!--
    ///> define a type specific comparison method that our class can implement to order or sort its instances.
    ///> denoted as 'Icomparable'
    /// -->

    /********************** IComparable Interface ************************/

    class Compint : IComparable
    {
        public int examplelength;
        Compint ex1 = new Compint() { examplelength = 2 };

        public int CompareTo(object? obj)
        {
            Compint ex2 = (Compint)obj;
            if (ex1.examplelength == ex2.examplelength)
            {
                return 0;   // when both object has equal value 0 return
            }
            else if (ex1.examplelength > ex2.examplelength)
            {
                return 1; // Object Passed into function is greater than tha object compared to method was called on
            }
            else
            {
                return -1; // first object is greater than the object passed into function
            }
        }
    }



    ///<!--
    ///> Icomparer interface is used to sort elements.
    ///> denoted as 'Icomparer'
    ///> part of system.collection namespace
    /// -->

    /********************** IComparer Interface ************************/

    class Employee
    {
        public int id;
    }

    // if the function return zero, means two ids are equal
    // if the function return negative number, means employee1 ids is greater
    // if the function return positive number, means employee2 ids is greater
    class ComparerInt : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;

            return employee1.id.CompareTo(employee2.id);
        }
    }



    ///<!--
    ///> used to define a method that can be implemented to create a way to determine if instances are equal to one another.
    ///> denoted as 'IEquatable'
    /// -->

    /********************** IEquatable Interface ************************/

    class EquatableInt : IEquatable<Program>
    {
        public string data;
        public bool Equals(Program other)
        {
            if (other == null)
            {
                return false;
            }
            // GetHashCode generate the Hash or number of paticular of data
            return data.GetHashCode().Equals(other.GetHashCode());
        }
    }



    ///<!--
    ///> it takes two object and determines if they are equal.
    ///> it holds in System.Collections.Generic namespace
    ///> denoted as 'IEqualityComparer'
    /// -->

    /********************** IEqualityComparer Interface ************************/

    public class Officer
    {
        Guid id;  // Guid represent the Globaly unique identifier

        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }

    class EqualityComparerInt : IEqualityComparer<Officer>
    {
        public bool Equals(Officer x, Officer y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();
        }
    }



    ///<summary>
    ///> interface is used to iterate foreach loop for custom collection that we create
    ///> this interface allow us to query data using links to something
    ///> lives in System.Collection namespace
    ///> denoted as 'IEnumerable'
    /// </summary>

    /********************** IEnumerable Interface ************************/

    ///<!--
    /// > enumerator is an object that helps us to iterate over a collection of items
    /// > it helps us to understand that where we are currently in the collection
    /// like which item we are on and where the next item is.
    /// -->

    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null)
                {
                    break;
                }
                yield return bill;
            }
        }
    }

    class Money
    {
        public int amount;
    }



    ///<!--
    ///> IEnumerator Interface is used to support simple iteration over a collection that I enumerator works hand to hand with IEnumerable interface.
    ///> lives in System.Collection namespace.
    ///> denoted as 'IEnumerator'.
    /// -->

    /********************** IEnumerator Interface ************************/

    class EnumeratorInterface : IEnumerator
    {
        List<object> items = new List<object>();
        int current;
        public object Current => items[current];

        public bool MoveNext()
        {
            if(items.Count == 0 || items.Count <= 0 )
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }




    ///<!--
    ///> lives in System.Collection namespace.
    ///> denoted as 'ICollection'.
    /// -->

    /********************** ICollection Interface ************************/

    class CollectionInterface : ICollection
    {
        // count property is used the to see the length of the collection
        public int Count => throw new NotImplementedException();


        // IsSynchronized return ture if access to the collection is thread safe, otherwise false.
        public bool IsSynchronized => throw new NotImplementedException();


        // Syncrude property can be used to get an object that will synchronize access to collection
        public object SyncRoot => throw new NotImplementedException();


        // copy the elements of collectoin to an array starting at particular index
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        // return a numerator that iterates over a collection
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }






    /// <!--
    /// > Abstruct Class is a class that must be implemented in any class that derives it
    /// > It can not instantiate
    /// > Used that we can have a common definition of a base class that multiple other classess can subclass and share
    /// -->

    /***************************** Abstruct Class ***********************/

    abstract class Animal { }

    class Dog : Animal { }



    /// <!--
    /// > Abstract Method can be derived in the abstruct class not in the regular class 
    /// > Abstract Class do not have a method body
    /// > Method body or implementation goes inside the child class
    /// > Abstract Method cannot be marked as static or virtual
    /// > They can not be private
    /// -->

    /***************************** Abstruct Method ***********************/

    abstract class Animal2 {
        public abstract void Run(int speed);
    }

    class Dog2 : Animal2 {
        public override void Run(int speed)
        {
            Console.WriteLine("Dog is running at Speed: " + speed );
        }
    }




    /// <!--
    /// > virtaul method has a default code in the base class
    /// > virtual keyword is added to Base Class Method
    /// > override keyword is added to Child Class Method
    /// > base keyword is used to invoke the base class method in the child class
    /// -->

    /***************************** Virtual Method ***********************/

    class BaseClass
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Hello world");
        }
    }

    class ChildClass : BaseClass
    {
        public override void PrintMessage()
        {
            Console.WriteLine("Good Bye");
            base.PrintMessage();
        }
    }




}
