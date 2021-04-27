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
        public BinaryHeap()
        {
            this.HeapArray = new T[9];
            this.SizeOfHeap = 0;
            Console.WriteLine("Empty heap structure was created");
        }

        public T PeekOfHeap()
        {
            if (SizeOfHeap == 0)
            {
                return default(T);
            }
            else
            {
                return HeapArray[1];
            }
        }

       public int ParentByIndex(int key)
        {
            return (key - 1) / 2;
        }

        private static void swap(ref T value_1, ref T value_2)
        {
            T temp = value_1;
            value_1 = value_2;
            value_2 = temp;
        }
        public int GetLeft(int key)
        {
            return 2 * key + 1;
        }
        public int GetRight(int key)
        {
            return 2 * key + 1;
        }

        public void insertKey (T value)
        {
            if (this.SizeOfHeap == HeapArray.Length - 1)
            {
                T[] temp = new T[HeapArray.Length * 2];
                for(int j=0; j<HeapArray.Length; j++)
                {
                    temp[j] = HeapArray[j];
                }
                this.HeapArray = temp;
                Console.WriteLine("max size of heap array increased");
            }
            int i = SizeOfHeap;
            HeapArray[i] = value;
            SizeOfHeap += 1;
            while (i != 0 && HeapArray[i].CompareTo(HeapArray[ParentByIndex(i)])<0){
                swap(ref HeapArray[i], ref HeapArray[ParentByIndex(i)]);
                i = ParentByIndex(i);
            }
        }

        public void DecreaseKey(int key, T new_val)
        {
            if (new_val.CompareTo(HeapArray[key]) > 0)
            {
                Console.WriteLine("new value must be less");
            }
            HeapArray[key] = new_val;
            while ( key != 0 && HeapArray[key].CompareTo(HeapArray[ParentByIndex(key)]) < 0)
            {
                swap(ref HeapArray[key], ref HeapArray[ParentByIndex(key)]);
                key = ParentByIndex(key);
            }
        }
        public T getMin()
        {
            return HeapArray[0];
        }

        public T ExtractMin()
        {
            if (SizeOfHeap == 0)
            {
                return default(T);
            }
            if (SizeOfHeap == 1)
            {
                SizeOfHeap--;
                return HeapArray[0];
            }

            T root = HeapArray[0];
            HeapArray[0] = HeapArray[SizeOfHeap - 1];
            SizeOfHeap--;
            
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
