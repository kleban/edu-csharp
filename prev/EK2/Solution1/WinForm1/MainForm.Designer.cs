namespace WinForm1
{
    partial class MainForm
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
            buttonClickMe = new Button();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            maskedTextBox1 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            richTextBox1 = new RichTextBox();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // buttonClickMe
            // 
            buttonClickMe.BackColor = SystemColors.ActiveCaption;
            buttonClickMe.Font = new Font("Segoe UI", 18F);
            buttonClickMe.Location = new Point(374, 51);
            buttonClickMe.Name = "buttonClickMe";
            buttonClickMe.Size = new Size(283, 131);
            buttonClickMe.TabIndex = 0;
            buttonClickMe.Text = "Click ME!";
            buttonClickMe.UseVisualStyleBackColor = false;
            buttonClickMe.Click += buttonClickMe_Click;
            // 
            // button1
            // 
            button1.Location = new Point(230, 23);
            button1.Name = "button1";
            button1.Size = new Size(128, 87);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(584, 63);
            button2.Name = "button2";
            button2.Size = new Size(225, 87);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(65, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(65, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Indeterminate;
            checkBox3.Location = new Point(65, 112);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(549, 242);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(549, 277);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(549, 312);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 372);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 9;
            textBox1.Text = "Text";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(567, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 25);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(363, 329);
            maskedTextBox1.Mask = "000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(349, 215);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(164, 31);
            numericUpDown1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Клебан_рецензія;
            pictureBox1.Location = new Point(31, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 312);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(243, 283);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(507, 34);
            progressBar1.TabIndex = 15;
            progressBar1.Value = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(243, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(416, 113);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(225, 63);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(353, 69);
            trackBar1.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(maskedTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonClickMe);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClickMe;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private MaskedTextBox maskedTextBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
        private TrackBar trackBar1;
    }
}
