namespace PasswordGeneratorApp
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
            progressBarPasswordLevel = new ProgressBar();
            labelPasswordLevel = new Label();
            groupBox1 = new GroupBox();
            checkBoxLower = new CheckBox();
            checkBoxDigits = new CheckBox();
            checkBoxSpecSymbols = new CheckBox();
            checkBoxUpper = new CheckBox();
            numericUpDownLength = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Segoe UI", 18F);
            buttonGenerate.Location = new Point(383, 32);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(177, 56);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 22F);
            textBoxPassword.Location = new Point(28, 32);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(331, 56);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonCopy
            // 
            buttonCopy.Font = new Font("Segoe UI", 18F);
            buttonCopy.Location = new Point(584, 34);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(117, 56);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // progressBarPasswordLevel
            // 
            progressBarPasswordLevel.Location = new Point(28, 94);
            progressBarPasswordLevel.Maximum = 10;
            progressBarPasswordLevel.Name = "progressBarPasswordLevel";
            progressBarPasswordLevel.Size = new Size(331, 17);
            progressBarPasswordLevel.TabIndex = 3;
            // 
            // labelPasswordLevel
            // 
            labelPasswordLevel.AutoSize = true;
            labelPasswordLevel.Font = new Font("Segoe UI", 14F);
            labelPasswordLevel.Location = new Point(28, 114);
            labelPasswordLevel.Name = "labelPasswordLevel";
            labelPasswordLevel.Size = new Size(24, 32);
            labelPasswordLevel.TabIndex = 4;
            labelPasswordLevel.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxLower);
            groupBox1.Controls.Add(checkBoxDigits);
            groupBox1.Controls.Add(checkBoxSpecSymbols);
            groupBox1.Controls.Add(checkBoxUpper);
            groupBox1.Controls.Add(numericUpDownLength);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 18F);
            groupBox1.Location = new Point(28, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 284);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " Конфігурація ";
            // 
            // checkBoxLower
            // 
            checkBoxLower.AutoSize = true;
            checkBoxLower.Location = new Point(380, 101);
            checkBoxLower.Name = "checkBoxLower";
            checkBoxLower.Size = new Size(187, 45);
            checkBoxLower.TabIndex = 5;
            checkBoxLower.Text = "малі букви";
            checkBoxLower.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            checkBoxDigits.AutoSize = true;
            checkBoxDigits.Location = new Point(380, 152);
            checkBoxDigits.Name = "checkBoxDigits";
            checkBoxDigits.Size = new Size(135, 45);
            checkBoxDigits.TabIndex = 4;
            checkBoxDigits.Text = "Цифри";
            checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecSymbols
            // 
            checkBoxSpecSymbols.AutoSize = true;
            checkBoxSpecSymbols.Location = new Point(380, 203);
            checkBoxSpecSymbols.Name = "checkBoxSpecSymbols";
            checkBoxSpecSymbols.Size = new Size(244, 45);
            checkBoxSpecSymbols.TabIndex = 3;
            checkBoxSpecSymbols.Text = "Спец. символи";
            checkBoxSpecSymbols.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpper
            // 
            checkBoxUpper.AutoSize = true;
            checkBoxUpper.Location = new Point(380, 50);
            checkBoxUpper.Name = "checkBoxUpper";
            checkBoxUpper.Size = new Size(237, 45);
            checkBoxUpper.TabIndex = 2;
            checkBoxUpper.Text = "ВЕЛИКІ БУКВИ";
            checkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(34, 103);
            numericUpDownLength.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(264, 47);
            numericUpDownLength.TabIndex = 1;
            numericUpDownLength.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 0;
            label1.Text = "Кількість символів";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(groupBox1);
            Controls.Add(labelPasswordLevel);
            Controls.Add(progressBarPasswordLevel);
            Controls.Add(buttonCopy);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonGenerate);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenerate;
        private TextBox textBoxPassword;
        private Button buttonCopy;
        private ProgressBar progressBarPasswordLevel;
        private Label labelPasswordLevel;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownLength;
        private Label label1;
        private CheckBox checkBoxLower;
        private CheckBox checkBoxDigits;
        private CheckBox checkBoxSpecSymbols;
        private CheckBox checkBoxUpper;
    }
}
