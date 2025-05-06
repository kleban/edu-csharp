namespace OtherWindows
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
            label1 = new Label();
            listBoxNumbers = new ListBox();
            buttonNumbersWindow = new Button();
            button1 = new Button();
            _dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_dg).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(90, 75);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(110, 77);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Open Window";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 85);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.Location = new Point(90, 232);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(150, 144);
            listBoxNumbers.TabIndex = 2;
            // 
            // buttonNumbersWindow
            // 
            buttonNumbersWindow.Location = new Point(257, 232);
            buttonNumbersWindow.Name = "buttonNumbersWindow";
            buttonNumbersWindow.Size = new Size(110, 77);
            buttonNumbersWindow.TabIndex = 3;
            buttonNumbersWindow.Text = "Open Numbers Window";
            buttonNumbersWindow.UseVisualStyleBackColor = true;
            buttonNumbersWindow.Click += buttonNumbersWindow_Click;
            // 
            // button1
            // 
            button1.Location = new Point(678, 167);
            button1.Name = "button1";
            button1.Size = new Size(110, 77);
            button1.TabIndex = 4;
            button1.Text = "Open Numbers Window";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _dg
            // 
            _dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dg.Location = new Point(402, 250);
            _dg.Name = "_dg";
            _dg.RowHeadersWidth = 51;
            _dg.Size = new Size(386, 188);
            _dg.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_dg);
            Controls.Add(button1);
            Controls.Add(buttonNumbersWindow);
            Controls.Add(listBoxNumbers);
            Controls.Add(label1);
            Controls.Add(buttonOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen;
        private Label label1;
        private ListBox listBoxNumbers;
        private Button buttonNumbersWindow;
        private Button button1;
        private DataGridView _dg;
    }
}
