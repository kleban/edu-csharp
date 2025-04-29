namespace OtherWindows
{
    partial class PersonListWindow
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
            listBoxPersons = new ListBox();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // listBoxPersons
            // 
            listBoxPersons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.Location = new Point(12, 12);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(221, 304);
            listBoxPersons.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(256, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(256, 286);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(208, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(470, 286);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PersonListWindow
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(576, 327);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxPersons);
            Name = "PersonListWindow";
            Text = "PersonListWindow";
            FormClosing += PersonListWindow_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPersons;
        private Button buttonAdd;
        private Button buttonSave;
        private Button buttonCancel;
    }
}