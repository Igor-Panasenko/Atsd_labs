using System;



namespace Binary_tree
{
    class Node<T> where T : IComparable {
        public T Data;
      
        public Node<T> Left = null;
        public Node<T> Right = null;


        public Node(T data){
            this.Data = data;
            
            }
        public Node() { }
    }

    class Binary_Tree<T> where T: IComparable
    {
        public Node<T> Root { get; set; } = null;
        private int number_elements = 0;
        public int Number_elements { get { return number_elements; } set { number_elements = value; } }
        public Binary_Tree()
        {

        }
        public Binary_Tree(T data)
        {
            this.Number_elements++;
            Root = new Node<T>(data);
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
                current = Balance_Tree(current);
                
            }
            else
            {
                if (current.Data.CompareTo(new_node.Data) < 0)
                {
                    current.Right = InsertRec(current.Right, new_node);
                    current = Balance_Tree(current);
                }
            }
            return current;
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
            Console.WriteLine("Pre order traversal of tree: ");
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
            Console.WriteLine("In order traversal of tree: ");
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
            Console.WriteLine("Post order traversal of tree: ");
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
        public int Size()
        {
            if (this.Number_elements == 0)
            {
                Console.WriteLine("it is nothing in the tree");
            }
            return this.Number_elements;
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        public int GetHeight(Node<T> node)
        {
            int height = 0;
            if (node != null)
            {
                int l = GetHeight(node.Left);
                int r = GetHeight(node.Right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }

        public Node<T> Balance_Tree(Node<T> node)
        {
            int balanced = balance_factor(node);
            if (balanced > 1)
            {
                if (balance_factor(node.Left) > 0)
                {
                    node = Rotate_FullL(node);
                }
                else
                {
                    node = Rotate_LR(node);
                }
            }
            else
                if (balanced<-1)
            {
                if (balance_factor(node.Right) > 0)
                {
                    node = Rotate_RL(node);
                }
                else
                {
                    node = Rotate_FullR(node);
                }
            }
            return node;
        }

        private int balance_factor(Node<T> current)
        {
            int l = GetHeight(current.Left);
            int r = GetHeight(current.Right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node<T> Rotate_FullR(Node<T> parent)
        {
            Node<T> pivot = parent.Right;
            parent.Right = pivot.Left;
            pivot.Left = parent;
            return pivot;
        }
        private Node<T> Rotate_FullL(Node<T> parent)
        {
            Node<T> pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }
        private Node<T> Rotate_LR(Node<T> parent)
        {
            Node<T> pivot = parent.Left;
            parent.Left = Rotate_FullR(pivot);
            return Rotate_FullL(parent);
        }
        private Node<T> Rotate_RL(Node<T> parent)
        {
            Node<T> pivot = parent.Right;
            parent.Right = Rotate_FullL(pivot);
            return Rotate_FullR(parent);
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
            Tree_1.Insert(69);
            Tree_1.Insert(44);
            Tree_1.Insert(10);
            Tree_1.Insert(55);
            Tree_1.Insert(66);
            Tree_1.Insert(25);
            Tree_1.Insert(77);
            Tree_1.Insert(13);
            Tree_1.Insert(88);
            Tree_1.Insert(99);
           
            Binary_Tree<int> Tree_2 = new Binary_Tree<int>();
            Console.WriteLine(Tree_2.IsEmpty());
           

            Tree_1.Preorder();
            Console.WriteLine();
            Tree_1.In_order();
            Console.WriteLine();
            Tree_1.Post_order();
            Console.WriteLine();
            Console.WriteLine(Tree_1.Size());
            Console.WriteLine(Tree_2.Size());
            Console.WriteLine(Tree_1.GetHeight(Tree_1.Root));
            Console.WriteLine(Tree_1.GetHeight(Tree_2.Root));      
          

        }
    }
}
