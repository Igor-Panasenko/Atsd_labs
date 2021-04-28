﻿using System;

namespace lab_3
{

    class MinHeap<T> where T : IComparable {

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
        public MinHeap (int size){
            this.HeapArray = new T [size + 1];
            this.sizeOfHeap = 0;
            Console.WriteLine("Min Heap structure was created");
            }
        public MinHeap()
        {
            this.HeapArray = new T[9];
            this.SizeOfHeap = 0;
            Console.WriteLine("Min Empty heap structure was created");
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

       private int ParentByIndex(int key)
        {
            return (key - 1) / 2;
        }

        private static void swap(ref T value_1, ref T value_2)
        {
            T temp = value_1;
            value_1 = value_2;
            value_2 = temp;
        }
        private int GetLeft(int key)
        {
            return 2 * key + 1;
        }
        private int GetRight(int key)
        {
            return 2 * key + 2;
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
            MinHeapify(0);
            return root;
            
        }

        public void MinHeapify(int key)
        {
            int left = GetLeft(key);
            int right = GetRight(key);

            int smallest = key;
            if (left < SizeOfHeap && HeapArray[left].CompareTo(HeapArray[smallest]) < 0)
            {
                smallest = left;
            }
            if(right<SizeOfHeap&& HeapArray[right].CompareTo(HeapArray[smallest]) < 0)
            {
                smallest = right;
            }
            if (smallest != key)
            {
                swap(ref HeapArray[key], ref HeapArray[smallest]);
                MinHeapify(smallest);
            }
        }

        public void DeleteByKey(int key)
        {
            DecreaseKey(key, default(T));
            ExtractMin();
        }

        private void IncreaseKey(int key, T new_value)
        {
            HeapArray[key] = new_value;
            MinHeapify(key);
        }
        private void DecreaseKey(int key, T new_val)
        {
            if (new_val.CompareTo(HeapArray[key]) > 0)
            {
                Console.WriteLine("new value must be less");
            }
            HeapArray[key] = new_val;
            while (key != 0 && HeapArray[key].CompareTo(HeapArray[ParentByIndex(key)]) < 0)
            {
                swap(ref HeapArray[key], ref HeapArray[ParentByIndex(key)]);
                key = ParentByIndex(key);
            }
        }
        public void changeValueOnKey(int key, T new_value)
        {
            if (HeapArray[key].CompareTo(new_value) == 0)
            {
                return;
            }
            if (HeapArray[key].CompareTo(new_value) < 0)
            {
                this.IncreaseKey(key, new_value);
                
            }
            if (HeapArray[key].CompareTo(new_value) > 0)
            {
                this.DecreaseKey(key, new_value);
            }
        }
        public void PrintHeap()
        {
            int n = SizeOfHeap;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(HeapArray[i] + ",  ");
            }
        }
    }
    public class Max_heap<T> where T : IComparable
    {

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
        public Max_heap(int size)
        {
            this.HeapArray = new T[size + 1];
            this.sizeOfHeap = 0;
            Console.WriteLine("Max Heap structure was created");
        }
        public Max_heap()
        {
            this.HeapArray = new T[9];
            this.SizeOfHeap = 0;
            Console.WriteLine("Empty Max heap structure was created");
        }

        private int ParentByIndex(int key)
        {
            return (key - 1) / 2;
        }
        private int GetLeft(int key)
        {
            return 2 * key + 1;
        }
        private int GetRight(int key)
        {
            return 2 * key + 2;
        }
        public void insertKey(T value)
        {
            if (this.SizeOfHeap == HeapArray.Length - 1)
            {
                T[] temp = new T[HeapArray.Length * 2];
                for (int j = 0; j < HeapArray.Length; j++)
                {
                    temp[j] = HeapArray[j];
                }
                this.HeapArray = temp;
                Console.WriteLine("max size of heap array increased");
            }
            int i = SizeOfHeap;
            HeapArray[i] = value;
            SizeOfHeap += 1;
            while (i != 0 && HeapArray[i].CompareTo(HeapArray[ParentByIndex(i)]) > 0)
            {
                swap(ref HeapArray[i], ref HeapArray[ParentByIndex(i)]);
                i = ParentByIndex(i);
            }
        }
        private static void swap(ref T value_1, ref T value_2)
        {
            T temp = value_1;
            value_1 = value_2;
            value_2 = temp;
        }
        public void MaxHeapify(int key)
        {
            int left = GetLeft(key);
            int right = GetRight(key);

            int largest = key;
            if (left < SizeOfHeap && HeapArray[left].CompareTo(HeapArray[largest]) > 0)
            {
                largest = left;
            }
            if (right < SizeOfHeap && HeapArray[right].CompareTo(HeapArray[largest]) > 0)
            {
                largest = right;
            }
            if (largest != key)
            {
                swap(ref HeapArray[key], ref HeapArray[largest]);
                MaxHeapify(largest);
            }
        }
        public T ExtractMax()
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
            MaxHeapify(0);
            return root;
        }



        public void PrintHeap()
        {
            int n = SizeOfHeap;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(HeapArray[i] + ",  ");
            }
        }

    }

    public class Heap_Sort<T> where T:IComparable
    {
     public void Sort_ascending( ref T[] arr)
        {
            MinHeap<T> heap = new MinHeap<T>(arr.Length);
            for(int i=0; i<arr.Length; i++)
            {
                heap.insertKey(arr[i]);
            }
            T[] temp_arr = new T[heap.SizeOfHeap];
            for(int i=0; i<temp_arr.Length; i++)
            {
                temp_arr[i] = heap.ExtractMin();
            }
            arr = temp_arr;
        }

        public void Sort_descending(ref T [] arr)
        {
            Max_heap<T> heap = new Max_heap<T>(arr.Length);
            for(int i=0; i<arr.Length; i++)
            {
                heap.insertKey(arr[i]);
            }
            T[] temp_arr = new T[heap.SizeOfHeap];
            for(int i=0; i < arr.Length; i++)
            {
                temp_arr[i] = heap.ExtractMax();
            }
            arr = temp_arr;

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heap_Sort<int> sort_ = new();
            Console.WriteLine("Hello World!");
            int[] arr = {45, 56,78,1,415,16,34 };
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
            sort_.Sort_ascending(ref arr);
            Console.WriteLine();
            for (int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();

            int[] arr_1 = { 45, 56, 78, 1, 415, 16, 34 };
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr_1[i] + ", ");
            }
            Console.WriteLine();
            sort_.Sort_descending(ref arr_1);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr_1[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
