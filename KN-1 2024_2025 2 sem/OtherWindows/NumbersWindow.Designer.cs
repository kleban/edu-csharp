namespace OtherWindows
{
    partial class NumbersWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            buttonGenerate = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 233);
            listBox1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(226, 12);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(94, 174);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(226, 192);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // NumbersWindow
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 233);
            Controls.Add(buttonSave);
            Controls.Add(buttonGenerate);
            Controls.Add(listBox1);
            Name = "NumbersWindow";
            Text = "NumbersWindow";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonGenerate;
        private Button buttonSave;
    }
}