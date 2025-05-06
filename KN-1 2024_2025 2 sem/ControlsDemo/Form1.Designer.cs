namespace ControlsDemo
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
            buttonClick = new Button();
            numericUpDownPlaces = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlaces).BeginInit();
            SuspendLayout();
            // 
            // buttonClick
            // 
            buttonClick.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClick.Location = new Point(694, 373);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(94, 65);
            buttonClick.TabIndex = 0;
            buttonClick.Text = "Click";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += buttonClick_Click;
            // 
            // numericUpDownPlaces
            // 
            numericUpDownPlaces.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDownPlaces.Font = new Font("Segoe UI", 26F);
            numericUpDownPlaces.Location = new Point(538, 373);
            numericUpDownPlaces.Name = "numericUpDownPlaces";
            numericUpDownPlaces.Size = new Size(150, 65);
            numericUpDownPlaces.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownPlaces);
            Controls.Add(buttonClick);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlaces).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClick;
        private NumericUpDown numericUpDownPlaces;
    }
}
