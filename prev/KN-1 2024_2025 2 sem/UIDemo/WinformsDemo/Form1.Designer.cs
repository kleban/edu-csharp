namespace WinformsDemo
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
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxResult = new TextBox();
            label2 = new Label();
            buttonCalc = new Button();
            comboBoxOperators = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Segoe UI", 14F);
            textBoxNum1.Location = new Point(26, 37);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(125, 39);
            textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Segoe UI", 14F);
            textBoxNum2.Location = new Point(223, 37);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(125, 39);
            textBoxNum2.TabIndex = 1;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 14F);
            textBoxResult.Location = new Point(407, 37);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 39);
            textBoxResult.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(354, 40);
            label2.Name = "label2";
            label2.Size = new Size(30, 32);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 12F);
            buttonCalc.Location = new Point(26, 93);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(506, 55);
            buttonCalc.TabIndex = 5;
            buttonCalc.Text = "Обчислити";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // comboBoxOperators
            // 
            comboBoxOperators.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperators.Font = new Font("Segoe UI", 14F);
            comboBoxOperators.FormattingEnabled = true;
            comboBoxOperators.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBoxOperators.Location = new Point(157, 37);
            comboBoxOperators.Name = "comboBoxOperators";
            comboBoxOperators.Size = new Size(60, 39);
            comboBoxOperators.TabIndex = 6;
            comboBoxOperators.SelectedIndexChanged += comboBoxOperators_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 374);
            Controls.Add(comboBoxOperators);
            Controls.Add(buttonCalc);
            Controls.Add(label2);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxResult;
        private Label label2;
        private Button buttonCalc;
        private ComboBox comboBoxOperators;
    }
}
