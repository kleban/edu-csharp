namespace ReadWriteText
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
            buttonOpen = new Button();
            buttonSave = new Button();
            textBoxEditor = new TextBox();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(31, 25);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(148, 25);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxEditor
            // 
            textBoxEditor.Location = new Point(31, 75);
            textBoxEditor.Multiline = true;
            textBoxEditor.Name = "textBoxEditor";
            textBoxEditor.ScrollBars = ScrollBars.Both;
            textBoxEditor.Size = new Size(734, 342);
            textBoxEditor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEditor);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private Button buttonSave;
        private TextBox textBoxEditor;
    }
}
