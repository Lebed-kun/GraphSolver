using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGraphSolver
{
    public class DirectedGraph
    {
        int V; //Число вершин

        LinkedList<int>[] adj; //Массив списков смежных вершин

        public int Vertx { get { return V; }}
        public LinkedList<int>[] Adj { get { return adj; }}

        bool[,] tc;
        LinkedList<int>[] strComps;

        public DirectedGraph(int V)
        {
            this.V = V;
            adj = new LinkedList<int>[V];

            for (int v = 0; v < V; v++)
            {
                adj[v] = new LinkedList<int>();
            }
        }

        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
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

        void DFSUtil(int s, int v, bool[,] tc)
        {
            // Mark reachability from s to t as true.
            tc[s, v] = true;

            // Find all the vertices reachable through v
            foreach (int i in adj[v])
            {
                if (!tc[s, i])
                    DFSUtil(s, i, tc);
            }
        }

        public bool[,] transClosure()
        {

            bool[,] tc = new bool[V, V];
            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    tc[i, j] = false;

            // Call the recursive helper function to print DFS
            // traversal starting from all vertices one by one
            for (int i = 0; i < V; i++)
                DFSUtil(i, i, tc); // Every vertex is reachable from self.


            this.tc = tc;
            return tc;
        }

        private int time;

        void DFSUtil(int v, bool[] visited, LinkedList<int> comp)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            comp.AddLast(v);

            // Recur for all the vertices adjacent to this vertex
            foreach(int i in adj[v])
                if (!visited[i])
                    DFSUtil(i, visited, comp);
        }

        DirectedGraph getTranspose()
        {
            DirectedGraph g = new DirectedGraph(V);

            for (int v = 0; v < V; v++)
            {
                // Recur for all the vertices adjacent to this vertex
                foreach(int i in adj[v])
                {
                    g.adj[i].AddLast(v);
                }
            }
            return g;
        }

        void fillOrder(int v, bool[] visited, Stack<int> Stack)
        {
            // Mark the current node as visited and print it
            visited[v] = true;

            // Recur for all the vertices adjacent to this vertex
            foreach (int i in adj[v])
                if (!visited[i])
                    fillOrder(i, visited, Stack);

            // All vertices reachable from v are processed by now, push v 
            Stack.Push(v);
        }

        // The main function that finds and prints all strongly connected 
        // components
        public LinkedList<int>[] SCC()
        {
            LinkedList<int>[] strComps = new LinkedList<int>[V];

            Stack<int> Stack = new Stack<int>();

            // Mark all the vertices as not visited (For first DFS)
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Fill vertices in stack according to their finishing times
            for (int i = 0; i < V; i++)
                if (visited[i] == false)
                    fillOrder(i, visited, Stack);

            // Create a reversed graph
            DirectedGraph gr = getTranspose();

            // Mark all the vertices as not visited (For second DFS)
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Now process all vertices in order defined by Stack
            while (Stack.Count > 0)
            {
                // Pop a vertex from stack
                int v = Stack.Peek();
                Stack.Pop();

                // Print Strongly connected component of the popped vertex
                if (visited[v] == false)
                {
                    LinkedList<int> comp = new LinkedList<int>();
                    gr.DFSUtil(v, visited, comp);
                    strComps[v] = comp;
                }
            }

            this.strComps = strComps;
            return strComps;
        }

        bool isStronglyConnected()
        {
            int cnt = 0;
            if (strComps == null)
                SCC();
            for(int i = 0; i < V; i++)
            {
                if (strComps[i] != null)
                    cnt++;
            }

            return cnt == 1;
        }



        bool isOneDirConnected()
        {
            if (tc == null)
                transClosure();
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if ((i != j) && !tc[i, j] && !tc[j, i])
                    {
                        return false;
                    }
                        
                }
            }

            return true;

        }

        bool isWeakConnected()
        {
            UndirectedGraph g = new UndirectedGraph(V);
            for (int v = 0; v < V; v++)
            {
                foreach (int i in adj[v])
                {
                    if (!g.hasEdge(v, i))
                        g.addEdge(v, i);
                }
            }

            int cnt = 0;
            LinkedList<int>[] connComps = g.connectedComps();
            for (int i = 0; i < V; i++)
            {
                if (connComps[i] != null)
                    cnt++;
            }

            return cnt == 1;
        }

        public byte typeOConnect()
        {
            if (isStronglyConnected())
                return 3;
            else if (isOneDirConnected())
                return 2;
            else if (isWeakConnected())
                return 1;
            else
                return 0;
        }

        public LinkedList<int> maximalIndependentSet()
        {
            LinkedList<int> res = new LinkedList<int>();

            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
            {
                visited[i] = false;
            }

            for (int  v = 0; v < V; v++) {
                if (!visited[v])
                {
                    res.AddLast(v);
                    foreach (int i in adj[v])
                    {
                        visited[i] = true;
                    }

                    visited[v] = true;
                }
            }

            return res;
        }

        public LinkedList<int> minimalDominatingSet() {
            LinkedList<int> res = new LinkedList<int>();

            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
            {
                visited[i] = false;
            }

            for (int v = 0; v < V; v++)
            {
                if (!visited[v])
                {
                    res.AddLast(v);
                    foreach(int i in adj[v])
                    {
                        visited[i] = false;
                    }
                }
            }

            return res;
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
