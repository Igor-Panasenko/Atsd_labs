using System;

namespace Lab_1_Linked__List
{
    class Node {
        protected int data;
        protected Node next;
        public int Data { get { return data; }  }
        public Node Next { get { return next; } set { next = value; } }

        public Node(int d) {
            data = d;
            next = null;
        }
    }

    class Linked_List {
        public Node head;
        public Linked_List() { }

        public void Delete_List()
        {
            this.head = null;
            Console.WriteLine("List was deleted" + "\n");
        }
        public void Add_node(int new_data)
        {
            Node new_node = new Node(new_data);
            Node temp = this.head;
            if (this.head == null)
            {
                this.head = new_node;
                return;
            }
            while (true)
            {
                if (temp.Next == null)
                {
                    temp.Next = new_node;
                    break;
                }
                if (temp.Data <= new_data && temp.Next.Data>=new_data)
                {
                    Node peremena = temp.Next;
                    temp.Next = new_node;
                    new_node.Next = peremena;
                    break;
                }
                temp = temp.Next;

            }
        }

        public void Print_List()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty, nothing to print");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.Data+", ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }

        public bool Is_Full()
        {
            Console.WriteLine(" LInked list can not be full");
            return false;
        }

        public bool Is_Empty()
        {
            if (this.head != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Linked_List List_A = new Linked_List();
            List_A.Add_node(34);
            List_A.Add_node(68);
            List_A.Add_node(53);
            List_A.Add_node(46);

            List_A.Print_List();

            List_A.Is_Full();
            Console.WriteLine("Now Linked list empty:"+List_A.Is_Empty());

            List_A.Delete_List();
            Console.WriteLine("Now Linked list empty:" + List_A.Is_Empty());


        }
    }
}
