namespace GifDemo
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
            pictureBox = new PictureBox();
            nextFrameButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.giphy;
            pictureBox.Location = new Point(40, 36);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(101, 182);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // nextFrameButton
            // 
            nextFrameButton.Location = new Point(361, 389);
            nextFrameButton.Name = "nextFrameButton";
            nextFrameButton.Size = new Size(75, 23);
            nextFrameButton.TabIndex = 1;
            nextFrameButton.Text = "button1";
            nextFrameButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(286, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(nextFrameButton);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button nextFrameButton;
        private PictureBox pictureBox1;
    }
}
