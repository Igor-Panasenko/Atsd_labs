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
            rec_preorder(this.Root);
        }
        private void rec_preorder(Node<T> node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write(node.Data + ", ");
            rec_preorder(node.Left);
            rec_preorder(node.Right);
        }
        public bool IsEqual(BST<T> other_tree)
        {
            Node<T> root1 = this.Root;
            Node<T> root2 = other_tree.Root;
            int Equal_factor = rec_equal(root1, root2);
            if(Equal_factor == 1)
            {
                Console.WriteLine("Trees are Equal");
                return true;
            }
            else
            { 
               Console.WriteLine("Trees are NOT equal");
               return false;    
            }
        }
        public int rec_equal(Node<T> root1, Node<T> root2)
        {
            if (root1 == null && root2 == null)
            {
                return 1;
            }
            else
            {
                if (root1 != null && root2 == null)
                {
                    return 0;
                }
                else
                    if (root1 == null && root2 != null)
                {
                    return 0;
                }
                else
                {
                    if(root1.Data.CompareTo(root2.Data) == 0 && rec_equal(root1.Left, root2.Left)==1 && rec_equal(root1.Right, root2.Right) == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
