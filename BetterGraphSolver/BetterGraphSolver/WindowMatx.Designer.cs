namespace BetterGraphSolver
{
    partial class WindowMatx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.применитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неорграфToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.применитьToolStripMenuItem,
            this.неорграфToolStripMenuItem,
            this.сбросToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // применитьToolStripMenuItem
            // 
            this.применитьToolStripMenuItem.Name = "применитьToolStripMenuItem";
            this.применитьToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.применитьToolStripMenuItem.Text = "Применить";
            this.применитьToolStripMenuItem.Click += new System.EventHandler(this.применитьToolStripMenuItem_Click);
            // 
            // неорграфToolStripMenuItem
            // 
            this.неорграфToolStripMenuItem.Name = "неорграфToolStripMenuItem";
            this.неорграфToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.неорграфToolStripMenuItem.Text = "Неорграф";
            this.неорграфToolStripMenuItem.Click += new System.EventHandler(this.неорграфToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // WindowMatx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 352);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowMatx";
            this.Text = "Матрица смежности";
            this.Load += new System.EventHandler(this.WindowMatx_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem применитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неорграфToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
    }
}