namespace Calc
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxResult = new TextBox();
            label6 = new Label();
            buttonCalc = new Button();
            comboBoxOp = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Число 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 33);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Оператор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 33);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Число 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 33);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "Результат";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Segoe UI", 15F);
            textBoxNum1.Location = new Point(27, 61);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(116, 47);
            textBoxNum1.TabIndex = 4;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Segoe UI", 15F);
            textBoxNum2.Location = new Point(350, 61);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(116, 47);
            textBoxNum2.TabIndex = 5;
            // 
            // textBoxResult
            // 
            textBoxResult.Enabled = false;
            textBoxResult.Font = new Font("Segoe UI", 15F);
            textBoxResult.Location = new Point(543, 61);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(116, 47);
            textBoxResult.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 70);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 8;
            label6.Text = "=";
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(27, 137);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(632, 70);
            buttonCalc.TabIndex = 9;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // comboBoxOp
            // 
            comboBoxOp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOp.Font = new Font("Segoe UI", 15F);
            comboBoxOp.FormattingEnabled = true;
            comboBoxOp.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOp.Location = new Point(185, 61);
            comboBoxOp.Name = "comboBoxOp";
            comboBoxOp.Size = new Size(100, 49);
            comboBoxOp.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 247);
            Controls.Add(comboBoxOp);
            Controls.Add(buttonCalc);
            Controls.Add(label6);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxResult;
        private Label label6;
        private Button buttonCalc;
        private ComboBox comboBoxOp;
    }
}
