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
        public Node<T> Root { get; set; } = null;
        private int number_elements = 0;
        public BST()
        {

        }
        public BST(T data)
        {
            Root = new Node<T>(data);
            this.number_elements++;
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
