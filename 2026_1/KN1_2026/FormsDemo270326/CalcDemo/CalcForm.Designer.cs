namespace CalcDemo
{
    partial class CalcForm
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
            txtA = new TextBox();
            txtB = new TextBox();
            labelOperator = new Label();
            labelResult = new Label();
            buttonCalculate = new Button();
            comboColors = new ComboBox();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 15F);
            txtA.Location = new Point(28, 32);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 34);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 15F);
            txtB.Location = new Point(209, 32);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 34);
            txtB.TabIndex = 1;
            // 
            // labelOperator
            // 
            labelOperator.AutoSize = true;
            labelOperator.Font = new Font("Segoe UI", 15F);
            labelOperator.Location = new Point(156, 35);
            labelOperator.Name = "labelOperator";
            labelOperator.Size = new Size(26, 28);
            labelOperator.TabIndex = 2;
            labelOperator.Text = "+";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 15F);
            labelResult.Location = new Point(28, 83);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(20, 28);
            labelResult.TabIndex = 3;
            labelResult.Text = "-";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 15F);
            buttonCalculate.Location = new Point(330, 32);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(110, 34);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // comboColors
            // 
            comboColors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboColors.Font = new Font("Segoe UI", 15F);
            comboColors.FormattingEnabled = true;
            comboColors.Location = new Point(28, 127);
            comboColors.Name = "comboColors";
            comboColors.Size = new Size(121, 36);
            comboColors.TabIndex = 5;
            comboColors.SelectedIndexChanged += comboColors_SelectedIndexChanged;
            // 
            // CalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 183);
            Controls.Add(comboColors);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            Controls.Add(labelOperator);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "CalcForm";
            Text = "Калькулятор v.1";
            Load += CalcForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Label labelOperator;
        private Label labelResult;
        private Button buttonCalculate;
        private ComboBox comboColors;
    }
}
