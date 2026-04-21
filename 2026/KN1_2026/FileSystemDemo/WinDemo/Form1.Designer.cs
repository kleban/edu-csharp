namespace WinDemo
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
            panel1 = new Panel();
            buttonOpen = new Button();
            listBoxObjects = new ListBox();
            label1 = new Label();
            comboBoxDrives = new ComboBox();
            buttonCreateDir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(listBoxObjects);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxDrives);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 450);
            panel1.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 409);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(252, 29);
            buttonOpen.TabIndex = 3;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // listBoxObjects
            // 
            listBoxObjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.Location = new Point(12, 58);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(252, 344);
            listBoxObjects.TabIndex = 2;
            listBoxObjects.SelectedIndexChanged += listBoxObjects_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Drives";
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(77, 12);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(187, 28);
            comboBoxDrives.TabIndex = 0;
            comboBoxDrives.SelectedIndexChanged += comboBoxDrives_SelectedIndexChanged;
            // 
            // buttonCreateDir
            // 
            buttonCreateDir.Location = new Point(296, 13);
            buttonCreateDir.Name = "buttonCreateDir";
            buttonCreateDir.Size = new Size(154, 40);
            buttonCreateDir.TabIndex = 1;
            buttonCreateDir.Text = "Create";
            buttonCreateDir.UseVisualStyleBackColor = true;
            buttonCreateDir.Click += buttonCreateDir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateDir);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxDrives;
        private Label label1;
        private ListBox listBoxObjects;
        private Button buttonOpen;
        private Button buttonCreateDir;
    }
}
