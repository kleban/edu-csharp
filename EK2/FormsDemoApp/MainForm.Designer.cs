namespace FormsDemoApp
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
            button1 = new Button();
            label1 = new Label();
            linkLabelText = new LinkLabel();
            textBoxDemo = new TextBox();
            buttonReadTextBox = new Button();
            textArea = new TextBox();
            buttonAddNewLine = new Button();
            numericUpDownProgress = new NumericUpDown();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            richTextBox1 = new RichTextBox();
            progressBar = new ProgressBar();
            trackBarProgress = new TrackBar();
            pictureBox1 = new PictureBox();
            buttonOpenListsForm = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(23, 12);
            button1.Name = "button1";
            button1.Size = new Size(205, 69);
            button1.TabIndex = 0;
            button1.Text = "Click Me! (0)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 115);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Sample Text";
            // 
            // linkLabelText
            // 
            linkLabelText.AutoSize = true;
            linkLabelText.Location = new Point(23, 175);
            linkLabelText.Name = "linkLabelText";
            linkLabelText.Size = new Size(124, 20);
            linkLabelText.TabIndex = 2;
            linkLabelText.TabStop = true;
            linkLabelText.Text = "Перейти на сайт";
            // 
            // textBoxDemo
            // 
            textBoxDemo.Location = new Point(23, 138);
            textBoxDemo.Name = "textBoxDemo";
            textBoxDemo.Size = new Size(205, 27);
            textBoxDemo.TabIndex = 3;
            // 
            // buttonReadTextBox
            // 
            buttonReadTextBox.Location = new Point(134, 171);
            buttonReadTextBox.Name = "buttonReadTextBox";
            buttonReadTextBox.Size = new Size(94, 29);
            buttonReadTextBox.TabIndex = 4;
            buttonReadTextBox.Text = "Read Text";
            buttonReadTextBox.UseVisualStyleBackColor = true;
            buttonReadTextBox.Click += buttonReadTextBox_Click;
            // 
            // textArea
            // 
            textArea.Location = new Point(23, 217);
            textArea.Multiline = true;
            textArea.Name = "textArea";
            textArea.Size = new Size(205, 162);
            textArea.TabIndex = 5;
            // 
            // buttonAddNewLine
            // 
            buttonAddNewLine.Location = new Point(92, 385);
            buttonAddNewLine.Name = "buttonAddNewLine";
            buttonAddNewLine.Size = new Size(136, 29);
            buttonAddNewLine.TabIndex = 6;
            buttonAddNewLine.Text = "Add New Line";
            buttonAddNewLine.UseVisualStyleBackColor = true;
            buttonAddNewLine.Click += buttonAddNewLine_Click;
            // 
            // numericUpDownProgress
            // 
            numericUpDownProgress.DecimalPlaces = 2;
            numericUpDownProgress.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownProgress.Location = new Point(246, 12);
            numericUpDownProgress.Name = "numericUpDownProgress";
            numericUpDownProgress.Size = new Size(192, 27);
            numericUpDownProgress.TabIndex = 7;
            numericUpDownProgress.ValueChanged += numericUpDownProgress_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(246, 89);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(192, 27);
            maskedTextBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 66);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 9;
            label2.Text = "Masked Text";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(246, 138);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 368);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(466, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Indeterminate;
            checkBox3.Location = new Point(466, 75);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(466, 138);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(466, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(466, 204);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(106, 30);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(466, 259);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(407, 161);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(23, 441);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(850, 29);
            progressBar.TabIndex = 19;
            // 
            // trackBarProgress
            // 
            trackBarProgress.Location = new Point(594, 15);
            trackBarProgress.Maximum = 100;
            trackBarProgress.Name = "trackBarProgress";
            trackBarProgress.Size = new Size(279, 56);
            trackBarProgress.TabIndex = 20;
            trackBarProgress.Scroll += trackBarProgress_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vasily_koloda_8CqDvPuo_kI_unsplash;
            pictureBox1.Location = new Point(607, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // buttonOpenListsForm
            // 
            buttonOpenListsForm.Font = new Font("Segoe UI", 14F);
            buttonOpenListsForm.Location = new Point(902, 18);
            buttonOpenListsForm.Name = "buttonOpenListsForm";
            buttonOpenListsForm.Size = new Size(238, 69);
            buttonOpenListsForm.TabIndex = 22;
            buttonOpenListsForm.Text = "ListsDemo";
            buttonOpenListsForm.UseVisualStyleBackColor = true;
            buttonOpenListsForm.Click += this.buttonOpenListsForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 493);
            Controls.Add(buttonOpenListsForm);
            Controls.Add(pictureBox1);
            Controls.Add(trackBarProgress);
            Controls.Add(progressBar);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(numericUpDownProgress);
            Controls.Add(buttonAddNewLine);
            Controls.Add(textArea);
            Controls.Add(buttonReadTextBox);
            Controls.Add(textBoxDemo);
            Controls.Add(linkLabelText);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private LinkLabel linkLabelText;
        private TextBox textBoxDemo;
        private Button buttonReadTextBox;
        private TextBox textArea;
        private Button buttonAddNewLine;
        private NumericUpDown numericUpDownProgress;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar;
        private TrackBar trackBarProgress;
        private PictureBox pictureBox1;
        private Button buttonOpenListsForm;
    }
}
