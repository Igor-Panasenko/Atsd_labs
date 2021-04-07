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
        public Node<T> root { get; set; } = null;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          /*  Node<int> mu_1 = new Node<int>(10);
            Node<string> my_2 = new Node<string>("342");
            Node<double> my_3 = new Node<double>(32.2);
            Node<int> my_4 = new Node<int>(113);
            Node<string> my_5 = new Node<string>("89");
            Node<double> my_6 = new Node<double>(17.2);
            mu_1.Left = my_3;*/
        }
    }
}
