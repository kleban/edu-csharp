namespace VacancyApp
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
            listBoxAds = new ListBox();
            buttonOpen = new Button();
            buttonAdd = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // listBoxAds
            // 
            listBoxAds.FormattingEnabled = true;
            listBoxAds.Location = new Point(12, 12);
            listBoxAds.Name = "listBoxAds";
            listBoxAds.Size = new Size(267, 424);
            listBoxAds.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(308, 20);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(308, 69);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(308, 123);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(buttonOpen);
            Controls.Add(listBoxAds);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAds;
        private Button buttonOpen;
        private Button buttonAdd;
        private Button buttonSave;
    }
}
