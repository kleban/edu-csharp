namespace MDI
{
    partial class MdiChild2
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
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(6, 10);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // MdiChild2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 226);
            Controls.Add(monthCalendar1);
            Name = "MdiChild2";
            Text = "MdiChild2";
            Load += MdiChild2_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
    }
}