namespace OtherWindows
{
    partial class ChildForm
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
            textBox1 = new TextBox();
            buttonApprove = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 1;
            // 
            // buttonApprove
            // 
            buttonApprove.DialogResult = DialogResult.OK;
            buttonApprove.Location = new Point(34, 216);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(125, 45);
            buttonApprove.TabIndex = 2;
            buttonApprove.Text = "Підтвердити";
            buttonApprove.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(174, 216);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 45);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Відмінити";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ChildForm
            // 
            AcceptButton = buttonApprove;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(419, 282);
            Controls.Add(buttonCancel);
            Controls.Add(buttonApprove);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ChildForm";
            Text = "ChildForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonApprove;
        private Button buttonCancel;
    }
}