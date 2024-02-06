using System.Runtime.CompilerServices;
using System.Collections.Generic;
#nullable disable


namespace DataStructure_and_Collection
{
    class Program
    {
        static LinkedList<string> linklist = new LinkedList<string>();
        static List<int> list = new List<int>() { 1, 3, 5, 4, 2 };
        static SortedList<string, int> valuePairs = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };

        enum Weekdays { sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {
            /// <summary>
            /// Syntex of declairing of array is:
            /// > typeOfArray[] variable = new typeOfArray[length];
            /// > typeOfArray[] variable = new typeOfArray[]{ value of array };
            /// > typeOfArray[] variable 
            /// variable = new typeOfArray[] { values of array };
            /// </summary>

            /****************************** Array *****************************/

            int[] array = new int[] { 1, 2, 3 };
            array[0] = 5;
            Array.Sort(array);

            foreach (int i in array)
            {
                Console.WriteLine("Array of int list :" + i);
            }

            string[] array2 = new string[] { "b", "d", "a", "c" };
            Array.Sort(array2);
            foreach (string i in array2)
            {
                Console.WriteLine("Array of alphabit :" + i);
            }



            ///<summary>
            ///> List is a linear data structure that automatically resource as it grows.
            ///> Lives in System.Collection.Generic namespace.
            ///> Make the List static so that we can references it in the main method
            /// </summary>

            /****************************** List *****************************/

            // count property count the total number in a list
            Console.WriteLine("Total number of list is " + list.Count);

            // capacity property define the capacity of list
            list.Capacity = 10;

            // Add method hold one value to add in the list
            list.Add(6);

            // AddRange method is used to add new list into previous list
            List<int> list2 = new List<int>() { 7, 8 };
            list.AddRange(list2);


            // Binary search method perform a binary search searching for the element that we specify and return the index if the element is found otherwise give a negative number,but make sure the list is sorted first
            list.Sort();
            Console.WriteLine("Index of element 5 is :" + list.BinarySearch(5));

            // contain method show the number exist in the list or not. if exist then return true else return false.
            Console.WriteLine(list.Contains(6));
            Console.WriteLine(list.Contains(20));


            // Insert method takes two arguments, the first one is index,on which the number to be inserted, and the second arguments is inserted number
            list.Insert(0, 9);

            // Insert Range method insert the collection of value in a sublist,a specified index in the original list
            List<int> sublist = new List<int>() { 11, 22, 33, 44 };
            list.InsertRange(1, sublist);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            // Remove Method remove the specified element in the list
            list.Remove(3);

            // RemoveAt Method remove the element from the index in the list 
            list.RemoveAt(0);

            //RemoveRange Method remove the elements in the list giving the range of indexes of elements which we want to remove 
            list.RemoveRange(0, 2);

            // Trim access Method will set the capacity of the list to the actual number of element that the list contains
            List<int> newlist = new List<int>() { 1, 2, 3, 4, 5 };
            newlist.Capacity = 10;
            Console.WriteLine("Capacity before trim: " + newlist.Capacity);
            newlist.TrimExcess();
            Console.WriteLine("Capacity after trim: " + newlist.Capacity);

            // TrueForAll function return ture if the condition met the element in the list 
            bool areNumberLessThen6 = newlist.TrueForAll(x => x < 6);
            Console.WriteLine(areNumberLessThen6);

            // Reverse Method reverse the order of element in the list 
            newlist.Reverse();
            foreach (int i in newlist)
            {
                Console.WriteLine(i);
            }

            // IndexOf find the index of the element in the list 
            Console.WriteLine(newlist.IndexOf(3));

            //LastIndexOf method return the index of last element in the list which is same element with other element in the list
            List<int> Indexlist = new List<int>() { 5, 2, 4, 1, 3, 5, 4 };
            Console.WriteLine("LastIndexOf 4 in thelistis:" + Indexlist.LastIndexOf(4));

            //FindLast method searches for an element that matches a predicate'conditions and returns the last occurence of that element in the list.
            Console.WriteLine(Indexlist.FindLast(x => x < 4));

            // List of Object can hold multiple data type values
            List<object> DifferentDataType = new List<object>() { 1, "a", false };





            ///<summary>
            ///> Stacks work on the bases of LIFO (Last In First Out)
            ///> Capacity of the stack increased when new element is added, when the         capacity is full
            ///> Push(): Add new element into the stack
            ///> PoP(): Remove element from the stack
            ///> Peek(): Get the top element from the stack
            ///> Clear(): Clear the stack 
            /// </summary>

