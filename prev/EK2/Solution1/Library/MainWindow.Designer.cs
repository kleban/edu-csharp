namespace Library
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            listBoxBooks = new ListBox();
            groupBox1 = new GroupBox();
            buttonSave = new Button();
            buttonClean = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.Dock = DockStyle.Left;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(0, 0);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(260, 450);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonClean);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(282, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 324);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Нова книга";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(155, 256);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(18, 256);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(112, 34);
            buttonClean.TabIndex = 6;
            buttonClean.Text = "Очистити";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(18, 199);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 171);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 2;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Автор/и";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(282, 404);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBooks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Бібілотека 1.0";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private GroupBox groupBox1;
        private Button buttonSave;
        private Button buttonClean;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonDelete;
    }
}
