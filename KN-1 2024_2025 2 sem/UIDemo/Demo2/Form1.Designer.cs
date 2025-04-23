namespace Demo2
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
            numericUpDown = new NumericUpDown();
            trackBar = new TrackBar();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Segoe UI", 14F);
            numericUpDown.Location = new Point(34, 52);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(150, 39);
            numericUpDown.TabIndex = 0;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(34, 144);
            trackBar.Maximum = 100;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(731, 56);
            trackBar.TabIndex = 1;
            trackBar.ValueChanged += trackBar_ValueChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(34, 341);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(731, 78);
            progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(trackBar);
            Controls.Add(numericUpDown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown;
        private TrackBar trackBar;
        private ProgressBar progressBar1;
    }
}
