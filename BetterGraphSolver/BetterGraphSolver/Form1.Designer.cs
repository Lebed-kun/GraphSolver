namespace BetterGraphSolver
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ввестиМатрицуСмежностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборАлгоритмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неографToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыСвязностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкиСочлененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мостыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плотностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.орграфToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транзитивноеЗамыканиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сильныеКомпонентыСвязностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типГрафаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плотностьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиМатрицуСмежностиToolStripMenuItem,
            this.выборАлгоритмаToolStripMenuItem,
            this.расчитатьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ввестиМатрицуСмежностиToolStripMenuItem
            // 
            this.ввестиМатрицуСмежностиToolStripMenuItem.Name = "ввестиМатрицуСмежностиToolStripMenuItem";
            this.ввестиМатрицуСмежностиToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.ввестиМатрицуСмежностиToolStripMenuItem.Text = "Ввести матрицу смежности";
            this.ввестиМатрицуСмежностиToolStripMenuItem.Click += new System.EventHandler(this.ввестиМатрицуСмежностиToolStripMenuItem_Click);
            // 
            // выборАлгоритмаToolStripMenuItem
            // 
            this.выборАлгоритмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.неографToolStripMenuItem,
            this.орграфToolStripMenuItem});
            this.выборАлгоритмаToolStripMenuItem.Name = "выборАлгоритмаToolStripMenuItem";
            this.выборАлгоритмаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.выборАлгоритмаToolStripMenuItem.Text = "Выбор алгоритма";
            // 
            // неографToolStripMenuItem
            // 
            this.неографToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыСвязностиToolStripMenuItem,
            this.точкиСочлененияToolStripMenuItem,
            this.мостыToolStripMenuItem,
            this.плотностьToolStripMenuItem});
            this.неографToolStripMenuItem.Name = "неографToolStripMenuItem";
            this.неографToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.неографToolStripMenuItem.Text = "Неограф";
            // 
            // компонентыСвязностиToolStripMenuItem
            // 
            this.компонентыСвязностиToolStripMenuItem.Name = "компонентыСвязностиToolStripMenuItem";
            this.компонентыСвязностиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.компонентыСвязностиToolStripMenuItem.Text = "Компоненты связности";
            this.компонентыСвязностиToolStripMenuItem.Click += new System.EventHandler(this.компонентыСвязностиToolStripMenuItem_Click);
            // 
            // точкиСочлененияToolStripMenuItem
            // 
            this.точкиСочлененияToolStripMenuItem.Name = "точкиСочлененияToolStripMenuItem";
            this.точкиСочлененияToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.точкиСочлененияToolStripMenuItem.Text = "Точки сочленения";
            this.точкиСочлененияToolStripMenuItem.Click += new System.EventHandler(this.точкиСочлененияToolStripMenuItem_Click);
            // 
            // мостыToolStripMenuItem
            // 
            this.мостыToolStripMenuItem.Name = "мостыToolStripMenuItem";
            this.мостыToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.мостыToolStripMenuItem.Text = "Мосты";
            this.мостыToolStripMenuItem.Click += new System.EventHandler(this.мостыToolStripMenuItem_Click);
            // 
            // плотностьToolStripMenuItem
            // 
            this.плотностьToolStripMenuItem.Name = "плотностьToolStripMenuItem";
            this.плотностьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.плотностьToolStripMenuItem.Text = "Плотность";
            this.плотностьToolStripMenuItem.Click += new System.EventHandler(this.плотностьToolStripMenuItem_Click);
            // 
            // орграфToolStripMenuItem
            // 
            this.орграфToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.транзитивноеЗамыканиеToolStripMenuItem,
            this.сильныеКомпонентыСвязностиToolStripMenuItem,
            this.типГрафаToolStripMenuItem,
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem,
            this.плотностьToolStripMenuItem1});
            this.орграфToolStripMenuItem.Name = "орграфToolStripMenuItem";
            this.орграфToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.орграфToolStripMenuItem.Text = "Орграф";
            // 
            // транзитивноеЗамыканиеToolStripMenuItem
            // 
            this.транзитивноеЗамыканиеToolStripMenuItem.Name = "транзитивноеЗамыканиеToolStripMenuItem";
            this.транзитивноеЗамыканиеToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.транзитивноеЗамыканиеToolStripMenuItem.Text = "Транзитивное замыкание";
            this.транзитивноеЗамыканиеToolStripMenuItem.Click += new System.EventHandler(this.транзитивноеЗамыканиеToolStripMenuItem_Click);
            // 
            // сильныеКомпонентыСвязностиToolStripMenuItem
            // 
            this.сильныеКомпонентыСвязностиToolStripMenuItem.Name = "сильныеКомпонентыСвязностиToolStripMenuItem";
            this.сильныеКомпонентыСвязностиToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.сильныеКомпонентыСвязностиToolStripMenuItem.Text = "Сильные компоненты связности";
            this.сильныеКомпонентыСвязностиToolStripMenuItem.Click += new System.EventHandler(this.сильныеКомпонентыСвязностиToolStripMenuItem_Click);
            // 
            // типГрафаToolStripMenuItem
            // 
            this.типГрафаToolStripMenuItem.Name = "типГрафаToolStripMenuItem";
            this.типГрафаToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.типГрафаToolStripMenuItem.Text = "Тип графа";
            this.типГрафаToolStripMenuItem.Click += new System.EventHandler(this.типГрафаToolStripMenuItem_Click);
            // 
            // наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem
            // 
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem.Name = "наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem";
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem.Size = new System.Drawing.Size(454, 22);
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem.Text = "Наибольшее независимое/наименьшее доминирующее множество";
            this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem.Click += new System.EventHandler(this.наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem_Click);
            // 
            // плотностьToolStripMenuItem1
            // 
            this.плотностьToolStripMenuItem1.Name = "плотностьToolStripMenuItem1";
            this.плотностьToolStripMenuItem1.Size = new System.Drawing.Size(454, 22);
            this.плотностьToolStripMenuItem1.Text = "Плотность";
            this.плотностьToolStripMenuItem1.Click += new System.EventHandler(this.плотностьToolStripMenuItem1_Click);
            // 
            // расчитатьToolStripMenuItem
            // 
            this.расчитатьToolStripMenuItem.Name = "расчитатьToolStripMenuItem";
            this.расчитатьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.расчитатьToolStripMenuItem.Text = "Расчитать";
            this.расчитатьToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число вершин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(475, 216);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 359);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Решалка графов 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ввестиМатрицуСмежностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчитатьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem выборАлгоритмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неографToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыСвязностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem орграфToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкиСочлененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мостыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плотностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транзитивноеЗамыканиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типГрафаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наибольшееНезависимоенаименьшееДоминирующееМножествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плотностьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сильныеКомпонентыСвязностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

