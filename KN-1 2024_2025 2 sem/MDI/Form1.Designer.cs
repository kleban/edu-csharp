namespace MDI
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
            вікноToolStripMenuItem = new ToolStripMenuItem();
            новеToolStripMenuItem = new ToolStripMenuItem();
            новеЗКалендаремToolStripMenuItem = new ToolStripMenuItem();
            оновитиВікнаЗКалендаремToolStripMenuItem = new ToolStripMenuItem();
            вікнаToolStripMenuItem = new ToolStripMenuItem();
            каскадToolStripMenuItem = new ToolStripMenuItem();
            горизонтальноToolStripMenuItem = new ToolStripMenuItem();
            вертикальноToolStripMenuItem = new ToolStripMenuItem();
            закритиВікнаЗКалендаремToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вікноToolStripMenuItem, вікнаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // вікноToolStripMenuItem
            // 
            вікноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новеToolStripMenuItem, новеЗКалендаремToolStripMenuItem, оновитиВікнаЗКалендаремToolStripMenuItem, закритиВікнаЗКалендаремToolStripMenuItem });
            вікноToolStripMenuItem.Name = "вікноToolStripMenuItem";
            вікноToolStripMenuItem.Size = new Size(61, 24);
            вікноToolStripMenuItem.Text = "Вікно";
            // 
            // новеToolStripMenuItem
            // 
            новеToolStripMenuItem.Name = "новеToolStripMenuItem";
            новеToolStripMenuItem.Size = new Size(292, 26);
            новеToolStripMenuItem.Text = "Нове кольорове";
            новеToolStripMenuItem.Click += новеToolStripMenuItem_Click;
            // 
            // новеЗКалендаремToolStripMenuItem
            // 
            новеЗКалендаремToolStripMenuItem.Name = "новеЗКалендаремToolStripMenuItem";
            новеЗКалендаремToolStripMenuItem.Size = new Size(292, 26);
            новеЗКалендаремToolStripMenuItem.Text = "Нове з календарем";
            новеЗКалендаремToolStripMenuItem.Click += новеЗКалендаремToolStripMenuItem_Click;
            // 
            // оновитиВікнаЗКалендаремToolStripMenuItem
            // 
            оновитиВікнаЗКалендаремToolStripMenuItem.Name = "оновитиВікнаЗКалендаремToolStripMenuItem";
            оновитиВікнаЗКалендаремToolStripMenuItem.Size = new Size(292, 26);
            оновитиВікнаЗКалендаремToolStripMenuItem.Text = "Оновити вікна з календарем";
            оновитиВікнаЗКалендаремToolStripMenuItem.Click += оновитиВікнаЗКалендаремToolStripMenuItem_Click;
            // 
            // вікнаToolStripMenuItem
            // 
            вікнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { каскадToolStripMenuItem, горизонтальноToolStripMenuItem, вертикальноToolStripMenuItem });
            вікнаToolStripMenuItem.Name = "вікнаToolStripMenuItem";
            вікнаToolStripMenuItem.Size = new Size(60, 24);
            вікнаToolStripMenuItem.Text = "Вікна";
            // 
            // каскадToolStripMenuItem
            // 
            каскадToolStripMenuItem.Name = "каскадToolStripMenuItem";
            каскадToolStripMenuItem.Size = new Size(199, 26);
            каскадToolStripMenuItem.Text = "Каскад";
            каскадToolStripMenuItem.Click += каскадToolStripMenuItem_Click;
            // 
            // горизонтальноToolStripMenuItem
            // 
            горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            горизонтальноToolStripMenuItem.Size = new Size(199, 26);
            горизонтальноToolStripMenuItem.Text = "Горизонтально";
            горизонтальноToolStripMenuItem.Click += горизонтальноToolStripMenuItem_Click;
            // 
            // вертикальноToolStripMenuItem
            // 
            вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            вертикальноToolStripMenuItem.Size = new Size(199, 26);
            вертикальноToolStripMenuItem.Text = "Вертикально";
            вертикальноToolStripMenuItem.Click += вертикальноToolStripMenuItem_Click;
            // 
            // закритиВікнаЗКалендаремToolStripMenuItem
            // 
            закритиВікнаЗКалендаремToolStripMenuItem.Name = "закритиВікнаЗКалендаремToolStripMenuItem";
            закритиВікнаЗКалендаремToolStripMenuItem.Size = new Size(292, 26);
            закритиВікнаЗКалендаремToolStripMenuItem.Text = "Закрити вікна з календарем";
            закритиВікнаЗКалендаремToolStripMenuItem.Click += закритиВікнаЗКалендаремToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вікноToolStripMenuItem;
        private ToolStripMenuItem новеToolStripMenuItem;
        private ToolStripMenuItem вікнаToolStripMenuItem;
        private ToolStripMenuItem каскадToolStripMenuItem;
        private ToolStripMenuItem горизонтальноToolStripMenuItem;
        private ToolStripMenuItem вертикальноToolStripMenuItem;
        private ToolStripMenuItem новеЗКалендаремToolStripMenuItem;
        private ToolStripMenuItem оновитиВікнаЗКалендаремToolStripMenuItem;
        private ToolStripMenuItem закритиВікнаЗКалендаремToolStripMenuItem;
    }
}
