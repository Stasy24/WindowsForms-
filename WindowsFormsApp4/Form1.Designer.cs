namespace WindowsFormsApp4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.класиЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рядкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успадкуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поліморфізмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абстрактніКласиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.рФайлиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.реалізаціяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.класиЗМасивамиToolStripMenuItem,
            this.рядкиToolStripMenuItem,
            this.успадкуванняToolStripMenuItem,
            this.поліморфізмToolStripMenuItem,
            this.абстрактніКласиToolStripMenuItem,
            this.структуриToolStripMenuItem,
            this.рФайлиToolStripMenuItem1,
            this.реалізаціяToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // класиЗМасивамиToolStripMenuItem
            // 
            this.класиЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірнийToolStripMenuItem,
            this.двовимірнийToolStripMenuItem});
            this.класиЗМасивамиToolStripMenuItem.Name = "класиЗМасивамиToolStripMenuItem";
            this.класиЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.класиЗМасивамиToolStripMenuItem.Text = "Класи з масивами";
            this.класиЗМасивамиToolStripMenuItem.Click += new System.EventHandler(this.класиЗМасивамиToolStripMenuItem_Click);
            // 
            // одновимірнийToolStripMenuItem
            // 
            this.одновимірнийToolStripMenuItem.Name = "одновимірнийToolStripMenuItem";
            this.одновимірнийToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.одновимірнийToolStripMenuItem.Text = "одновимірний";
            this.одновимірнийToolStripMenuItem.Click += new System.EventHandler(this.одновимірнийToolStripMenuItem_Click);
            // 
            // двовимірнийToolStripMenuItem
            // 
            this.двовимірнийToolStripMenuItem.Name = "двовимірнийToolStripMenuItem";
            this.двовимірнийToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.двовимірнийToolStripMenuItem.Text = "двовимірний";
            this.двовимірнийToolStripMenuItem.Click += new System.EventHandler(this.двовимірнийToolStripMenuItem_Click);
            // 
            // рядкиToolStripMenuItem
            // 
            this.рядкиToolStripMenuItem.Name = "рядкиToolStripMenuItem";
            this.рядкиToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.рядкиToolStripMenuItem.Text = "рядки";
            this.рядкиToolStripMenuItem.Click += new System.EventHandler(this.рядкиToolStripMenuItem_Click);
            // 
            // успадкуванняToolStripMenuItem
            // 
            this.успадкуванняToolStripMenuItem.Name = "успадкуванняToolStripMenuItem";
            this.успадкуванняToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.успадкуванняToolStripMenuItem.Text = "успадкування";
            this.успадкуванняToolStripMenuItem.Click += new System.EventHandler(this.успадкуванняToolStripMenuItem_Click);
            // 
            // поліморфізмToolStripMenuItem
            // 
            this.поліморфізмToolStripMenuItem.Name = "поліморфізмToolStripMenuItem";
            this.поліморфізмToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.поліморфізмToolStripMenuItem.Text = "поліморфізм";
            this.поліморфізмToolStripMenuItem.Click += new System.EventHandler(this.поліморфізмToolStripMenuItem_Click);
            // 
            // абстрактніКласиToolStripMenuItem
            // 
            this.абстрактніКласиToolStripMenuItem.Name = "абстрактніКласиToolStripMenuItem";
            this.абстрактніКласиToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.абстрактніКласиToolStripMenuItem.Text = "абстрактні класи";
            this.абстрактніКласиToolStripMenuItem.Click += new System.EventHandler(this.абстрактніКласиToolStripMenuItem_Click);
            // 
            // структуриToolStripMenuItem
            // 
            this.структуриToolStripMenuItem.Name = "структуриToolStripMenuItem";
            this.структуриToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.структуриToolStripMenuItem.Text = "структури";
            this.структуриToolStripMenuItem.Click += new System.EventHandler(this.структуриToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // рФайлиToolStripMenuItem1
            // 
            this.рФайлиToolStripMenuItem1.Name = "рФайлиToolStripMenuItem1";
            this.рФайлиToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.рФайлиToolStripMenuItem1.Text = "р файли";
            this.рФайлиToolStripMenuItem1.Click += new System.EventHandler(this.рФайлиToolStripMenuItem1_Click);
            // 
            // реалізаціяToolStripMenuItem1
            // 
            this.реалізаціяToolStripMenuItem1.Name = "реалізаціяToolStripMenuItem1";
            this.реалізаціяToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.реалізаціяToolStripMenuItem1.Text = "реалізація";
            this.реалізаціяToolStripMenuItem1.Click += new System.EventHandler(this.реалізаціяToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem класиЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірнийToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рядкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успадкуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поліморфізмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абстрактніКласиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рФайлиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem реалізаціяToolStripMenuItem1;
    }
}

