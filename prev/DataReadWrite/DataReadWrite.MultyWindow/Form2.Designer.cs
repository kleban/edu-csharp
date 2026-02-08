namespace DataReadWrite.MultyWindow
{
    partial class Form2
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 304);
            listBox1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 344);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}