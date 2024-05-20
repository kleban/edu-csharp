namespace FormData
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
            listBoxEvents = new ListBox();
            buttonAddEvent = new Button();
            dateTimePickerMaxEventDate = new DateTimePicker();
            SuspendLayout();
            // 
            // listBoxEvents
            // 
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.Location = new Point(27, 30);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(206, 384);
            listBoxEvents.TabIndex = 0;
            // 
            // buttonAddEvent
            // 
            buttonAddEvent.Location = new Point(266, 30);
            buttonAddEvent.Name = "buttonAddEvent";
            buttonAddEvent.Size = new Size(94, 29);
            buttonAddEvent.TabIndex = 1;
            buttonAddEvent.Text = "Add Event";
            buttonAddEvent.UseVisualStyleBackColor = true;
            buttonAddEvent.Click += buttonAddEvent_Click;
            // 
            // dateTimePickerMaxEventDate
            // 
            dateTimePickerMaxEventDate.Location = new Point(266, 65);
            dateTimePickerMaxEventDate.Name = "dateTimePickerMaxEventDate";
            dateTimePickerMaxEventDate.Size = new Size(203, 27);
            dateTimePickerMaxEventDate.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerMaxEventDate);
            Controls.Add(buttonAddEvent);
            Controls.Add(listBoxEvents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEvents;
        private Button buttonAddEvent;
        private DateTimePicker dateTimePickerMaxEventDate;
    }
}
