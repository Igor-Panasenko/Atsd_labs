using System;

namespace Binary_tree
{
    class Node<T> {
        public T Data;
        public int Height;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T data){
            this.Data = data;
            Height = 1;
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
