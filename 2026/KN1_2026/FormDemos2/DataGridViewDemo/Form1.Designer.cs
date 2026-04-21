namespace DataGridViewDemo
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
            _dg = new DataGridView();
            buttonCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)_dg).BeginInit();
            SuspendLayout();
            // 
            // _dg
            // 
            _dg.AllowUserToAddRows = false;
            _dg.AllowUserToDeleteRows = false;
            _dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dg.Dock = DockStyle.Bottom;
            _dg.Location = new Point(0, 62);
            _dg.Name = "_dg";
            _dg.ReadOnly = true;
            _dg.RowHeadersWidth = 51;
            _dg.Size = new Size(800, 388);
            _dg.TabIndex = 0;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(12, 12);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(94, 29);
            buttonCalc.TabIndex = 1;
            buttonCalc.Text = "Calculate";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalc);
            Controls.Add(_dg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_dg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _dg;
        private Button buttonCalc;
    }
}
