namespace MDI
{
    partial class MdiDemo4
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
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 124);
            progressBar1.TabIndex = 0;
            // 
            // MdiDemo4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 124);
            Controls.Add(progressBar1);
            Name = "MdiDemo4";
            Text = "MdiDemo4";
            Load += MdiDemo4_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
    }
}