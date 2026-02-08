namespace PassGenerator
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
            buttonGenerate = new Button();
            textBoxPassword = new TextBox();
            buttonCopy = new Button();
            groupBox1 = new GroupBox();
            checkBoxLettersLower = new CheckBox();
            checkBoxSymbols = new CheckBox();
            checkBoxLettersUpper = new CheckBox();
            checkBoxDigits = new CheckBox();
            numericUpDownPassLength = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPassLength).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(288, 22);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(24, 22);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(244, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(381, 22);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 23);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxLettersLower);
            groupBox1.Controls.Add(checkBoxSymbols);
            groupBox1.Controls.Add(checkBoxLettersUpper);
            groupBox1.Controls.Add(checkBoxDigits);
            groupBox1.Controls.Add(numericUpDownPassLength);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 205);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Налаштування";
            // 
            // checkBoxLettersLower
            // 
            checkBoxLettersLower.AutoSize = true;
            checkBoxLettersLower.Location = new Point(11, 145);
            checkBoxLettersLower.Name = "checkBoxLettersLower";
            checkBoxLettersLower.Size = new Size(173, 19);
            checkBoxLettersLower.TabIndex = 5;
            checkBoxLettersLower.Text = "Букви у нижньому регістрі";
            checkBoxLettersLower.UseVisualStyleBackColor = true;
            // 
            // checkBoxSymbols
            // 
            checkBoxSymbols.AutoSize = true;
            checkBoxSymbols.Location = new Point(11, 170);
            checkBoxSymbols.Name = "checkBoxSymbols";
            checkBoxSymbols.Size = new Size(77, 19);
            checkBoxSymbols.TabIndex = 4;
            checkBoxSymbols.Text = "Символи";
            checkBoxSymbols.UseVisualStyleBackColor = true;
            // 
            // checkBoxLettersUpper
            // 
            checkBoxLettersUpper.AutoSize = true;
            checkBoxLettersUpper.Location = new Point(11, 120);
            checkBoxLettersUpper.Name = "checkBoxLettersUpper";
            checkBoxLettersUpper.Size = new Size(175, 19);
            checkBoxLettersUpper.TabIndex = 3;
            checkBoxLettersUpper.Text = "Букви у верхньому регістрі";
            checkBoxLettersUpper.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            checkBoxDigits.AutoSize = true;
            checkBoxDigits.Location = new Point(11, 95);
            checkBoxDigits.Name = "checkBoxDigits";
            checkBoxDigits.Size = new Size(65, 19);
            checkBoxDigits.TabIndex = 2;
            checkBoxDigits.Text = "Цифри";
            checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPassLength
            // 
            numericUpDownPassLength.Location = new Point(11, 55);
            numericUpDownPassLength.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPassLength.Name = "numericUpDownPassLength";
            numericUpDownPassLength.Size = new Size(126, 23);
            numericUpDownPassLength.TabIndex = 1;
            numericUpDownPassLength.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Довжина пароля";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 310);
            Controls.Add(groupBox1);
            Controls.Add(buttonCopy);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonGenerate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPassLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenerate;
        private TextBox textBoxPassword;
        private Button buttonCopy;
        private GroupBox groupBox1;
        private CheckBox checkBoxSymbols;
        private CheckBox checkBoxLettersUpper;
        private CheckBox checkBoxDigits;
        private NumericUpDown numericUpDownPassLength;
        private Label label1;
        private CheckBox checkBoxLettersLower;
    }
}
