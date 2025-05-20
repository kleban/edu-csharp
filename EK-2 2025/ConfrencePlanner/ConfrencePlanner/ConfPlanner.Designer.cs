namespace ConfrencePlanner
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
            splitContainer1 = new SplitContainer();
            _dgSpeakers = new DataGridView();
            panel1 = new Panel();
            buttonAddSpeaker = new Button();
            label1 = new Label();
            _dgReports = new DataGridView();
            panel2 = new Panel();
            buttonAddReport = new Button();
            labelReports = new Label();
            buttonShowAgenda = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgSpeakers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgReports).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(_dgSpeakers);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(_dgReports);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(657, 371);
            splitContainer1.SplitterDistance = 346;
            splitContainer1.TabIndex = 2;
            // 
            // _dgSpeakers
            // 
            _dgSpeakers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgSpeakers.Dock = DockStyle.Fill;
            _dgSpeakers.Location = new Point(0, 77);
            _dgSpeakers.Name = "_dgSpeakers";
            _dgSpeakers.Size = new Size(346, 294);
            _dgSpeakers.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(buttonAddSpeaker);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 77);
            panel1.TabIndex = 0;
            // 
            // buttonAddSpeaker
            // 
            buttonAddSpeaker.Location = new Point(11, 40);
            buttonAddSpeaker.Name = "buttonAddSpeaker";
            buttonAddSpeaker.Size = new Size(75, 23);
            buttonAddSpeaker.TabIndex = 1;
            buttonAddSpeaker.Text = "Add";
            buttonAddSpeaker.UseVisualStyleBackColor = true;
            buttonAddSpeaker.Click += buttonAddSpeaker_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 0;
            label1.Text = "Speakers";
            // 
            // _dgReports
            // 
            _dgReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgReports.Dock = DockStyle.Fill;
            _dgReports.Location = new Point(0, 77);
            _dgReports.Name = "_dgReports";
            _dgReports.Size = new Size(307, 294);
            _dgReports.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(buttonShowAgenda);
            panel2.Controls.Add(buttonAddReport);
            panel2.Controls.Add(labelReports);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 77);
            panel2.TabIndex = 1;
            // 
            // buttonAddReport
            // 
            buttonAddReport.Location = new Point(11, 40);
            buttonAddReport.Name = "buttonAddReport";
            buttonAddReport.Size = new Size(75, 23);
            buttonAddReport.TabIndex = 1;
            buttonAddReport.Text = "Add";
            buttonAddReport.UseVisualStyleBackColor = true;
            // 
            // labelReports
            // 
            labelReports.AutoSize = true;
            labelReports.Font = new Font("Segoe UI", 17F);
            labelReports.Location = new Point(1, 0);
            labelReports.Name = "labelReports";
            labelReports.Size = new Size(92, 31);
            labelReports.TabIndex = 0;
            labelReports.Text = "Reports";
            // 
            // buttonShowAgenda
            // 
            buttonShowAgenda.Location = new Point(220, 12);
            buttonShowAgenda.Name = "buttonShowAgenda";
            buttonShowAgenda.Size = new Size(75, 23);
            buttonShowAgenda.TabIndex = 2;
            buttonShowAgenda.Text = "Show Agenda";
            buttonShowAgenda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 371);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgSpeakers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgReports).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView _dgSpeakers;
        private Panel panel1;
        private Button buttonAddSpeaker;
        private Label label1;
        private DataGridView _dgReports;
        private Panel panel2;
        private Button buttonAddReport;
        private Label labelReports;
        private Button buttonShowAgenda;
    }
}
