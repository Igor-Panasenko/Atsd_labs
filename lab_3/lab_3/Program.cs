using System;

namespace lab_3
{

    class BinaryHeap<T> where T:IComparable {

        public T[] HeapArray;
        private int sizeOfHeap;
        public int SizeOfHeap
        {
            get
            {
                return sizeOfHeap;
            }
            set
            {
                sizeOfHeap = value;
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
