namespace FormData
{
    partial class NewEventForm
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
            label2 = new Label();
            textBoxTitle = new TextBox();
            dateTimePicker = new DateTimePicker();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(20, 37);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(199, 27);
            textBoxTitle.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(20, 90);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(199, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Location = new Point(20, 137);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // NewEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 209);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewEventForm";
            Text = "NewEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxTitle;
        private DateTimePicker dateTimePicker;
        private Button buttonAdd;
    }
}