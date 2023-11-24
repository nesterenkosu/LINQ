
namespace LinqWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкиПрограммированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиДолжностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowTemplate.Height = 24;
            this.myDataGridView.Size = new System.Drawing.Size(600, 342);
            this.myDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.языкиПрограммированияToolStripMenuItem,
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // языкиПрограммированияToolStripMenuItem
            // 
            this.языкиПрограммированияToolStripMenuItem.Name = "языкиПрограммированияToolStripMenuItem";
            this.языкиПрограммированияToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.языкиПрограммированияToolStripMenuItem.Text = "Языки программирования";
            this.языкиПрограммированияToolStripMenuItem.Click += new System.EventHandler(this.языкиПрограммированияToolStripMenuItem_Click);
            // 
            // сотрудникиЯзыкиПрограммированияToolStripMenuItem1
            // 
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1.Name = "сотрудникиЯзыкиПрограммированияToolStripMenuItem1";
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1.Size = new System.Drawing.Size(298, 22);
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1.Text = "Сотрудники - Языки программирования";
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1.Click += new System.EventHandler(this.сотрудникиЯзыкиПрограммированияToolStripMenuItem1_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиДолжностиToolStripMenuItem,
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // сотрудникиДолжностиToolStripMenuItem
            // 
            this.сотрудникиДолжностиToolStripMenuItem.Name = "сотрудникиДолжностиToolStripMenuItem";
            this.сотрудникиДолжностиToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.сотрудникиДолжностиToolStripMenuItem.Text = "Сотрудники - должности";
            this.сотрудникиДолжностиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиДолжностиToolStripMenuItem_Click);
            // 
            // сотрудникиЯзыкиПрограммированияToolStripMenuItem
            // 
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem.Name = "сотрудникиЯзыкиПрограммированияToolStripMenuItem";
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem.Text = "Сотрудники - языки программирования";
            this.сотрудникиЯзыкиПрограммированияToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиЯзыкиПрограммированияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Демонстрация возможностей LINQ to Objects";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource myBindingSource;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem языкиПрограммированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиДолжностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиЯзыкиПрограммированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиЯзыкиПрограммированияToolStripMenuItem1;
    }
}

