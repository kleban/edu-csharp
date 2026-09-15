namespace FileSystem.DrivesDemo
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
            comboBoxDrives = new ComboBox();
            label1 = new Label();
            labelSize = new Label();
            label3 = new Label();
            labelLabel = new Label();
            listBoxDirs = new ListBox();
            buttonMoveInside = new Button();
            buttonMoveUp = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelPath = new ToolStripStatusLabel();
            listBoxFiles = new ListBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(12, 21);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(170, 28);
            comboBoxDrives.TabIndex = 0;
            comboBoxDrives.SelectedIndexChanged += comboBoxDrives_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 24);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "Size";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(280, 24);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(15, 20);
            labelSize.TabIndex = 2;
            labelSize.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 56);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "Label";
            // 
            // labelLabel
            // 
            labelLabel.AutoSize = true;
            labelLabel.Location = new Point(280, 56);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size(15, 20);
            labelLabel.TabIndex = 4;
            labelLabel.Text = "-";
            // 
            // listBoxDirs
            // 
            listBoxDirs.FormattingEnabled = true;
            listBoxDirs.Location = new Point(12, 66);
            listBoxDirs.Name = "listBoxDirs";
            listBoxDirs.Size = new Size(170, 324);
            listBoxDirs.TabIndex = 5;
            // 
            // buttonMoveInside
            // 
            buttonMoveInside.Location = new Point(214, 102);
            buttonMoveInside.Name = "buttonMoveInside";
            buttonMoveInside.Size = new Size(138, 29);
            buttonMoveInside.TabIndex = 6;
            buttonMoveInside.Text = "Open Folder";
            buttonMoveInside.UseVisualStyleBackColor = true;
            buttonMoveInside.Click += buttonMoveInside_Click;
            // 
            // buttonMoveUp
            // 
            buttonMoveUp.Location = new Point(214, 149);
            buttonMoveUp.Name = "buttonMoveUp";
            buttonMoveUp.Size = new Size(138, 29);
            buttonMoveUp.TabIndex = 7;
            buttonMoveUp.Text = "Go to Parent";
            buttonMoveUp.UseVisualStyleBackColor = true;
            buttonMoveUp.Click += buttonMoveUp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 198);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 8;
            button1.Text = "Create Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelPath });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPath
            // 
            toolStripStatusLabelPath.Name = "toolStripStatusLabelPath";
            toolStripStatusLabelPath.Size = new Size(15, 20);
            toolStripStatusLabelPath.Text = "-";
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.Location = new Point(214, 233);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(170, 164);
            listBoxFiles.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFiles);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(buttonMoveUp);
            Controls.Add(buttonMoveInside);
            Controls.Add(listBoxDirs);
            Controls.Add(labelLabel);
            Controls.Add(label3);
            Controls.Add(labelSize);
            Controls.Add(label1);
            Controls.Add(comboBoxDrives);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDrives;
        private Label label1;
        private Label labelSize;
        private Label label3;
        private Label labelLabel;
        private ListBox listBoxDirs;
        private Button buttonMoveInside;
        private Button buttonMoveUp;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelPath;
        private ListBox listBoxFiles;
    }
}
