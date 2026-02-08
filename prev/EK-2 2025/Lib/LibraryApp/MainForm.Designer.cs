namespace LibraryApp
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
            tabControl1 = new TabControl();
            tabPageBooks = new TabPage();
            splitContainer1 = new SplitContainer();
            listBoxBooks = new ListBox();
            groupBox2 = new GroupBox();
            buttonBookSave = new Button();
            buttonBookClear = new Button();
            comboBoxGenres = new ComboBox();
            numericUpDownYear = new NumericUpDown();
            textBoxBookAuthors = new TextBox();
            textBoxBookTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBoxMode = new CheckBox();
            buttonBookDelete = new Button();
            tabPageGenres = new TabPage();
            buttonGenreDelete = new Button();
            groupBox1 = new GroupBox();
            buttonGenreSave = new Button();
            buttonGenreCancel = new Button();
            textBoxGenreName = new TextBox();
            label1 = new Label();
            listBoxGenres = new ListBox();
            tabPageSearch = new TabPage();
            panel1 = new Panel();
            _dg = new DataGridView();
            label6 = new Label();
            textBoxBookSearchTitle = new TextBox();
            textBoxBookSearchAuthors = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            numericUpDownSearchFrom = new NumericUpDown();
            numericUpDownSearchTo = new NumericUpDown();
            label10 = new Label();
            comboBoxGenresSearch = new ComboBox();
            buttonSearch = new Button();
            tabControl1.SuspendLayout();
            tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            tabPageGenres.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchTo).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBooks);
            tabControl1.Controls.Add(tabPageGenres);
            tabControl1.Controls.Add(tabPageSearch);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            tabPageBooks.Controls.Add(splitContainer1);
            tabPageBooks.Location = new Point(4, 29);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(3);
            tabPageBooks.Size = new Size(792, 417);
            tabPageBooks.TabIndex = 0;
            tabPageBooks.Text = "Book";
            tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBoxBooks);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(buttonBookDelete);
            splitContainer1.Size = new Size(786, 411);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Dock = DockStyle.Fill;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(0, 0);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(400, 411);
            listBoxBooks.TabIndex = 4;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonBookSave);
            groupBox2.Controls.Add(buttonBookClear);
            groupBox2.Controls.Add(comboBoxGenres);
            groupBox2.Controls.Add(numericUpDownYear);
            groupBox2.Controls.Add(textBoxBookAuthors);
            groupBox2.Controls.Add(textBoxBookTitle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkBoxMode);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 349);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create / New Book";
            // 
            // buttonBookSave
            // 
            buttonBookSave.Location = new Point(123, 305);
            buttonBookSave.Name = "buttonBookSave";
            buttonBookSave.Size = new Size(94, 29);
            buttonBookSave.TabIndex = 10;
            buttonBookSave.Text = "Save";
            buttonBookSave.UseVisualStyleBackColor = true;
            buttonBookSave.Click += buttonBookSave_Click;
            // 
            // buttonBookClear
            // 
            buttonBookClear.Location = new Point(11, 305);
            buttonBookClear.Name = "buttonBookClear";
            buttonBookClear.Size = new Size(94, 29);
            buttonBookClear.TabIndex = 9;
            buttonBookClear.Text = "Cancel";
            buttonBookClear.UseVisualStyleBackColor = true;
            buttonBookClear.Click += buttonBookClear_Click;
            // 
            // comboBoxGenres
            // 
            comboBoxGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenres.FormattingEnabled = true;
            comboBoxGenres.Location = new Point(11, 261);
            comboBoxGenres.Name = "comboBoxGenres";
            comboBoxGenres.Size = new Size(206, 28);
            comboBoxGenres.TabIndex = 8;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(11, 208);
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(206, 27);
            numericUpDownYear.TabIndex = 7;
            // 
            // textBoxBookAuthors
            // 
            textBoxBookAuthors.Location = new Point(11, 152);
            textBoxBookAuthors.Name = "textBoxBookAuthors";
            textBoxBookAuthors.Size = new Size(206, 27);
            textBoxBookAuthors.TabIndex = 6;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(11, 93);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(206, 27);
            textBoxBookTitle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 238);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 182);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Pub Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 123);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Author/s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // checkBoxMode
            // 
            checkBoxMode.AutoSize = true;
            checkBoxMode.Enabled = false;
            checkBoxMode.Location = new Point(11, 28);
            checkBoxMode.Name = "checkBoxMode";
            checkBoxMode.Size = new Size(117, 24);
            checkBoxMode.TabIndex = 0;
            checkBoxMode.Text = "Create Mode";
            checkBoxMode.UseVisualStyleBackColor = true;
            checkBoxMode.CheckedChanged += checkBoxMode_CheckedChanged;
            // 
            // buttonBookDelete
            // 
            buttonBookDelete.Enabled = false;
            buttonBookDelete.Location = new Point(12, 368);
            buttonBookDelete.Name = "buttonBookDelete";
            buttonBookDelete.Size = new Size(94, 29);
            buttonBookDelete.TabIndex = 0;
            buttonBookDelete.Text = "Delete";
            buttonBookDelete.UseVisualStyleBackColor = true;
            buttonBookDelete.Click += buttonBookDelete_Click;
            // 
            // tabPageGenres
            // 
            tabPageGenres.Controls.Add(buttonGenreDelete);
            tabPageGenres.Controls.Add(groupBox1);
            tabPageGenres.Controls.Add(listBoxGenres);
            tabPageGenres.Location = new Point(4, 29);
            tabPageGenres.Name = "tabPageGenres";
            tabPageGenres.Padding = new Padding(3);
            tabPageGenres.Size = new Size(792, 417);
            tabPageGenres.TabIndex = 1;
            tabPageGenres.Text = "Genres";
            tabPageGenres.UseVisualStyleBackColor = true;
            // 
            // buttonGenreDelete
            // 
            buttonGenreDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGenreDelete.Enabled = false;
            buttonGenreDelete.Location = new Point(246, 380);
            buttonGenreDelete.Name = "buttonGenreDelete";
            buttonGenreDelete.Size = new Size(94, 29);
            buttonGenreDelete.TabIndex = 2;
            buttonGenreDelete.Text = "Delete";
            buttonGenreDelete.UseVisualStyleBackColor = true;
            buttonGenreDelete.Click += buttonGenreDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonGenreSave);
            groupBox1.Controls.Add(buttonGenreCancel);
            groupBox1.Controls.Add(textBoxGenreName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(246, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новий жанр";
            // 
            // buttonGenreSave
            // 
            buttonGenreSave.Location = new Point(132, 103);
            buttonGenreSave.Name = "buttonGenreSave";
            buttonGenreSave.Size = new Size(94, 29);
            buttonGenreSave.TabIndex = 3;
            buttonGenreSave.Text = "Save";
            buttonGenreSave.UseVisualStyleBackColor = true;
            buttonGenreSave.Click += buttonGenreSave_Click;
            // 
            // buttonGenreCancel
            // 
            buttonGenreCancel.Location = new Point(16, 103);
            buttonGenreCancel.Name = "buttonGenreCancel";
            buttonGenreCancel.Size = new Size(94, 29);
            buttonGenreCancel.TabIndex = 2;
            buttonGenreCancel.Text = "Cancel";
            buttonGenreCancel.UseVisualStyleBackColor = true;
            buttonGenreCancel.Click += buttonGenreCancel_Click;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Location = new Point(16, 58);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(210, 27);
            textBoxGenreName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            // 
            // listBoxGenres
            // 
            listBoxGenres.Dock = DockStyle.Left;
            listBoxGenres.FormattingEnabled = true;
            listBoxGenres.Location = new Point(3, 3);
            listBoxGenres.Name = "listBoxGenres";
            listBoxGenres.Size = new Size(220, 411);
            listBoxGenres.TabIndex = 0;
            listBoxGenres.SelectedIndexChanged += listBoxGenres_SelectedIndexChanged;
            // 
            // tabPageSearch
            // 
            tabPageSearch.Controls.Add(_dg);
            tabPageSearch.Controls.Add(panel1);
            tabPageSearch.Location = new Point(4, 29);
            tabPageSearch.Name = "tabPageSearch";
            tabPageSearch.Padding = new Padding(3);
            tabPageSearch.Size = new Size(792, 417);
            tabPageSearch.TabIndex = 2;
            tabPageSearch.Text = "Search";
            tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(comboBoxGenresSearch);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(numericUpDownSearchTo);
            panel1.Controls.Add(numericUpDownSearchFrom);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxBookSearchAuthors);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxBookSearchTitle);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 109);
            panel1.TabIndex = 0;
            // 
            // _dg
            // 
            _dg.AllowUserToAddRows = false;
            _dg.AllowUserToDeleteRows = false;
            _dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dg.Dock = DockStyle.Fill;
            _dg.Location = new Point(3, 112);
            _dg.Name = "_dg";
            _dg.ReadOnly = true;
            _dg.RowHeadersWidth = 51;
            _dg.Size = new Size(786, 302);
            _dg.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 24);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 0;
            label6.Text = "Title";
            // 
            // textBoxBookSearchTitle
            // 
            textBoxBookSearchTitle.Location = new Point(100, 22);
            textBoxBookSearchTitle.Name = "textBoxBookSearchTitle";
            textBoxBookSearchTitle.Size = new Size(125, 27);
            textBoxBookSearchTitle.TabIndex = 1;
            // 
            // textBoxBookSearchAuthors
            // 
            textBoxBookSearchAuthors.Location = new Point(100, 58);
            textBoxBookSearchAuthors.Name = "textBoxBookSearchAuthors";
            textBoxBookSearchAuthors.Size = new Size(125, 27);
            textBoxBookSearchAuthors.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 61);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 2;
            label7.Text = "Authors";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(247, 31);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 4;
            label8.Text = "Year from";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(420, 31);
            label9.Name = "label9";
            label9.Size = new Size(23, 20);
            label9.TabIndex = 5;
            label9.Text = "to";
            label9.Click += label9_Click;
            // 
            // numericUpDownSearchFrom
            // 
            numericUpDownSearchFrom.Location = new Point(326, 29);
            numericUpDownSearchFrom.Name = "numericUpDownSearchFrom";
            numericUpDownSearchFrom.Size = new Size(78, 27);
            numericUpDownSearchFrom.TabIndex = 6;
            // 
            // numericUpDownSearchTo
            // 
            numericUpDownSearchTo.Location = new Point(459, 29);
            numericUpDownSearchTo.Name = "numericUpDownSearchTo";
            numericUpDownSearchTo.Size = new Size(78, 27);
            numericUpDownSearchTo.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(247, 65);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 8;
            label10.Text = "Genre";
            // 
            // comboBoxGenresSearch
            // 
            comboBoxGenresSearch.FormattingEnabled = true;
            comboBoxGenresSearch.Location = new Point(326, 65);
            comboBoxGenresSearch.Name = "comboBoxGenresSearch";
            comboBoxGenresSearch.Size = new Size(211, 28);
            comboBoxGenresSearch.TabIndex = 9;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(562, 31);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 62);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "EK Library Manager";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageBooks.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            tabPageGenres.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageSearch.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSearchTo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBooks;
        private TabPage tabPageGenres;
        private ListBox listBoxGenres;
        private GroupBox groupBox1;
        private Button buttonGenreSave;
        private Button buttonGenreCancel;
        private TextBox textBoxGenreName;
        private Label label1;
        private Button buttonGenreDelete;
        private SplitContainer splitContainer1;
        private ListBox listBoxBooks;
        private Button buttonBookDelete;
        private GroupBox groupBox2;
        private CheckBox checkBoxMode;
        private Label label2;
        private NumericUpDown numericUpDownYear;
        private TextBox textBoxBookAuthors;
        private TextBox textBoxBookTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxGenres;
        private Button buttonBookSave;
        private Button buttonBookClear;
        private TabPage tabPageSearch;
        private DataGridView _dg;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private TextBox textBoxBookSearchAuthors;
        private Label label7;
        private TextBox textBoxBookSearchTitle;
        private Label label6;
        private Button buttonSearch;
        private ComboBox comboBoxGenresSearch;
        private Label label10;
        private NumericUpDown numericUpDownSearchTo;
        private NumericUpDown numericUpDownSearchFrom;
    }
}
