namespace LibraryAppDemo
{
    partial class MainForm
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
            listBoxBooks = new ListBox();
            buttonDeleteBook = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthors = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYear = new MaskedTextBox();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.Dock = DockStyle.Left;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(0, 0);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(226, 450);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Enabled = false;
            buttonDeleteBook.Location = new Point(244, 415);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(75, 23);
            buttonDeleteBook.TabIndex = 1;
            buttonDeleteBook.Text = "Видалити";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(textBoxYear);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxAuthors);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(244, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Нова книга";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор/и";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 120);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 167);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(17, 50);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(165, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxAuthors
            // 
            textBoxAuthors.Location = new Point(17, 94);
            textBoxAuthors.Name = "textBoxAuthors";
            textBoxAuthors.Size = new Size(165, 23);
            textBoxAuthors.TabIndex = 5;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(17, 138);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(165, 23);
            textBoxISBN.TabIndex = 5;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(17, 188);
            textBoxYear.Mask = "0000";
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(165, 23);
            textBoxYear.TabIndex = 6;
            textBoxYear.ValidatingType = typeof(int);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(107, 229);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Додати";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += this.buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonDeleteBook);
            Controls.Add(listBoxBooks);
            Name = "MainForm";
            Text = "Бібліотека 0.7 Beta";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button buttonDeleteBook;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button buttonSave;
        private MaskedTextBox textBoxYear;
        private TextBox textBoxISBN;
        private TextBox textBoxAuthors;
        private TextBox textBoxTitle;
    }
}
