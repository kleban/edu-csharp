namespace ProductsApp
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
            listBox1 = new ListBox();
            buttonCreateProduct = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            текстToolStripMenuItem1 = new ToolStripMenuItem();
            cSVToolStripMenuItem1 = new ToolStripMenuItem();
            jSONToolStripMenuItem1 = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            eXCELToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelPath = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 384);
            listBox1.TabIndex = 0;
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.Location = new Point(333, 70);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(94, 59);
            buttonCreateProduct.TabIndex = 1;
            buttonCreateProduct.Text = "Create Product";
            buttonCreateProduct.UseVisualStyleBackColor = true;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(224, 26);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += текстToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстToolStripMenuItem1, cSVToolStripMenuItem1, jSONToolStripMenuItem1, xMLToolStripMenuItem1, eXCELToolStripMenuItem1 });
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(224, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти як...";
            // 
            // текстToolStripMenuItem1
            // 
            текстToolStripMenuItem1.Name = "текстToolStripMenuItem1";
            текстToolStripMenuItem1.Size = new Size(224, 26);
            текстToolStripMenuItem1.Tag = "txt";
            текстToolStripMenuItem1.Text = "Текст";
            текстToolStripMenuItem1.Click += текстToolStripMenuItem1_Click;
            // 
            // cSVToolStripMenuItem1
            // 
            cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            cSVToolStripMenuItem1.Size = new Size(224, 26);
            cSVToolStripMenuItem1.Tag = "csv";
            cSVToolStripMenuItem1.Text = "CSV";
            cSVToolStripMenuItem1.Click += текстToolStripMenuItem1_Click;
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new Size(224, 26);
            jSONToolStripMenuItem1.Tag = "json";
            jSONToolStripMenuItem1.Text = "JSON";
            jSONToolStripMenuItem1.Click += текстToolStripMenuItem1_Click;
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(224, 26);
            xMLToolStripMenuItem1.Tag = "xml";
            xMLToolStripMenuItem1.Text = "XML";
            xMLToolStripMenuItem1.Click += текстToolStripMenuItem1_Click;
            // 
            // eXCELToolStripMenuItem1
            // 
            eXCELToolStripMenuItem1.Name = "eXCELToolStripMenuItem1";
            eXCELToolStripMenuItem1.Size = new Size(224, 26);
            eXCELToolStripMenuItem1.Tag = "excel";
            eXCELToolStripMenuItem1.Text = "EXCEL";
            eXCELToolStripMenuItem1.Click += текстToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPath });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPath
            // 
            toolStripStatusLabelPath.Name = "toolStripStatusLabelPath";
            toolStripStatusLabelPath.Size = new Size(27, 20);
            toolStripStatusLabelPath.Text = "\"-\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(buttonCreateProduct);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonCreateProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelPath;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem текстToolStripMenuItem1;
        private ToolStripMenuItem cSVToolStripMenuItem1;
        private ToolStripMenuItem jSONToolStripMenuItem1;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStripMenuItem eXCELToolStripMenuItem1;
    }
}
