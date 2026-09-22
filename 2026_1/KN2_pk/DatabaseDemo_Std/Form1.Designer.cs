namespace DatabaseDemo_Std
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
            listBoxScores = new ListBox();
            buttonAddStudent = new Button();
            SuspendLayout();
            // 
            // listBoxScores
            // 
            listBoxScores.Dock = DockStyle.Left;
            listBoxScores.FormattingEnabled = true;
            listBoxScores.Location = new Point(0, 0);
            listBoxScores.Name = "listBoxScores";
            listBoxScores.Size = new Size(364, 450);
            listBoxScores.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(384, 27);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(94, 29);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Add Score";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddStudent);
            Controls.Add(listBoxScores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxScores;
        private Button buttonAddStudent;
    }
}
