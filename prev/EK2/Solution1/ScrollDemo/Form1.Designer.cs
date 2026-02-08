namespace ScrollDemo
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
            numericUpDown1 = new NumericUpDown();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16F);
            numericUpDown1.Location = new Point(47, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 50);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(260, 35);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(514, 69);
            trackBar1.TabIndex = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(47, 147);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(727, 183);
            progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 358);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
    }
}
