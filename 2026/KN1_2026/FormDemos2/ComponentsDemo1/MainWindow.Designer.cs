namespace ComponentsDemo1
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
            buttonSum = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkedListBoxRandNumbers = new CheckedListBox();
            labelSum = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            datePicker = new DateTimePicker();
            tmePicker = new DateTimePicker();
            dateTimePicker = new DateTimePicker();
            buttonCombineTime = new Button();
            monthCalendar1 = new MonthCalendar();
            linkLabel1 = new LinkLabel();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonSum
            // 
            buttonSum.Location = new Point(342, 44);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(190, 29);
            buttonSum.TabIndex = 0;
            buttonSum.Text = "Sum";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(36, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "По автору";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Indeterminate;
            checkBox2.Location = new Point(36, 115);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(135, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "По назві книги";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(36, 163);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "По вступу";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.CheckAlign = ContentAlignment.MiddleRight;
            radioButton1.Location = new Point(198, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(198, 114);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(198, 162);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxRandNumbers
            // 
            checkedListBoxRandNumbers.FormattingEnabled = true;
            checkedListBoxRandNumbers.Location = new Point(342, 79);
            checkedListBoxRandNumbers.Name = "checkedListBoxRandNumbers";
            checkedListBoxRandNumbers.Size = new Size(190, 180);
            checkedListBoxRandNumbers.TabIndex = 7;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(561, 79);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(50, 20);
            labelSum.TabIndex = 8;
            labelSum.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(21, 235);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 184);
            listBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 28);
            comboBox1.TabIndex = 10;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(185, 290);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(250, 27);
            datePicker.TabIndex = 11;
            // 
            // tmePicker
            // 
            tmePicker.Format = DateTimePickerFormat.Time;
            tmePicker.Location = new Point(441, 290);
            tmePicker.Name = "tmePicker";
            tmePicker.Size = new Size(250, 27);
            tmePicker.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd-MMM-yyyy HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(185, 358);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // buttonCombineTime
            // 
            buttonCombineTime.Location = new Point(185, 323);
            buttonCombineTime.Name = "buttonCombineTime";
            buttonCombineTime.Size = new Size(250, 29);
            buttonCombineTime.TabIndex = 14;
            buttonCombineTime.Text = "Combine";
            buttonCombineTime.UseVisualStyleBackColor = true;
            buttonCombineTime.Click += buttonCombineTime_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(612, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(612, 243);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(714, 243);
            maskedTextBox1.Mask = "+3(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 17;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(monthCalendar1);
            Controls.Add(buttonCombineTime);
            Controls.Add(dateTimePicker);
            Controls.Add(tmePicker);
            Controls.Add(datePicker);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(labelSum);
            Controls.Add(checkedListBoxRandNumbers);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(buttonSum);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSum;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckedListBox checkedListBoxRandNumbers;
        private Label labelSum;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private DateTimePicker datePicker;
        private DateTimePicker tmePicker;
        private DateTimePicker dateTimePicker;
        private Button buttonCombineTime;
        private MonthCalendar monthCalendar1;
        private LinkLabel linkLabel1;
        private MaskedTextBox maskedTextBox1;
    }
}
