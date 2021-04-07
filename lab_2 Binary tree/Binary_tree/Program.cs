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
        private int number_elements = 0;
        public int Number_elements { get { return number_elements; } }
        public Binary_Tree()
        {

        }
        public Binary_Tree(T data)
        {
            this.number_elements++;
            Root = new Node<T>(data);
        }
        public void Insert(T data, Node<T> node)
        {
            if (data.CompareTo(node.Data) > 0)
            {
                if (node.Right == null)
                {
                    this.number_elements++;
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
                        this.number_elements++;
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

        public bool IsFull()
        {
            Console.WriteLine("Binary_tree tree can not be full");
            return false;
        }

        public void Preorder()
        {
            rec_preorder(this.Root);
        }
        private void rec_preorder(Node<T> node) {
            if (node == null)
            {
                return;
            }
         
            Console.Write(node.Data + ", ");
            rec_preorder(node.Left);
            rec_preorder(node.Right);
        }

        public void In_order()
        {
            rec_inorder(this.Root);
        }
        private void rec_inorder(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            rec_inorder(node.Left);
            Console.Write(node.Data + ", ");
            rec_inorder(node.Right);
        }

        public void Post_order()
        {
            rec_postorder(this.Root);
        }

        private void rec_postorder(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            rec_postorder(node.Left);
            rec_postorder(node.Right);
            Console.Write(node.Data+", ");
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
            Tree_1.Insert(44, Tree_1.Root);
            Tree_1.Insert(55, Tree_1.Root);
            Tree_1.Insert(66, Tree_1.Root);
            Console.WriteLine(Tree_1.GetType());
            Tree_1.IsFull();
            Console.WriteLine(Tree_1.IsEmpty());
            Binary_Tree<int> Tree_2 = new Binary_Tree<int>();
            Console.WriteLine(Tree_2.IsEmpty());

           int size= Tree_1.Number_elements;
            Console.WriteLine(size);

            Tree_1.Preorder();
            Console.WriteLine();
            Tree_1.In_order();
            Console.WriteLine();
            Tree_1.Post_order();
            
            



        }
    }
}
