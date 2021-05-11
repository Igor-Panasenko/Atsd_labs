using System;

namespace Graph_algorithms
{
    class WeightedGraph<T> where T : IComparable {
        private class Edge<T> : IComparable<Edge<T>> where T : IComparable {
            public int src;
            public int dest;
            public T weight;

            public Edge()
            {
                src = 0;
                dest = 0;
                weight = default(T);
            }
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

        private void union(subset[] subsets, int x, int y)
        {
            int xRoot = find(subsets, x);
            int yRoot = find(subsets, y);
            if (subsets[xRoot].rank < subsets[yRoot].rank)
            {
                subsets[xRoot].parent = yRoot;
            }
            else
            {
                if (subsets[xRoot].rank > subsets[yRoot].rank)
                {
                    subsets[yRoot].parent = xRoot;
                }
                else
                {
                    subsets[yRoot].parent = xRoot;
                    subsets[xRoot].rank++;
                }
            }
        }
        public void KruskalsMST()
        {
            Edge<T>[] result = new Edge<T>[this.V];
            int e = 0;
            int i = 0;
            for(i=0; i<V; ++i)
            {
                result[i] = new Edge<T>();
            }
            Edge<T>[] copy = new Edge<T>[this.edge.Length];
            for(int j=0; j<this.edge.Length; j++)
            {
                copy[i] = edge[i];
            }
            for(int j=0; j<copy.Length; j++)
            {
                for(int k=j; k<copy.Length; k++)
                {
                    if (copy[j].CompareTo(copy[k]) > 0)
                    {
                        Edge<T> temp = copy[j];
                        copy[j] = copy[k];
                        copy[k] = temp;
                    }
                }
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
