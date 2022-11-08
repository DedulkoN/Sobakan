namespace SokobanWinForm
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезапуститьТекущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.легкойСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднейСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.высокойСложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровень15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.таблицаРекордовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.уровеньToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.таблицаРекордовToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Visible = false;
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Visible = false;
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // уровеньToolStripMenuItem
            // 
            this.уровеньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезапуститьТекущийToolStripMenuItem,
            this.toolStripSeparator1,
            this.легкойСложностиToolStripMenuItem,
            this.среднейСложностиToolStripMenuItem,
            this.высокойСложностиToolStripMenuItem});
            this.уровеньToolStripMenuItem.Name = "уровеньToolStripMenuItem";
            this.уровеньToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.уровеньToolStripMenuItem.Text = "Уровень";
            // 
            // перезапуститьТекущийToolStripMenuItem
            // 
            this.перезапуститьТекущийToolStripMenuItem.Name = "перезапуститьТекущийToolStripMenuItem";
            this.перезапуститьТекущийToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.перезапуститьТекущийToolStripMenuItem.Text = "Перезапустить текущий";
            this.перезапуститьТекущийToolStripMenuItem.Click += new System.EventHandler(this.перезапуститьТекущийToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // легкойСложностиToolStripMenuItem
            // 
            this.легкойСложностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уровень1ToolStripMenuItem,
            this.уровень2ToolStripMenuItem,
            this.уровень3ToolStripMenuItem,
            this.уровень4ToolStripMenuItem,
            this.уровень5ToolStripMenuItem});
            this.легкойСложностиToolStripMenuItem.Name = "легкойСложностиToolStripMenuItem";
            this.легкойСложностиToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.легкойСложностиToolStripMenuItem.Text = "Легкой сложности";
            // 
            // уровень1ToolStripMenuItem
            // 
            this.уровень1ToolStripMenuItem.Name = "уровень1ToolStripMenuItem";
            this.уровень1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.уровень1ToolStripMenuItem.Text = "Уровень 1";
            this.уровень1ToolStripMenuItem.Click += new System.EventHandler(this.уровень1ToolStripMenuItem_Click);
            // 
            // уровень2ToolStripMenuItem
            // 
            this.уровень2ToolStripMenuItem.Name = "уровень2ToolStripMenuItem";
            this.уровень2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.уровень2ToolStripMenuItem.Text = "Уровень 2";
            this.уровень2ToolStripMenuItem.Click += new System.EventHandler(this.уровень2ToolStripMenuItem_Click);
            // 
            // уровень3ToolStripMenuItem
            // 
            this.уровень3ToolStripMenuItem.Name = "уровень3ToolStripMenuItem";
            this.уровень3ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.уровень3ToolStripMenuItem.Text = "Уровень 3";
            this.уровень3ToolStripMenuItem.Click += new System.EventHandler(this.уровень3ToolStripMenuItem_Click);
            // 
            // уровень4ToolStripMenuItem
            // 
            this.уровень4ToolStripMenuItem.Name = "уровень4ToolStripMenuItem";
            this.уровень4ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.уровень4ToolStripMenuItem.Text = "Уровень 4";
            this.уровень4ToolStripMenuItem.Click += new System.EventHandler(this.уровень4ToolStripMenuItem_Click);
            // 
            // уровень5ToolStripMenuItem
            // 
            this.уровень5ToolStripMenuItem.Name = "уровень5ToolStripMenuItem";
            this.уровень5ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.уровень5ToolStripMenuItem.Text = "Уровень 5";
            this.уровень5ToolStripMenuItem.Click += new System.EventHandler(this.уровень5ToolStripMenuItem_Click);
            // 
            // среднейСложностиToolStripMenuItem
            // 
            this.среднейСложностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уровень6ToolStripMenuItem,
            this.уровень7ToolStripMenuItem,
            this.уровень8ToolStripMenuItem,
            this.уровень9ToolStripMenuItem,
            this.уровень10ToolStripMenuItem});
            this.среднейСложностиToolStripMenuItem.Name = "среднейСложностиToolStripMenuItem";
            this.среднейСложностиToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.среднейСложностиToolStripMenuItem.Text = "Средней сложности";
            // 
            // уровень6ToolStripMenuItem
            // 
            this.уровень6ToolStripMenuItem.Name = "уровень6ToolStripMenuItem";
            this.уровень6ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень6ToolStripMenuItem.Text = "Уровень 6";
            this.уровень6ToolStripMenuItem.Click += new System.EventHandler(this.уровень6ToolStripMenuItem_Click);
            // 
            // уровень7ToolStripMenuItem
            // 
            this.уровень7ToolStripMenuItem.Name = "уровень7ToolStripMenuItem";
            this.уровень7ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень7ToolStripMenuItem.Text = "Уровень 7";
            this.уровень7ToolStripMenuItem.Click += new System.EventHandler(this.уровень7ToolStripMenuItem_Click);
            // 
            // уровень8ToolStripMenuItem
            // 
            this.уровень8ToolStripMenuItem.Name = "уровень8ToolStripMenuItem";
            this.уровень8ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень8ToolStripMenuItem.Text = "Уровень 8";
            this.уровень8ToolStripMenuItem.Click += new System.EventHandler(this.уровень8ToolStripMenuItem_Click);
            // 
            // уровень9ToolStripMenuItem
            // 
            this.уровень9ToolStripMenuItem.Name = "уровень9ToolStripMenuItem";
            this.уровень9ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень9ToolStripMenuItem.Text = "Уровень 9";
            this.уровень9ToolStripMenuItem.Click += new System.EventHandler(this.уровень9ToolStripMenuItem_Click);
            // 
            // уровень10ToolStripMenuItem
            // 
            this.уровень10ToolStripMenuItem.Name = "уровень10ToolStripMenuItem";
            this.уровень10ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень10ToolStripMenuItem.Text = "Уровень 10";
            this.уровень10ToolStripMenuItem.Click += new System.EventHandler(this.уровень10ToolStripMenuItem_Click);
            // 
            // высокойСложностиToolStripMenuItem
            // 
            this.высокойСложностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уровень11ToolStripMenuItem,
            this.уровень12ToolStripMenuItem,
            this.уровень13ToolStripMenuItem,
            this.уровень14ToolStripMenuItem,
            this.уровень15ToolStripMenuItem});
            this.высокойСложностиToolStripMenuItem.Name = "высокойСложностиToolStripMenuItem";
            this.высокойСложностиToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.высокойСложностиToolStripMenuItem.Text = "Высокой сложности";
            // 
            // уровень11ToolStripMenuItem
            // 
            this.уровень11ToolStripMenuItem.Name = "уровень11ToolStripMenuItem";
            this.уровень11ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень11ToolStripMenuItem.Text = "Уровень 11";
            this.уровень11ToolStripMenuItem.Click += new System.EventHandler(this.уровень11ToolStripMenuItem_Click);
            // 
            // уровень12ToolStripMenuItem
            // 
            this.уровень12ToolStripMenuItem.Name = "уровень12ToolStripMenuItem";
            this.уровень12ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень12ToolStripMenuItem.Text = "Уровень 12";
            this.уровень12ToolStripMenuItem.Click += new System.EventHandler(this.уровень12ToolStripMenuItem_Click);
            // 
            // уровень13ToolStripMenuItem
            // 
            this.уровень13ToolStripMenuItem.Name = "уровень13ToolStripMenuItem";
            this.уровень13ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень13ToolStripMenuItem.Text = "Уровень 13";
            this.уровень13ToolStripMenuItem.Click += new System.EventHandler(this.уровень13ToolStripMenuItem_Click);
            // 
            // уровень14ToolStripMenuItem
            // 
            this.уровень14ToolStripMenuItem.Name = "уровень14ToolStripMenuItem";
            this.уровень14ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень14ToolStripMenuItem.Text = "Уровень 14";
            this.уровень14ToolStripMenuItem.Click += new System.EventHandler(this.уровень14ToolStripMenuItem_Click);
            // 
            // уровень15ToolStripMenuItem
            // 
            this.уровень15ToolStripMenuItem.Name = "уровень15ToolStripMenuItem";
            this.уровень15ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.уровень15ToolStripMenuItem.Text = "Уровень 15";
            this.уровень15ToolStripMenuItem.Click += new System.EventHandler(this.уровень15ToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 404);
            this.panel1.TabIndex = 2;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // таблицаРекордовToolStripMenuItem
            // 
            this.таблицаРекордовToolStripMenuItem.Name = "таблицаРекордовToolStripMenuItem";
            this.таблицаРекордовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицаРекордовToolStripMenuItem.Text = "Таблица рекордов";
            this.таблицаРекордовToolStripMenuItem.Click += new System.EventHandler(this.таблицаРекордовToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormMain_PreviewKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезапуститьТекущийToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem легкойСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднейСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem высокойСложностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровень15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem таблицаРекордовToolStripMenuItem;
    }
}

