namespace DataChartExample.DataForm
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
            chart1ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelName = new ToolStripStatusLabel();
            _dg = new DataGridView();
            chart2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dg).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chart1ToolStripMenuItem, chart2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(643, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chart1ToolStripMenuItem
            // 
            chart1ToolStripMenuItem.Name = "chart1ToolStripMenuItem";
            chart1ToolStripMenuItem.Size = new Size(66, 24);
            chart1ToolStripMenuItem.Text = "Chart1";
            chart1ToolStripMenuItem.Click += chart1ToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelName });
            statusStrip1.Location = new Point(0, 327);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(643, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelName
            // 
            toolStripStatusLabelName.Name = "toolStripStatusLabelName";
            toolStripStatusLabelName.Size = new Size(151, 20);
            toolStripStatusLabelName.Text = "toolStripStatusLabel1";
            // 
            // _dg
            // 
            _dg.AllowUserToAddRows = false;
            _dg.AllowUserToDeleteRows = false;
            _dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dg.Dock = DockStyle.Fill;
            _dg.Location = new Point(0, 28);
            _dg.Name = "_dg";
            _dg.ReadOnly = true;
            _dg.RowHeadersWidth = 51;
            _dg.Size = new Size(643, 299);
            _dg.TabIndex = 2;
            // 
            // chart2ToolStripMenuItem
            // 
            chart2ToolStripMenuItem.Name = "chart2ToolStripMenuItem";
            chart2ToolStripMenuItem.Size = new Size(66, 24);
            chart2ToolStripMenuItem.Text = "Chart2";
            chart2ToolStripMenuItem.Click += chart2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 353);
            Controls.Add(_dg);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelName;
        private DataGridView _dg;
        private ToolStripMenuItem chart1ToolStripMenuItem;
        private ToolStripMenuItem chart2ToolStripMenuItem;
    }
}
