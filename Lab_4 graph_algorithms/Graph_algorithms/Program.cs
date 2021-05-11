using System;

namespace Graph_algorithms
{
    class WeightedGraph<T> where T : IComparable {
        private class Edge<T>:IComparable<Edge<T>> where T:IComparable {
            public int src;
            public int dest;
            public T weight;
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