            /****************************** Stacks *****************************/

            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            Console.WriteLine($"Stack hold {stack.Count} number of elements");


            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            Console.WriteLine(stk.Pop());
            Console.WriteLine(stk.Pop());
            Console.WriteLine(stk.Pop());


            // Balanced Bracket

            Console.WriteLine(isBalanced("[{()}]".ToString()));
            Console.WriteLine(isBalanced("{(}]".ToString()));



            ///<summary>
            ///> Queue works on basis of FIFO (First In First Out)
            ///> Enqueue(): Add element into the queue
            ///> Dequeue(): Remove the element from the queue
            ///> Peek(): Get the top element of the queue
            /// </summary>

            /****************************** Queues *****************************/

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());



            /// <summary>
            /// > Enum is a set of named constants to define and meaning.
            /// > Enum are value data type.
            /// > Each new value maped to an integer.
            /// > GetName() allows us to specify an enum and a value and get the name of      the enum member that has the constant vlaue.
            /// > GetNames() method return an array that contains all of the name of the      member of specified enum.
            /// > GetValue() return the integer of elements passed in the enum
            /// </summary>

            /******************************Enum *****************************/

            Console.WriteLine(Enum.GetName(typeof(Weekdays), 6));


            foreach (string s in Enum.GetNames(typeof(Weekdays)))
            {
                Console.WriteLine(s);
            }

            foreach (int i in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine(i);
            }





            ///<summary>
            ///> Dictionaries is not in order, its element are key value pair (KVPs).
            ///> Dictionaries has better look up time due to concept of hashing.
            ///> Dictionaries takes two arguments. The first one is type of key and second is type of value.
            /// </summary>

            /******************************* Dictionaries ******************************/

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("Key1", "value1");
            keyValuePairs.Add("Key2", "value2");
            keyValuePairs.Add("Key3", "value3");

            Console.WriteLine(keyValuePairs.Count);

            foreach (string key in keyValuePairs.Keys)
            {
                Console.WriteLine(key, keyValuePairs[key]);
            }


            string value = " ";
            keyValuePairs.TryGetValue("key1", out value); // safe way to get the value if it exist. otherwise defalut value will be get which is empty string in this case.

            keyValuePairs.Clear(); // clear the pair of key value 




            ///<summary>
            ///> It is the combination of set with the concept of dictionary
            /// </summary>

            /******************************* HashSets ******************************/

            HashSet<char> letter1 = new HashSet<char>() { 'a', 'b', 'c' };
            HashSet<char> letter2 = new HashSet<char>() { 'd', 'e', 'f', 'c', 'a' };

            letter1.IntersectWith(letter2); // Intersect the two sets
            letter1.UnionWith(letter2); // Union the two sets
            letter1.ExceptWith(letter2); // value present in set 'letter1' but not in 'letter2' 
            letter1.SymmetricExceptWith(letter2); // contain values of set 'letter1' which are not in set 'letter2' and which are in set 'letter2' but not in 'letter1' 

            foreach (char letter in letter1)
            {
                Console.WriteLine(letter);
            }





            ///<summary>
            ///> Sorted list is the combination of lists and dictionary.
            ///> It is collection of key values pairs that are sorted by keys.
            ///> Element in sorted list can be access by key or index.
            ///> Contains both capacity and count properties.
            ///> IndexOfKey method is used to get the index of specified key in the List
            /// </summary>

            /******************************* SortedList ******************************/

            valuePairs.Capacity = 10;
            Console.WriteLine($"The capacity of SortedList is: {valuePairs.Capacity}");

            foreach (string key in valuePairs.Keys)
            {
                Console.WriteLine(key);
            }

            valuePairs.Add("key4", 4);
            valuePairs.Remove("key1"); // Remove element in List by Reference
            valuePairs.RemoveAt(0);     // Remove element in List by index

            Console.WriteLine("The Index of key1: " + valuePairs.IndexOfKey("key1"));
            Console.WriteLine("The Index of key2: " + valuePairs.IndexOfKey("key2"));
            Console.WriteLine("The Index of key3: " + valuePairs.IndexOfKey("key3"));



            ///<summary>
            ///> Combine the functionality of list and dictionary
            ///> Generic Comparer is default type of comparer used for sort of dictionary
            /// </summary>

            ///<!--
            /// 1- Sorted list use less memory.
            /// 2- Sorted Dictionary has faster insertion and removal for unsorted data
            /// 3- Sorted List is faster if the list is populated all at once with sorted data
            /// -->

            /*************************** Sorted Dictionary ***************************/
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>()
            {
                {"key1","value1" },
                {"key2","value2" },
                {"key3","value3" }
            };

