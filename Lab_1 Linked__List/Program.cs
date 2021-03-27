using System;

namespace Lab_1_Linked__List
{
    class Node {
        protected int data;
        protected Node next;
        public int Data { get { return data; } }
        public Node Next { get { return next; } }

        public Node(int d) {
            data = d;
            next = null;
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
