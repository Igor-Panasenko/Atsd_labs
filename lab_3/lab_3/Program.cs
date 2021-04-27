using System;

namespace lab_3
{

    class BinaryHeap<T> where T : IComparable {

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
        public BinaryHeap (int size){
            this.HeapArray = new T [size + 1];
            this.sizeOfHeap = 0;
            Console.WriteLine("Heap structure was created");

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