            sortedDictionary.Add("key4", "value4");

            string val = string.Empty;
            sortedDictionary.TryGetValue("key1", out val); //Get an element of certain key






            ///<summary>
            ///> Contains() functionality of sets but also orderd.
            ///> All the elements must be unique.
            ///> Stored same type of elements inside.
            ///> Stored elements are in ascending order.
            ///> Specified the type inside of the angular brackets that we want the sorted set to contain.
            ///> IsSubSetOf() method will determine if a sorted set is is a subset of the specified collection.
            ///> Overlaps() will return true, if one or more elements that are present in the sorted set are present in specified collection.
            ///> RemoveWhere() define the condition where the current element is greater or smaller that condition element then remove all underneath it.
            ///> Reverse() method reverse the elements in the sortedsets.
            ///> UnionWith() union the new list to existing sorted set.
            ///> ExceptWith() remove all the common element from the sorted set.
            ///> SymmetricExceptWith() remove common element and add the remaning element from list to sorted set.
            ///> IntersectWith() get the common elements in the collection
            /// </summary>

            /*************************** Sorted Sets ***************************/

            bool @var = true;
            SortedSet<int> sets = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            foreach (int item in sets)
            {
                Console.WriteLine(item);
            }

            if (sets.IsSubsetOf(new List<int>() { 1, 2, 3 }))
            {
                Console.WriteLine(@var);
            }

            Console.WriteLine(sets.Overlaps(new List<int>() { 2 }));

            Console.WriteLine(sets.RemoveWhere(x => x <= 3));
            foreach (int elem in sets)
            {
                Console.WriteLine(elem);
            }

            foreach (int i in sets.Reverse())
            {
                Console.WriteLine(i);
            }

            List<int> list3 = new List<int>() { 9, 8, 7, 6 };
            sets.UnionWith(list3);
            foreach (int uni in sets)
            {
                Console.WriteLine(uni);
            }

            List<int> common = new List<int>() { 2, 3 };
            sets.ExceptWith(common);
            foreach (int com in sets)
            {
                Console.WriteLine(com);
            }

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            sets.SymmetricExceptWith(ints);
            foreach (int i in sets)
            {
                Console.WriteLine(i);
            }






            ///<summary>
            ///> Tuples has a specific number and order of element
            ///> Can have anywhere from 1 to 7 element
            ///> Represent a single set of data
            ///> To easily access and manipulate data
            ///> To return multiple values from a method
            ///> pass multiple value into a method using one parameter
            ///> It is immutable data type
            /// </summary>

            /****************************** Tuples *****************************/

            // First way to create Tuple
            Tuple<int> tuple = Tuple.Create(1); // Tuple with one value call Singleton

            // Second way to create Tuple
            Tuple<int> tuple2 = new Tuple<int>(1);

            // Tuple with two value called two tuple or pair
            Tuple<int, int> tuple3 = new Tuple<int, int>(1, 2);

            // Tuple with three values called three tuple or triple
            Tuple<int, int, int> tuple4 = new Tuple<int, int, int>(1, 2, 3);

            // Tuple can hold differen data type
            Tuple<int, string, bool> tuple5 = Tuple.Create(6, "hello", true);






            ///<summary>
            ///> Dynamic in nature and allocate memory as and when required.
            ///> Insertion and deletion are easy to implement 
            ///> Link list is a sequence of data structure connected by links.
            ///> Each link contains data and address of next link.
            ///> AddFirst() add a new node containing the specified value at the start of Linklist.
            ///> AddBefore() adds a new node containing specified value before the specified existing node in the LinKList 
            ///> AddAfter() adds a new node containing specified value after the specified existing node in the LinKList.
            ///> AddLast() adds a new node containing the specified value at the end of LinkList.
            ///> Count Properties count the total number of node present in the linklist.
            ///> Remove() method is used to remove the specific node.
            ///> RemoveFirst() method remove the Root node from linklist
            /// </summary>

            /****************************** Link List *****************************/

            linklist.AddFirst("root");
            linklist.AddAfter(linklist.First, "element");
            linklist.AddBefore(linklist.First, "new root");
            linklist.AddLast("Last element");

            Console.WriteLine(linklist.Count);
            Console.WriteLine(linklist.First.Value);
            Console.WriteLine(linklist.Last.Value);

            // check that if specified node value exist in the linklist
            if (linklist.Contains("root")) { }

            // To find the firt node that contains a specified value
            LinkedListNode<string> node = linklist.Find("root");

            // To find the last node that contains a specified value
            LinkedListNode<string> lastnode = linklist.FindLast("element");

