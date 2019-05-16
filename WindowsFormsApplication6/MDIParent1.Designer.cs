namespace WindowsFormsApplication6
{
    partial class MDIParent1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначениеПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикСдачиЭкзаменовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правильныхОтветовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesTableAdapter1 = new WindowsFormsApplication6.sntbDataSetTableAdapters.coursesTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(848, 2);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(848, 27);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.протоколаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, -22);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(848, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назначениеПрограммыToolStripMenuItem,
            this.протоколToolStripMenuItem,
            this.графикСдачиЭкзаменовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // назначениеПрограммыToolStripMenuItem
            // 
            this.назначениеПрограммыToolStripMenuItem.Name = "назначениеПрограммыToolStripMenuItem";
            this.назначениеПрограммыToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.назначениеПрограммыToolStripMenuItem.Text = "Назначение программы";
            this.назначениеПрограммыToolStripMenuItem.Click += new System.EventHandler(this.назначениеПрограммыToolStripMenuItem_Click);
            // 
            // протоколToolStripMenuItem
            // 
            this.протоколToolStripMenuItem.Name = "протоколToolStripMenuItem";
            this.протоколToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.протоколToolStripMenuItem.Text = "Протокол";
            this.протоколToolStripMenuItem.Click += new System.EventHandler(this.протоколToolStripMenuItem_Click);
            // 
            // графикСдачиЭкзаменовToolStripMenuItem
            // 
            this.графикСдачиЭкзаменовToolStripMenuItem.Name = "графикСдачиЭкзаменовToolStripMenuItem";
            this.графикСдачиЭкзаменовToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.графикСдачиЭкзаменовToolStripMenuItem.Text = "График сдачи экзаменов";
            this.графикСдачиЭкзаменовToolStripMenuItem.Click += new System.EventHandler(this.графикСдачиЭкзаменовToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правильныхОтветовToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Visible = false;
            // 
            // правильныхОтветовToolStripMenuItem
            // 
            this.правильныхОтветовToolStripMenuItem.Name = "правильныхОтветовToolStripMenuItem";
            this.правильныхОтветовToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.правильныхОтветовToolStripMenuItem.Text = "правильных ответов";
            this.правильныхОтветовToolStripMenuItem.Click += new System.EventHandler(this.правильныхОтветовToolStripMenuItem_Click);
            // 
            // протоколаToolStripMenuItem
            // 
            this.протоколаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программToolStripMenuItem,
            this.темыToolStripMenuItem,
            this.документовToolStripMenuItem,
            this.тестовToolStripMenuItem,
            this.вопросовToolStripMenuItem});
            this.протоколаToolStripMenuItem.Name = "протоколаToolStripMenuItem";
            this.протоколаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.протоколаToolStripMenuItem.Text = "Редактор";
            // 
            // программToolStripMenuItem
            // 
            this.программToolStripMenuItem.Name = "программToolStripMenuItem";
            this.программToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.программToolStripMenuItem.Text = "Программы";
            this.программToolStripMenuItem.Click += new System.EventHandler(this.программToolStripMenuItem_Click);
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.темыToolStripMenuItem.Text = "Темы";
            this.темыToolStripMenuItem.Click += new System.EventHandler(this.темыToolStripMenuItem_Click);
            // 
            // документовToolStripMenuItem
            // 
            this.документовToolStripMenuItem.Name = "документовToolStripMenuItem";
            this.документовToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.документовToolStripMenuItem.Text = "Документов";
            this.документовToolStripMenuItem.Click += new System.EventHandler(this.документовToolStripMenuItem_Click);
            // 
            // тестовToolStripMenuItem
            // 
            this.тестовToolStripMenuItem.Name = "тестовToolStripMenuItem";
            this.тестовToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.тестовToolStripMenuItem.Text = "Тестов";
            this.тестовToolStripMenuItem.Click += new System.EventHandler(this.тестовToolStripMenuItem_Click);
            // 
            // вопросовToolStripMenuItem
            // 
            this.вопросовToolStripMenuItem.Name = "вопросовToolStripMenuItem";
            this.вопросовToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вопросовToolStripMenuItem.Text = "Вопросов";
            this.вопросовToolStripMenuItem.Click += new System.EventHandler(this.вопросовToolStripMenuItem_Click);
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 453);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Stardust";
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочее место комиссии";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private sntbDataSetTableAdapters.coursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначениеПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вопросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правильныхОтветовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикСдачиЭкзаменовToolStripMenuItem;
    }
}



