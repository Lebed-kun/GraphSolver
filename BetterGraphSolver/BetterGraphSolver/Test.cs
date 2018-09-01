using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGraphSolver
{
    public static class Test
    {
        public static void connCompsTest()
        {
            UndirectedGraph G = new UndirectedGraph(5);
            G.addEdge(1, 0);
            G.addEdge(2, 3);
            G.addEdge(3, 4);
            LinkedList<int>[] connComps = G.connectedComps();
            int i = 0; // {0,1} {2,3,4} +++
        }

        public static void bridgesTest()
        {
            UndirectedGraph g1 = new UndirectedGraph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            LinkedList<Tuple<int, int>> brids =  g1.bridge();
            int i = 0; // {3-4, 0-3} +++

            UndirectedGraph g2 = new UndirectedGraph(4);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            brids = g2.bridge();
            i = 0; // {2-3, 1-2, 0-1} +++

            UndirectedGraph g3 = new UndirectedGraph(7);
            g3.addEdge(0, 1);
            g3.addEdge(1, 2);
            g3.addEdge(2, 0);
            g3.addEdge(1, 3);
            g3.addEdge(1, 4);
            g3.addEdge(1, 6);
            g3.addEdge(3, 5);
            g3.addEdge(4, 5);
            brids = g3.bridge();
            i = 0; // {1-6}  +++
        }

        public static void CutVertsTest()
        {
            UndirectedGraph g1 = new UndirectedGraph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            bool[] articPts = g1.AP();
            int i = 0; // {0, 3} +++

            UndirectedGraph g2 = new UndirectedGraph(4);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            g2.AP();
            articPts = g2.AP();
            i = 0; // {1, 2} +++

            UndirectedGraph g3 = new UndirectedGraph(7);
            g3.addEdge(0, 1);
            g3.addEdge(1, 2);
            g3.addEdge(2, 0);
            g3.addEdge(1, 3);
            g3.addEdge(1, 4);
            g3.addEdge(1, 6);
            g3.addEdge(3, 5);
            g3.addEdge(4, 5);
            articPts = g3.AP();
            i = 0; // {1} +++
        }  

        public static void TransClosureTest()
        {
            DirectedGraph g = new DirectedGraph(4);
            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);
            bool[,] tc = g.transClosure();

            int i = 0;  // {{1, 1, 1, 1}, {1, 1, 1, 1}, {1, 1, 1, 1}, {0, 0, 0, 1}} +++
        }

        public static void SCCTest()
        {
            DirectedGraph g1 = new DirectedGraph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            LinkedList<int>[] scc1 = g1.SCC(); // {{4}, {3}, {1 2 0}} +++

            DirectedGraph g2 = new DirectedGraph(4); 
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            scc1 = g2.SCC(); // {{3}, {2}, {1}, {0}} +++

            DirectedGraph g3 = new DirectedGraph(7);
            g3.addEdge(0, 1);
            g3.addEdge(1, 2);
            g3.addEdge(2, 0);
            g3.addEdge(1, 3);
            g3.addEdge(1, 4);
            g3.addEdge(1, 6);
            g3.addEdge(3, 5);
            g3.addEdge(4, 5);
            scc1 = g3.SCC(); // {{5}, {3}, {4}, {6}, {2 1 0}} +++


            DirectedGraph g4 = new DirectedGraph(11);
            g4.addEdge(0, 1); g4.addEdge(0, 3);
            g4.addEdge(1, 2); g4.addEdge(1, 4);
            g4.addEdge(2, 0); g4.addEdge(2, 6);
            g4.addEdge(3, 2);
            g4.addEdge(4, 5); g4.addEdge(4, 6);
            g4.addEdge(5, 6); g4.addEdge(5, 7); g4.addEdge(5, 8); g4.addEdge(5, 9);
            g4.addEdge(6, 4);
            g4.addEdge(7, 9);
            g4.addEdge(8, 9);
            g4.addEdge(9, 8);
            scc1 = g4.SCC(); // {{8 9}, {7}, {5 4 6}, {3 2 1 0}, {10}} +++

            DirectedGraph g5 = new DirectedGraph(5);
            g5.addEdge(0, 1);
            g5.addEdge(1, 2);
            g5.addEdge(2, 3);
            g5.addEdge(2, 4);
            g5.addEdge(3, 0);
            g5.addEdge(4, 2);
            scc1 = g5.SCC();
            int i = 0; // {{4 3 2 1 0}} +++
        } 

        public static void TypeConnTest()
        {
            DirectedGraph g1 = new DirectedGraph(6);
            g1.addEdge(0, 3); g1.addEdge(0, 4);
            g1.addEdge(1, 0); g1.addEdge(1, 2);
            g1.addEdge(2, 4);
            g1.addEdge(3, 1); g1.addEdge(3, 2);
            g1.addEdge(4, 5);
            g1.addEdge(5, 0);
            g1.SCC();
            g1.transClosure();
            byte t = g1.typeOConnect(); // 3 +++

            DirectedGraph g2 = new DirectedGraph(6);
            g2.addEdge(0, 4); g2.addEdge(0, 5);
            g2.addEdge(1, 0); g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            g2.addEdge(3, 5);
            g2.addEdge(4, 3); g2.addEdge(4, 5);
            g2.addEdge(5, 0);
            g2.SCC();
            g2.transClosure();
            t = g2.typeOConnect(); // 2 +++

            DirectedGraph g3 = new DirectedGraph(6);
            g3.addEdge(0, 3); g3.addEdge(0, 4);
            g3.addEdge(1, 2);
            g3.addEdge(2, 3);
            g3.addEdge(4, 3);
            g3.addEdge(5, 0);
            g3.SCC();
            g3.transClosure();
            t = g3.typeOConnect(); // 1 +++

            DirectedGraph g4 = new DirectedGraph(6);
            g4.addEdge(0, 4);
            g4.addEdge(1, 2); g4.addEdge(1, 3);
            g4.addEdge(4, 0);
            g4.addEdge(5, 0);
            g4.SCC();
            g4.transClosure();
            t = g4.typeOConnect(); // 0 +++
            int i = 0;
        }  


    }
}
