using System;


namespace Binary_tree
{
    class Node<T> where T : IComparable<T> {
        public T Data;
        public int Height;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T data){
            this.Data = data;
            Height = 1;
            }

    }

    class Binary_Tree<T>
    {


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
