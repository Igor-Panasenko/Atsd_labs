using System;

namespace Zadanie_for_lab_5
{
    public class Node<T> where T : IComparable {
        public T Data;
        public Node<T> Left = null;
        public Node<T> Right = null;
        public Node(T data){
            this.Data = data;
        }
        public Node() { }
    }  

    public class BST<T> where T: IComparable
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