            linklist.Remove("element"); // this method remove the specified value
            linklist.RemoveFirst();  // it will not take any specified value to remove






            ///<summary>
            ///Root: Top node of the tree.
            ///      Only one root per tree.
            ///      Only one path from the root to any node.
            ///Leaf: A node which has no child.
            ///Visiting: Checking a value of a node when control is on the node.
            ///Levels: The generation of node.
            /// </summary>

            /****************************** Trees *****************************/

            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");
            TreeNode<string> d = new TreeNode<string>("d");
            TreeNode<string> e = new TreeNode<string>("e");
            TreeNode<string> f = new TreeNode<string>("f");
            TreeNode<string> g = new TreeNode<string>("g");

            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            b.SetRight(e);
            c.SetLeft(f);
            c.SetRight(g);

            Console.WriteLine("Height of the tree is: " + Example<string>.GetHeight(a));
            PreOrder(a);
            Console.WriteLine("\n\n");
            InOrder(a);
            Console.WriteLine("\n\n");
            PostOrder(a);




            ///<summary>
            ///> A graph is a collection of interconnected nodes.
            ///> It is pair of sets (V, E) where V is vertices and E is Edges.
            ///> Two nodes are adjecent if they are connected by edge.
            ///> A path is a sequence of edges between two vertices.
            ///> Basic Operation that we perform on graphs are: Add Vertex, Add Edge, Display Edge.
            ///> Graph can be represented as Adjacency List or Matrix. 
            /// </summary>

            
            /****************************** Graph *****************************/

            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            Graph graph = new Graph(6);
            graph.AddEdge(six, four);
            graph.AddEdge(four, five);
            graph.AddEdge(four, three);
            graph.AddEdge(five, two);
            graph.AddEdge(five, one);
            graph.AddEdge(three, two);
            graph.AddEdge(two, one);

        }



        ///<!--
        ///------- Graph as Matrix -------
        ///> For a graph with n nodes, it is a 2D array size n * n.
        ///> For a weighted graph, the array element a[n][n] could store weight.
        ///> For non weighted graph a[n][n] could store ture if edges between nodes, false otherwise.
        ///> Determining if an edge exist between nodes. Simply an array lookup time. O(1) constant time.
        ///> Downside of Adjacency matrix- space inefficient - an adjacency matrix require an (n2) element array, so for sparse graph much of the adjacency matrix will be empty.
        ///> For undirected graph, half the graph information just repeated information. 
        /// -->

        /****************************** Graphs *****************************/

        class MatrixGraph
        {
            bool[,] adjacencyMatrix; // bool[,] represent the 2D array which holds either true or false 
            int NumberOfVertice {  get; set; }

            public MatrixGraph(int size)
            {
                NumberOfVertice = size;
                adjacencyMatrix = new bool[size, size];
            }
            public void Add_Edge(int i, int j)
            {
                adjacencyMatrix[i, j] = true;
                adjacencyMatrix[j, i] = true;
            }
            public void Remove_Edge(int i, int j)
            {
                adjacencyMatrix[i, j] = false;
                adjacencyMatrix[j, i] = false;
            }

            public bool IsAdjacenct(int i, int j)
            {
                return adjacencyMatrix[i, j];
            }
        }



        ///<!--
        ///------- Graph as Adjacency List -------
        ///> Graph has a list of its nodes.
        ///> Each node has a list of its neighbor.
        ///> With an undirected graph, there is duplicate edge information.
        ///> Each node has precisely as many nodes in its adjacency list as it has neighbors, very space efficient, you never store more data than needed.
        ///> Downside of adjacency list, to determine if there is a edge from one node to another, it require the node's adjacency list to be searched.(Takes linear time for dense graph).
        ///> AddEdge() takes two parameter. One is source node and other is destination node.
        /// -->

        /****************************** Graphs *****************************/

        public class Node
        {
            public List<object> Neighbors { get; set; }
            public int Data;
            public Node(int data)
            {
                this.Data = data;
            }

            public Node()
            {
            }
        }

        class Graph
        {
            public int NumberOfVertices { get; set; }

            public List<Node> vertices { get; set; }
            public Graph(int size)
            {
                NumberOfVertices = size;
                vertices = new List<Node>();

                for (int i = 0; i < NumberOfVertices; i++)
                {
                    vertices[i] = new Node();
                }
            }
            public void AddEdge(Node source, Node destination)
            {
                source.Neighbors.Add(destination);
                destination.Neighbors.Add(source);
            }
            public void RemoveEdge(Node source, Node destination)
            {
                source.Neighbors.Remove(destination);
                destination.Neighbors.Remove(source);
            }
            public bool ContainsEdge(Node node1, Node node2)
            {
                return node1.Neighbors.Contains(node2);
            }
        }



