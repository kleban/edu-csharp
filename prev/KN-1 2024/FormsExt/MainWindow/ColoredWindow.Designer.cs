namespace MainWindow
{
    partial class ColoredWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonChangeColor = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Location = new Point(190, 124);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(141, 29);
            buttonChangeColor.TabIndex = 0;
            buttonChangeColor.Text = "Change Color";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ColoredWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 165);
            Controls.Add(label1);
            Controls.Add(buttonChangeColor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ColoredWindow";
            Text = "ColoredWindow";
            Move += ColoredWindow_Move;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonChangeColor;
        private Label label1;
    }
}