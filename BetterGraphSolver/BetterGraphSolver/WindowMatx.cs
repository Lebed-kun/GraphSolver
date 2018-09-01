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
    public partial class WindowMatx : Form
    {
        public Form1 mainWindow;
        private TextBox[,] cellBoxes;

        public WindowMatx()
        {
            InitializeComponent();
        }

        private void WindowMatx_Load(object sender, EventArgs e)
        {
            initMatx();
        }

        private void initMatx()
        {
            int dx = 20, dy = 20;


            if (mainWindow.matx == null || mainWindow.num != mainWindow.matx.GetLength(0))
            {
                mainWindow.matx = new int[mainWindow.num, mainWindow.num];

            }
            cellBoxes = new TextBox[mainWindow.num, mainWindow.num];

            for (int i = 0; i < mainWindow.num; i++)
            {
                for (int j = 0; j < mainWindow.num; j++)
                {
                    cellBoxes[i, j] = new TextBox();
                    this.Controls.Add(cellBoxes[i, j]);
                    cellBoxes[i, j].SetBounds((j + 1) * (5 + dx), (i + 1) * (5 + dy), dx, dy);
                    cellBoxes[i, j].Text = mainWindow.matx[i, j].ToString();
                }
            }
        }

        private void применитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cellBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < cellBoxes.GetLength(1); j++)
                    {
                        mainWindow.matx[i, j] = int.Parse(cellBoxes[i, j].Text);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный ввод чисел");
            }
        }

        private void неорграфToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < cellBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < cellBoxes.GetLength(1); j++)
                    {
                        int k = int.Parse(cellBoxes[i, j].Text);
                        if (k != 0)
                        {
                            cellBoxes[j, i].Text = k.ToString();
                            mainWindow.matx[j, i] = k;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный ввод чисел");
            }
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainWindow.matx.GetLength(0); i++)
            {
                for (int j = 0; j < mainWindow.matx.GetLength(1); j++)
                {
                    mainWindow.matx[i, j] = 0;
                    cellBoxes[i, j].Text = mainWindow.matx[i, j].ToString();
                }
            }
        }
    }
}
