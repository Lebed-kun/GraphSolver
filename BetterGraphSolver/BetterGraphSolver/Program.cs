using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGraphSolver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Connected components for undericted graph ? +++
            //Test.connCompsTest();
            //Bridges test ? +++ ? +++
            //Test.bridgesTest();
            //Cut-vertices test ? +++
            //Test.CutVertsTest(); 
            //Transitive closure test +++
            //Test.TransClosureTest();
            //Strongly connected comps test ? +++
            //Test.SCCTest();
            //Type of connected graph +++
            //Test.TypeConnTest();
            //k-edge, k-vert connectivity ?

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
