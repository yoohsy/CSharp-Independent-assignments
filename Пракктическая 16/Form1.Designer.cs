namespace Пракктическая_16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            закрытьВсеДочерниеФормыToolStripMenuItem = new ToolStripMenuItem();
            приемСообщенийToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, закрытьВсеДочерниеФормыToolStripMenuItem, приемСообщенийToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(166, 20);
            создатьToolStripMenuItem.Text = "Создать дочернюю форму";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // закрытьВсеДочерниеФормыToolStripMenuItem
            // 
            закрытьВсеДочерниеФормыToolStripMenuItem.Name = "закрытьВсеДочерниеФормыToolStripMenuItem";
            закрытьВсеДочерниеФормыToolStripMenuItem.Size = new Size(186, 20);
            закрытьВсеДочерниеФормыToolStripMenuItem.Text = "Закрыть все дочерние формы";
            закрытьВсеДочерниеФормыToolStripMenuItem.Click += закрытьВсеДочерниеФормыToolStripMenuItem_Click;
            // 
            // приемСообщенийToolStripMenuItem
            // 
            приемСообщенийToolStripMenuItem.Name = "приемСообщенийToolStripMenuItem";
            приемСообщенийToolStripMenuItem.Size = new Size(125, 20);
            приемСообщенийToolStripMenuItem.Text = "Прием сообщений";
            приемСообщенийToolStripMenuItem.Click += приемСообщенийToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Многооконное приложение";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem закрытьВсеДочерниеФормыToolStripMenuItem;
        private ToolStripMenuItem приемСообщенийToolStripMenuItem;
    }
}
