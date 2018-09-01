using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGraphSolver
{
    public partial class Form1 : Form
    {

        public int num;
        public int[,] matx;

        public WindowMatx matxWin;

        public byte algorithm;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            algorithm = 0;
        }

        private void оПрогрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ввестиМатрицуСмежностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(textBox1.Text);
                if (num > 0 && num <= 30)
                {

                    matxWin = new WindowMatx();
                    matxWin.mainWindow = this;
                    matxWin.Show();
                }
                else
                {
                    MessageBox.Show("Некорректно введено число");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректно введено число");
            }
        }

        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();

                UndirectedGraph uG = convertToUndirGr();
                DirectedGraph dG = convertToDirGr();
                FlowGraph fG = convertToFlow();

                switch (algorithm)
                {
                    case 0:
                        LinkedList<int>[] comps = uG.connectedComps();
                        richTextBox1.AppendText("Компоненты связности:\n");
                        for (int v = 0; v < comps.Length; v++)
                        {
                            if (comps[v] != null)
                                foreach (int i in comps[v])
                            {
                                richTextBox1.AppendText((i+1).ToString() + " ");
                            }
                            if (richTextBox1.Text[richTextBox1.Text.Length - 1] != '\n')
                                richTextBox1.AppendText("\n");
                        }
                        break;

                    case 1:
                        bool[] articPoints = uG.AP();
                        richTextBox1.AppendText("Точки сочленения:\n");
                        for (int i = 0; i < articPoints.Length; i++)
                        {
                            if (articPoints[i])
                                richTextBox1.AppendText((i+1).ToString() + " ");
                        }
                        break;

                    case 2:
                        LinkedList<Tuple<int, int>> brids = uG.bridge();
                        richTextBox1.AppendText("Мосты:\n");
                        foreach(Tuple<int, int> b in brids)
                        {
                            richTextBox1.AppendText((b.Item1+1).ToString() + "-" +
                                (b.Item2+1).ToString() + "\n");
                        }
                        break;

                    case 3:
                        int X = fG.kVertConnectivity();
                        richTextBox1.AppendText("Вершинная связность: " + X + "\n");
                        break;
                    case 4:
                        int L = fG.kEdgeConnectivity();
                        richTextBox1.AppendText("Реберная связность: " + L + "\n");
                        break;
                    case 5:
                        float dens = uG.Density();
                        richTextBox1.AppendText("Плотность неорграфа: " + dens + "\n");
                        break;

                    case 6:
                        bool[,] transClosure = dG.transClosure();
                        richTextBox1.AppendText("Транзитивное замыкание:\n");
                        for (int i = 0; i < transClosure.GetLength(0); i++)
                        {
                            for (int j = 0; j < transClosure.GetLength(1); j++)
                            {
                                if (transClosure[i, j])
                                    richTextBox1.AppendText("1 ");
                                else
                                    richTextBox1.AppendText("0 ");
                            }
                            richTextBox1.AppendText("\n");
                        }
                        break;
                    case 7:
                        LinkedList<int>[] SCC = dG.SCC();
                        richTextBox1.AppendText("Сильные компоненты связности:\n");
                        for (int v = 0; v < SCC.Length; v++)
                        {
                            if (SCC[v] != null)
                            foreach (int i in SCC[v])
                            {
                                
                                    richTextBox1.AppendText((i+1).ToString() + " ");
                            }
                            if (richTextBox1.Text[richTextBox1.Text.Length - 1] != '\n')
                                richTextBox1.AppendText("\n");
                        }
                        break;

                    case 8:
                        byte type = dG.typeOConnect();
                        richTextBox1.AppendText("Граф - ");
                        switch(type)
                        {
                            case 3:
                                richTextBox1.AppendText("сильносвязный\n");
                                break;
                            case 2:
                                richTextBox1.AppendText("односторонне связный\n");
                                break;
                            case 1:
                                richTextBox1.AppendText("слабосвязный\n");
                                break;
                            default:
                                richTextBox1.AppendText("несвязный\n");
                                break;
                        }
                        break;
                    case 9:
                        LinkedList<int> maxIndSet = dG.maximalIndependentSet();
                        richTextBox1.AppendText("Максимальное независимое множество: ");
                        foreach(int i in maxIndSet)
                        {
                            richTextBox1.AppendText((i+1).ToString() + " ");
                        }

                        richTextBox1.AppendText("\nМинимальное доминирующее множество: ");
                        foreach(int i in maxIndSet)
                        {
                            richTextBox1.AppendText((i+1).ToString() + " ");
                        }
                        break;
                    case 10:
                        float dens1 = dG.Density();
                        richTextBox1.AppendText("Плотность орграфа: " + dens1 + "\n");
                        break;

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Неверный ввод данных");
            }
        }

        private UndirectedGraph convertToUndirGr()
        {
            UndirectedGraph g = new UndirectedGraph(num);

            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    if (matx[i, j] == 1)
                        g.addEdge(i, j);
                }
            }

            return g;
        }

        private DirectedGraph convertToDirGr()
        {
            DirectedGraph g = new DirectedGraph(num);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (matx[i, j] == 1)
                        g.addEdge(i, j);
                }
            }

            return g;
        }

        private FlowGraph convertToFlow()
        {
            FlowGraph g = new FlowGraph(num);

            g.capacity = matx;

            return g;
        }

        private void компонентыСвязностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 0;
        }

        private void точкиСочлененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 1;
        }

        private void мостыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 2;
        }

        private void вершиннаяСвязностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 3;
        }

        private void ребернаяСвязностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 4;
        }

        private void плотностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 5;
        }

        private void транзитивноеЗамыканиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 6;
        }

        private void сильныеКомпонентыСвязностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 7;
        }

        private void типГрафаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 8;
        }

        private void наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = 9;
        }

        private void плотностьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            algorithm = 10;
        }

        private void PrintResult()
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
