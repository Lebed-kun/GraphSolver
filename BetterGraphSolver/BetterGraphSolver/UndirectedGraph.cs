using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGraphSolver
{
    public class UndirectedGraph
    {
        int V; //Число вершин

        LinkedList<int>[] adj; //Массив списков смежных вершин

        public int Vertx { get { return V; } }
        public LinkedList<int>[] Adj { get { return adj; } }

        public UndirectedGraph(int V)
        {
            this.V = V;
            adj = new LinkedList<int>[V];

            for (int v = 0; v < V; v++) {
                adj[v] = new LinkedList<int>();
            }
        }

        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
            adj[w].AddLast(v);
        }

        public bool hasEdge(int v, int w)
        {
            foreach (int i in adj[v])
            {
                if (i == w)
                {
                    return true;
                }
            }
            return false;
        }

        void DFSUtil(int v, bool[] visited, LinkedList<int> comp)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            comp.AddLast(v);

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int i in adj[v])
            {
                if (!visited[i])
                    DFSUtil(i, visited, comp);
            }
        }

        public LinkedList<int>[] connectedComps()
        {
            bool[] visited = new bool[V];
            LinkedList<int>[] comps = new LinkedList<int>[V];

            for (int v = 0; v < V; v++)
            {
                visited[v] = false;
                comps[v] = null;
            }

            for (int v = 0; v < V; v++)
            {
                if (!visited[v])
                {
                    LinkedList<int> comp = new LinkedList<int>();
                    DFSUtil(v, visited, comp);
                    comps[v] = comp;
                }
                
            }

            return comps;
        }

        // A recursive function that finds and prints bridges using
        // DFS traversal
        // u --> The vertex to be visited next
        // visited[] --> keeps tract of visited vertices
        // disc[] --> Stores discovery times of visited vertices
        // parent[] --> Stores parent vertices in DFS tree

        private int time;
        void bridgeUtil(int u, bool[] visited, int[] disc,
            int[] low, int[] parent, LinkedList<Tuple<int, int>> brids)
        {
            // Mark the current node as visited
            visited[u] = true;

            // Initialize discovery time and low value
            disc[u] = low[u] = ++time;

            foreach (int i in adj[u])
            {
                int v = i;

                // If v is not visited yet, then recur for it
                if (!visited[v]) {
                    parent[v] = u;
                    bridgeUtil(v, visited, disc, low, parent, brids);

                    // Check if the subtree rooted with v has a 
                    // connection to one of the ancestors of u
                    low[u] = Math.Min(low[u], low[v]);

                    // If the lowest vertex reachable from subtree 
                    // under v is  below u in DFS tree, then u-v 
                    // is a bridge
                    if (low[v] > disc[u])
                        brids.AddLast(new Tuple<int, int>(u, v));
                }

                // Update low value of u for parent function calls.
                else if (v != parent[u])
                    low[u] = Math.Min(low[u], disc[v]);
            }
        }

        public LinkedList<Tuple<int, int>> bridge()
        {
            // Mark all the vertices as not visited
            time = 0;
            bool[] visited = new bool[V];
            int[] disc = new int[V];
            int[] low = new int[V];
            int[] parent = new int[V];

            LinkedList<Tuple<int, int>> res = new LinkedList<Tuple<int, int>>();

            // Initialize parent and visited arrays
            for (int i = 0; i < V; i++)
            {
                parent[i] = int.MaxValue;
                visited[i] = false;
            }

            // Call the recursive helper function to find Bridges
            // in DFS tree rooted with vertex 'i'
            for (int i = 0; i < V; i++)
                if (!visited[i])
                    bridgeUtil(i, visited, disc, low, parent, res);

            return res;
        }

        void APUtil(int u, bool[] visited, int[] disc,
                int[] low, int[] parent, bool[] ap)
        {
            // Count of children in DFS Tree
            int children = 0;

            // Mark the current node as visited
            visited[u] = true;

            // Initialize discovery time and low value
            disc[u] = low[u] = ++time;

            foreach (int i in adj[u])
            {
                int v = i;

                if (!visited[v])
                {
                    children++;
                    parent[v] = u;
                    APUtil(v, visited, disc, low, parent, ap);

                    // Check if the subtree rooted with v has a connection to
                    // one of the ancestors of u
                    low[u] = Math.Min(low[u], low[v]);

                    // u is an articulation point in following cases

                    // (1) u is root of DFS tree and has two or more chilren.
                    if (parent[u] == int.MaxValue && children > 1)
                        ap[u] = true;

                    // (2) If u is not root and low value of one of its child is more
                    // than discovery value of u.
                    if (parent[u] != int.MaxValue && low[v] >= disc[u])
                        ap[u] = true;
                }

                // Update low value of u for parent function calls.
                else if (v != parent[u])
                    low[u] = Math.Min(low[u], disc[v]);
            }
        }

        // The function to do DFS traversal. It uses recursive function APUtil()
        public bool[] AP()
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[V];
            int[] disc = new int[V];
            int[] low = new int[V];
            int[] parent = new int[V];
            bool[] ap = new bool[V]; // To store articulation points

            time = 0;

            // Initialize parent and visited, and ap(articulation point) arrays
            for (int i = 0; i < V; i++)
            {
                parent[i] = int.MaxValue;
                visited[i] = false;
                ap[i] = false;
            }

            // Call the recursive helper function to find articulation points
            // in DFS tree rooted with vertex 'i'
            for (int i = 0; i < V; i++)
                if (!visited[i])
                    APUtil(i, visited, disc, low, parent, ap);

            return ap;

        }

        public float Density()
        {
            float edges = 0;
            for (int v = 0; v < V; v++)
            {
                foreach (int i in adj[v])
                {
                    edges++;
                }
            }

            return edges / (V * (V - 1));
        }
    }
}
