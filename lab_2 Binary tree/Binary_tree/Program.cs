using System;



namespace Binary_tree
{
    class Node<T> where T : IComparable {
        public T Data;
        public int Height = 0;
        public Node<T> Left = null;
        public Node<T> Right = null;

        public Node(T data){
            this.Data = data;
            Height = 1;
            }
        public Node() { }
    }

    class Binary_Tree<T> where T: IComparable
    {
        public Node<T> Root { get; set; } = null;
        public Binary_Tree()
        {

        }
        public Binary_Tree(T data)
        {
            Root = new Node<T>(data);
        }
        public void Insert(T data, Node<T> node)
        {
            if (data.CompareTo(node.Data) > 0)
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(data);
                    return;
                }
                    Insert(data, node.Right);
                    Console.WriteLine("right");
            }
            else
            {
                if (data.CompareTo(node.Data) < 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node<T>(data);
                    }
                    Insert(data, node.Left);
                    Console.WriteLine("Left");
                }
            }
        }

        public bool IsEmpty()
        {
            if (this.Root == null)
            {
                return true;
            }
            else { return false; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node<int> mu_1 = new Node<int>(10);
            Node<string> my_2 = new Node<string>("342");
            Node<double> my_3 = new Node<double>(32.2);
            Node<int> my_4 = new Node<int>(113);
            Node<string> my_5 = new Node<string>("89");
            Node<double> my_6 = new Node<double>(17.2);
            int per2 = mu_1.Data.CompareTo(my_4.Data);
            Console.WriteLine(per2);

            Binary_Tree<int> Tree_1 = new Binary_Tree<int>(45);
            Tree_1.Insert(per2, Tree_1.Root);
            Console.WriteLine(Tree_1.GetType());


        }
    }
}
