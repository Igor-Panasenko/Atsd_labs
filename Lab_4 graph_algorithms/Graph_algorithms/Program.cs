using System;

namespace Graph_algorithms
{
    class WeightedGraph<T> where T : IComparable {
        private class Edge<T>:IComparable<Edge<T>> where T:IComparable {
            public int src;
            public int dest;
            public T weight;

            public int CompareTo(Edge<T> comparerEdge)
            {
                if (this.weight.CompareTo(comparerEdge.weight) > 0)
                {
                    return 1;
                }
                if (this.weight.CompareTo(comparerEdge.weight) < 0)
                {
                    return -1;
                }
                return 0;
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
