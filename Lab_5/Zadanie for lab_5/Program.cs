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
        public int Number_elements { get { return number_elements; } set { number_elements = value; } }
        public BST()
        {

        }
        public BST(T data)
        {
            Root = new Node<T>(data);
            this.number_elements++;
        }
        public void Insert(T data)
        {
            Node<T> new_node = new Node<T>(data);
            if (this.Root == null)
            {
                this.Number_elements++;
                this.Root = new_node;
            }
            else
            {
                Root = InsertRec(this.Root, new_node);
            }
        }
        private Node<T> InsertRec(Node<T> current, Node<T> new_node)
        {
            if (current == null)
            {
                current = new_node;
                return current;
            }
            if (current.Data.CompareTo(new_node.Data) > 0)
            {
                current.Left = InsertRec(current.Left, new_node);
            }
            else
            {
                current.Right = InsertRec(current.Right, new_node);
            }
            return current;
        }
        public void Preorder()
        {
            Console.WriteLine("Preorder sequance of traversal tree");

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
