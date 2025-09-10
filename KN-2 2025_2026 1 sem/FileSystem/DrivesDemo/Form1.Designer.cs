namespace DrivesDemo
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
            panel1 = new Panel();
            listBoxDirectories = new ListBox();
            labelCurrentDirectory = new Label();
            buttonCreateDirectory = new Button();
            textBoxCreateDirectory = new TextBox();
            listBoxFiles = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(15, 14);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(218, 28);
            comboBoxDrives.TabIndex = 0;
            comboBoxDrives.SelectedIndexChanged += comboBoxDrives_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(listBoxFiles);
            panel1.Controls.Add(listBoxDirectories);
            panel1.Controls.Add(comboBoxDrives);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 484);
            panel1.TabIndex = 1;
            // 
            // listBoxDirectories
            // 
            listBoxDirectories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxDirectories.FormattingEnabled = true;
            listBoxDirectories.Location = new Point(15, 48);
            listBoxDirectories.Name = "listBoxDirectories";
            listBoxDirectories.Size = new Size(218, 184);
            listBoxDirectories.TabIndex = 1;
            listBoxDirectories.DoubleClick += listBoxDirectories_DoubleClick;
            listBoxDirectories.MouseDoubleClick += listBoxDirectories_MouseDoubleClick;
            // 
            // labelCurrentDirectory
            // 
            labelCurrentDirectory.AutoSize = true;
            labelCurrentDirectory.Location = new Point(276, 22);
            labelCurrentDirectory.Name = "labelCurrentDirectory";
            labelCurrentDirectory.Size = new Size(33, 20);
            labelCurrentDirectory.TabIndex = 2;
            labelCurrentDirectory.Text = "----";
            // 
            // buttonCreateDirectory
            // 
            buttonCreateDirectory.Location = new Point(423, 48);
            buttonCreateDirectory.Name = "buttonCreateDirectory";
            buttonCreateDirectory.Size = new Size(94, 29);
            buttonCreateDirectory.TabIndex = 3;
            buttonCreateDirectory.Text = "Create";
            buttonCreateDirectory.UseVisualStyleBackColor = true;
            buttonCreateDirectory.Click += buttonCreateDirectory_Click;
            // 
            // textBoxCreateDirectory
            // 
            textBoxCreateDirectory.Location = new Point(276, 48);
            textBoxCreateDirectory.Name = "textBoxCreateDirectory";
            textBoxCreateDirectory.Size = new Size(125, 27);
            textBoxCreateDirectory.TabIndex = 4;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.Location = new Point(15, 238);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(218, 224);
            listBoxFiles.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(textBoxCreateDirectory);
            Controls.Add(buttonCreateDirectory);
            Controls.Add(labelCurrentDirectory);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDrives;
        private Panel panel1;
        private ListBox listBoxDirectories;
        private Label labelCurrentDirectory;
        private Button buttonCreateDirectory;
        private TextBox textBoxCreateDirectory;
        private ListBox listBoxFiles;
    }
}
