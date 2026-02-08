namespace ConfrencePlanner
{
    partial class AddNewSpeackerForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            comboBoxPosition = new ComboBox();
            label3 = new Label();
            textBoxOrg = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(26, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Position";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(26, 92);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(121, 23);
            comboBoxPosition.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 16);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Organization";
            // 
            // textBoxOrg
            // 
            textBoxOrg.Location = new Point(175, 34);
            textBoxOrg.Name = "textBoxOrg";
            textBoxOrg.Size = new Size(121, 23);
            textBoxOrg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(175, 92);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(121, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(26, 132);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(121, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(175, 132);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(121, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddNewSpeackerForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(334, 173);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxOrg);
            Controls.Add(label3);
            Controls.Add(comboBoxPosition);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddNewSpeackerForm";
            Text = "AddNewSpeackerForm";
            Load += AddNewSpeackerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private ComboBox comboBoxPosition;
        private Label label3;
        private TextBox textBoxOrg;
        private Label label4;
        private TextBox textBoxEmail;
        private Button buttonCancel;
        private Button buttonSave;
    }
}