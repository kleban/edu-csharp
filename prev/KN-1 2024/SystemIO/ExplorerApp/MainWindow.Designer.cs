namespace ExplorerApp
{
    partial class MainWindow
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
            panel1 = new Panel();
            listBoxFileSystemItems = new ListBox();
            groupBox1 = new GroupBox();
            comboBoxDrives = new ComboBox();
            groupBox2 = new GroupBox();
            labelFormat = new Label();
            labelRemoveble = new Label();
            labelFree = new Label();
            labelSize = new Label();
            buttonChooseDirectory = new Button();
            labelDirectoryToSave = new Label();
            textBoxDirectoryName = new TextBox();
            listBoxFiles = new ListBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            labelFileParent = new Label();
            labelFileSize = new Label();
            labelFileExtension = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxFileSystemItems);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 450);
            panel1.TabIndex = 0;
            // 
            // listBoxFileSystemItems
            // 
            listBoxFileSystemItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFileSystemItems.FormattingEnabled = true;
            listBoxFileSystemItems.Location = new Point(24, 118);
            listBoxFileSystemItems.Name = "listBoxFileSystemItems";
            listBoxFileSystemItems.Size = new Size(272, 304);
            listBoxFileSystemItems.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxDrives);
            groupBox1.Location = new Point(24, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Drives ";
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(22, 37);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(231, 28);
            comboBoxDrives.TabIndex = 0;
            comboBoxDrives.SelectedIndexChanged += comboBoxDrives_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelFormat);
            groupBox2.Controls.Add(labelRemoveble);
            groupBox2.Controls.Add(labelFree);
            groupBox2.Controls.Add(labelSize);
            groupBox2.Location = new Point(338, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 163);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "- Drive Info -";
            // 
            // labelFormat
            // 
            labelFormat.AutoSize = true;
            labelFormat.Location = new Point(17, 131);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(50, 20);
            labelFormat.TabIndex = 3;
            labelFormat.Text = "label1";
            // 
            // labelRemoveble
            // 
            labelRemoveble.AutoSize = true;
            labelRemoveble.Location = new Point(17, 99);
            labelRemoveble.Name = "labelRemoveble";
            labelRemoveble.Size = new Size(50, 20);
            labelRemoveble.TabIndex = 2;
            labelRemoveble.Text = "label1";
            // 
            // labelFree
            // 
            labelFree.AutoSize = true;
            labelFree.Location = new Point(17, 65);
            labelFree.Name = "labelFree";
            labelFree.Size = new Size(50, 20);
            labelFree.TabIndex = 1;
            labelFree.Text = "label1";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(17, 33);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(50, 20);
            labelSize.TabIndex = 0;
            labelSize.Text = "label1";
            // 
            // buttonChooseDirectory
            // 
            buttonChooseDirectory.Location = new Point(338, 229);
            buttonChooseDirectory.Name = "buttonChooseDirectory";
            buttonChooseDirectory.Size = new Size(143, 29);
            buttonChooseDirectory.TabIndex = 2;
            buttonChooseDirectory.Text = "Choose directory";
            buttonChooseDirectory.UseVisualStyleBackColor = true;
            buttonChooseDirectory.Click += buttonChooseDirectory_Click;
            // 
            // labelDirectoryToSave
            // 
            labelDirectoryToSave.AutoSize = true;
            labelDirectoryToSave.Location = new Point(338, 265);
            labelDirectoryToSave.Name = "labelDirectoryToSave";
            labelDirectoryToSave.Size = new Size(50, 20);
            labelDirectoryToSave.TabIndex = 4;
            labelDirectoryToSave.Text = "label1";
            // 
            // textBoxDirectoryName
            // 
            textBoxDirectoryName.Location = new Point(338, 196);
            textBoxDirectoryName.Name = "textBoxDirectoryName";
            textBoxDirectoryName.Size = new Size(272, 27);
            textBoxDirectoryName.TabIndex = 5;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.Location = new Point(641, 67);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(272, 264);
            listBoxFiles.TabIndex = 6;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(641, 30);
            button1.Name = "button1";
            button1.Size = new Size(272, 29);
            button1.TabIndex = 7;
            button1.Text = "Choose directory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelFileParent);
            groupBox3.Controls.Add(labelFileSize);
            groupBox3.Controls.Add(labelFileExtension);
            groupBox3.Location = new Point(919, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 138);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "- File Info -";
            // 
            // labelFileParent
            // 
            labelFileParent.AutoSize = true;
            labelFileParent.Location = new Point(17, 99);
            labelFileParent.Name = "labelFileParent";
            labelFileParent.Size = new Size(50, 20);
            labelFileParent.TabIndex = 2;
            labelFileParent.Text = "label1";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.Location = new Point(17, 65);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new Size(50, 20);
            labelFileSize.TabIndex = 1;
            labelFileSize.Text = "label1";
            // 
            // labelFileExtension
            // 
            labelFileExtension.AutoSize = true;
            labelFileExtension.Location = new Point(17, 33);
            labelFileExtension.Name = "labelFileExtension";
            labelFileExtension.Size = new Size(50, 20);
            labelFileExtension.TabIndex = 0;
            labelFileExtension.Text = "label1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 450);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(listBoxFiles);
            Controls.Add(textBoxDirectoryName);
            Controls.Add(labelDirectoryToSave);
            Controls.Add(buttonChooseDirectory);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox comboBoxDrives;
        private ListBox listBoxFileSystemItems;
        private GroupBox groupBox2;
        private Label labelRemoveble;
        private Label labelFree;
        private Label labelSize;
        private Label labelFormat;
        private Button buttonChooseDirectory;
        private Label labelDirectoryToSave;
        private TextBox textBoxDirectoryName;
        private ListBox listBoxFiles;
        private Button button1;
        private GroupBox groupBox3;
        private Label labelFileParent;
        private Label labelFileSize;
        private Label labelFileExtension;
    }
}
