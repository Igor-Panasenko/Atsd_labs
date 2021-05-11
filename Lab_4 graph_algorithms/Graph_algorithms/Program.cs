using System;

namespace Graph_algorithms
{
    class WeightedGraph<T> where T : IComparable {
        private class Edge<T> : IComparable<Edge<T>> where T : IComparable {
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
        public class subset
        {
            public int parent;
            public int rank;
        }

       private int V;
       private int E;
       private Edge<T>[] edge;

       public WeightedGraph(int v, int e)
        {
            this.V = v;
            this.E = e;
            this.edge = new Edge<T>[E];
            for(int i=0; i<e; i++)
            {
                edge[i] = new Edge<T>();
            }
        }
        private int find (subset[] subsets, int i)
        {
            if (subsets[i].parent != i)
            {
                subsets[i].parent = find(subsets, subsets[i].parent);
            }
            return subsets[i].parent;
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
