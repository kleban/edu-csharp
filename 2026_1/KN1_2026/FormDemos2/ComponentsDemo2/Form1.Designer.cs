namespace ComponentsDemo2
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
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            buttonChangePicture = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 15F);
            numericUpDown1.Location = new Point(274, 28);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 41);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(39, 90);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 67);
            progressBar1.TabIndex = 1;
            toolTip1.SetToolTip(progressBar1, "Це результат прогресу");
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(39, 176);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(385, 56);
            trackBar1.TabIndex = 2;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://images.unsplash.com/photo-1761839258075-585182da7521?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            pictureBox1.Location = new Point(480, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonChangePicture
            // 
            buttonChangePicture.Location = new Point(330, 238);
            buttonChangePicture.Name = "buttonChangePicture";
            buttonChangePicture.Size = new Size(94, 29);
            buttonChangePicture.TabIndex = 4;
            buttonChangePicture.Text = "Select Picture";
            buttonChangePicture.UseVisualStyleBackColor = true;
            buttonChangePicture.Click += buttonChangePicture_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 240);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 108);
            textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(163, 286);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(296, 142);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(buttonChangePicture);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private Button buttonChangePicture;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private RichTextBox richTextBox1;
    }
}