        /****************************** Tree Orders *****************************/

        // Pre_Order function for tree node traversal
        static void PreOrder(TreeNode<string> root)
        {
            if(root != null)
            {
                Console.WriteLine(root.Getvalue().ToString() + " ");
                PreOrder(root.GetLeft());
                PreOrder(root.GetRight());
            }
        }


        // In_Order function for tree node traversal
        static void InOrder(TreeNode<string> root)
        {
            if( root != null)
            {
                InOrder(root.GetLeft());
                Console.WriteLine(root.Getvalue().ToString()+ " ");
                InOrder(root.GetRight());
            }
        }

        // Post_Order function for tree node traversal
        static void PostOrder(TreeNode<string> root)
        {
            if(root != null)
            {
                PostOrder(root.GetLeft());
                PostOrder(root.GetRight());
                Console.WriteLine(root.Getvalue().ToString()+ " ");
            }
        }
        
        // IsBalanced function for check the tree is balanced or not
        static bool IsBalanced(TreeNode<string> root)
        {
            int diff = 0;

            if(root.GetLeft != null && root.GetRight == null ||
               root.GetLeft == null && root.GetRight != null)
            {
                diff += 1;
            }
            else
            {
                diff = 0;
            }
            return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
        }

        // Link List Concept
        public class LinkList
        {
            public class Node
            {
                public Node next;
                public object data;
            }

            private Node root;
            public Node First
            {
                get { return root; }
            }
            public Node Last
            {
                get
                {
                    Node currentNode = root;
                    if (currentNode == null)
                    {
                        return null;
                    }
                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    return currentNode;
                }
            }

            public void Append(Object value)
            {
                Node node = new Node { data = value };
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }

            public void Delete(Node node)
            {
                if (root == node)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while (current != null)
                    {
                        if (current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
        }

        // Bracket Balanced
        private static bool isBalanced(string inputString)
        {
            Stack<char> OpeningBracket = new Stack<char>();
            Stack<char> ClosingBracket = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    ClosingBracket.Push(c);
                }
            }

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    OpeningBracket.Push(inputString[i]);
                }
            }

            if ((OpeningBracket.Count + ClosingBracket.Count) % 2 != 0)
            {
                return false;
            }

            while (ClosingBracket.Count != 0)
            {
                char currentColingBracket = ClosingBracket.Pop();
                char currentOpeningBracket = OpeningBracket.Pop();

                if ((currentColingBracket == '}' && currentOpeningBracket == '{') ||
                   (currentColingBracket == ']' && currentOpeningBracket == '[') ||
                   (currentColingBracket == ')' && currentOpeningBracket == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }

            }
            return true;

        }

        // Stack Functionalites
        public class Stack
        {
            const int MAX = 1000;
            int top;
            object[] stack = new object[MAX];

            public Stack()
            {
                top = -1;
            }

            public void Push(object item)
            {
                if (top < MAX)
                {
                    stack[++top] = item;
                }
            }

            public object Pop()
            {
                if (top >= 0)
                {
                    object o = stack[top];
                    top--;
                    return o;
                }
                else
                {
                    return -1;
                }
            }

            public object Peek()
            {
                return stack[top];
            }
        }



        ///<summary>
        ///> Struct are more convenient to use because they hold small data value
        ///> Struct can hold field of value type
        ///> Struct can Implement Interfaces just like classes
        ///> Struct cannot be used as base classes and cannot derive another structure or class
        ///> It can not contain parameter list constructor and also not contain destructor
        /// </summary>

        /******************************* Struct ******************************/

        struct Work
        {
            string str;
            int x;
        }

    }


    // Get the Height of tree using GetHeight Method
    public class Example<T>
    {
        public static int GetHeight(TreeNode<T> root)
        {
            if (root == null)
                return 0;
            return Math.Max(GetHeight(root.GetLeft()), GetHeight(root.GetRight()) + 1);
        }    
    }

    // <T> is a genaric type which holds the data type string, bool, int etc.
    public class TreeNode<T>
    {
        T value;
        TreeNode<T> left = null;
        TreeNode<T> right = null;

        public TreeNode(T value)
        {
            this.value = value;
        }

        public TreeNode<T> GetLeft() { return left; }
        public TreeNode<T> GetRight() { return right; }
        public T Getvalue() { return value; }
        public void SetValue(T value) { this.value = value; }
        public void SetLeft(TreeNode<T> node) { left = node; }
        public void SetRight(TreeNode<T> node) { right = node; }
    }
}
