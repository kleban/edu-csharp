namespace CinemaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPageFilms = new TabPage();
            buttonRemoveMovie = new Button();
            groupBox1 = new GroupBox();
            buttonMovieSave = new Button();
            buttonMovieClean = new Button();
            numericMovieDuration = new NumericUpDown();
            comboBoxMovieGenre = new ComboBox();
            comboBoxMovieAgeRating = new ComboBox();
            textBoxMovieTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxMovies = new ListBox();
            tabPageSessions = new TabPage();
            groupBox2 = new GroupBox();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndTime = new DateTimePicker();
            dateTimePickerStartTime = new DateTimePicker();
            comboBoxSessionMovie = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            comboBoxHall = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBoxSessions = new ListBox();
            tabPageGeneral = new TabPage();
            splitContainer1 = new SplitContainer();
            listBoxAgeRatings = new ListBox();
            listBoxGenres = new ListBox();
            checkBoxMovieInEditMode = new CheckBox();
            tabControl1.SuspendLayout();
            tabPageFilms.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMovieDuration).BeginInit();
            tabPageSessions.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFilms);
            tabControl1.Controls.Add(tabPageSessions);
            tabControl1.Controls.Add(tabPageGeneral);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageFilms
            // 
            tabPageFilms.Controls.Add(checkBoxMovieInEditMode);
            tabPageFilms.Controls.Add(buttonRemoveMovie);
            tabPageFilms.Controls.Add(groupBox1);
            tabPageFilms.Controls.Add(listBoxMovies);
            tabPageFilms.Location = new Point(4, 29);
            tabPageFilms.Name = "tabPageFilms";
            tabPageFilms.Padding = new Padding(3);
            tabPageFilms.Size = new Size(792, 417);
            tabPageFilms.TabIndex = 0;
            tabPageFilms.Text = "Films";
            tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveMovie
            // 
            buttonRemoveMovie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveMovie.Enabled = false;
            buttonRemoveMovie.Location = new Point(311, 353);
            buttonRemoveMovie.Name = "buttonRemoveMovie";
            buttonRemoveMovie.Size = new Size(117, 56);
            buttonRemoveMovie.TabIndex = 2;
            buttonRemoveMovie.Text = "Remove";
            buttonRemoveMovie.UseVisualStyleBackColor = true;
            buttonRemoveMovie.Click += buttonRemoveMovie_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonMovieSave);
            groupBox1.Controls.Add(buttonMovieClean);
            groupBox1.Controls.Add(numericMovieDuration);
            groupBox1.Controls.Add(comboBoxMovieGenre);
            groupBox1.Controls.Add(comboBoxMovieAgeRating);
            groupBox1.Controls.Add(textBoxMovieTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(311, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 236);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add / Edit Movie";
            // 
            // buttonMovieSave
            // 
            buttonMovieSave.Location = new Point(239, 179);
            buttonMovieSave.Name = "buttonMovieSave";
            buttonMovieSave.Size = new Size(187, 29);
            buttonMovieSave.TabIndex = 9;
            buttonMovieSave.Text = "Save";
            buttonMovieSave.UseVisualStyleBackColor = true;
            buttonMovieSave.Click += buttonMovieSave_Click;
            // 
            // buttonMovieClean
            // 
            buttonMovieClean.Location = new Point(21, 179);
            buttonMovieClean.Name = "buttonMovieClean";
            buttonMovieClean.Size = new Size(187, 29);
            buttonMovieClean.TabIndex = 8;
            buttonMovieClean.Text = "Clean";
            buttonMovieClean.UseVisualStyleBackColor = true;
            buttonMovieClean.Click += buttonMovieClean_Click;
            // 
            // numericMovieDuration
            // 
            numericMovieDuration.Location = new Point(239, 134);
            numericMovieDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericMovieDuration.Name = "numericMovieDuration";
            numericMovieDuration.Size = new Size(187, 27);
            numericMovieDuration.TabIndex = 7;
            // 
            // comboBoxMovieGenre
            // 
            comboBoxMovieGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovieGenre.FormattingEnabled = true;
            comboBoxMovieGenre.Location = new Point(21, 133);
            comboBoxMovieGenre.Name = "comboBoxMovieGenre";
            comboBoxMovieGenre.Size = new Size(187, 28);
            comboBoxMovieGenre.TabIndex = 6;
            // 
            // comboBoxMovieAgeRating
            // 
            comboBoxMovieAgeRating.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovieAgeRating.FormattingEnabled = true;
            comboBoxMovieAgeRating.Location = new Point(239, 72);
            comboBoxMovieAgeRating.Name = "comboBoxMovieAgeRating";
            comboBoxMovieAgeRating.Size = new Size(187, 28);
            comboBoxMovieAgeRating.TabIndex = 5;
            // 
            // textBoxMovieTitle
            // 
            textBoxMovieTitle.Location = new Point(20, 72);
            textBoxMovieTitle.Name = "textBoxMovieTitle";
            textBoxMovieTitle.Size = new Size(188, 27);
            textBoxMovieTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 110);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Duration, min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 44);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Age Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // listBoxMovies
            // 
            listBoxMovies.Dock = DockStyle.Left;
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.Location = new Point(3, 3);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(290, 411);
            listBoxMovies.TabIndex = 0;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // tabPageSessions
            // 
            tabPageSessions.Controls.Add(groupBox2);
            tabPageSessions.Controls.Add(listBoxSessions);
            tabPageSessions.Location = new Point(4, 29);
            tabPageSessions.Name = "tabPageSessions";
            tabPageSessions.Padding = new Padding(3);
            tabPageSessions.Size = new Size(792, 417);
            tabPageSessions.TabIndex = 1;
            tabPageSessions.Text = "Sessions";
            tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dateTimePickerStartDate);
            groupBox2.Controls.Add(dateTimePickerEndTime);
            groupBox2.Controls.Add(dateTimePickerStartTime);
            groupBox2.Controls.Add(comboBoxSessionMovie);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBoxHall);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(313, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 270);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add / Edit Session";
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(25, 173);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(183, 27);
            dateTimePickerStartDate.TabIndex = 13;
            dateTimePickerStartDate.ValueChanged += changeEndTime;
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.Enabled = false;
            dateTimePickerEndTime.Format = DateTimePickerFormat.Time;
            dateTimePickerEndTime.Location = new Point(239, 140);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.ShowUpDown = true;
            dateTimePickerEndTime.Size = new Size(183, 27);
            dateTimePickerEndTime.TabIndex = 12;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.Format = DateTimePickerFormat.Time;
            dateTimePickerStartTime.Location = new Point(25, 140);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.ShowUpDown = true;
            dateTimePickerStartTime.Size = new Size(183, 27);
            dateTimePickerStartTime.TabIndex = 11;
            dateTimePickerStartTime.ValueChanged += changeEndTime;
            // 
            // comboBoxSessionMovie
            // 
            comboBoxSessionMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSessionMovie.FormattingEnabled = true;
            comboBoxSessionMovie.Location = new Point(20, 72);
            comboBoxSessionMovie.Name = "comboBoxSessionMovie";
            comboBoxSessionMovie.Size = new Size(187, 28);
            comboBoxSessionMovie.TabIndex = 10;
            comboBoxSessionMovie.SelectedIndexChanged += changeEndTime;
            // 
            // button1
            // 
            button1.Location = new Point(239, 219);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(25, 219);
            button2.Name = "button2";
            button2.Size = new Size(187, 29);
            button2.TabIndex = 8;
            button2.Text = "Clean";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxHall
            // 
            comboBoxHall.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHall.FormattingEnabled = true;
            comboBoxHall.Location = new Point(239, 72);
            comboBoxHall.Name = "comboBoxHall";
            comboBoxHall.Size = new Size(187, 28);
            comboBoxHall.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 110);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 3;
            label5.Text = "End Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 110);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 2;
            label6.Text = "Start Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 44);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 1;
            label7.Text = "Hall";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 44);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 0;
            label8.Text = "Movie";
            // 
            // listBoxSessions
            // 
            listBoxSessions.Dock = DockStyle.Left;
            listBoxSessions.FormattingEnabled = true;
            listBoxSessions.Location = new Point(3, 3);
            listBoxSessions.Name = "listBoxSessions";
            listBoxSessions.Size = new Size(290, 411);
            listBoxSessions.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            tabPageGeneral.Controls.Add(splitContainer1);
            tabPageGeneral.Location = new Point(4, 29);
            tabPageGeneral.Name = "tabPageGeneral";
            tabPageGeneral.Padding = new Padding(3);
            tabPageGeneral.Size = new Size(792, 417);
            tabPageGeneral.TabIndex = 2;
            tabPageGeneral.Text = "General Info";
            tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBoxAgeRatings);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBoxGenres);
            splitContainer1.Size = new Size(786, 411);
            splitContainer1.SplitterDistance = 262;
            splitContainer1.TabIndex = 0;
            // 
            // listBoxAgeRatings
            // 
            listBoxAgeRatings.Dock = DockStyle.Fill;
            listBoxAgeRatings.FormattingEnabled = true;
            listBoxAgeRatings.Location = new Point(0, 0);
            listBoxAgeRatings.Name = "listBoxAgeRatings";
            listBoxAgeRatings.Size = new Size(262, 411);
            listBoxAgeRatings.TabIndex = 0;
            // 
            // listBoxGenres
            // 
            listBoxGenres.Dock = DockStyle.Left;
            listBoxGenres.FormattingEnabled = true;
            listBoxGenres.Location = new Point(0, 0);
            listBoxGenres.Name = "listBoxGenres";
            listBoxGenres.Size = new Size(251, 411);
            listBoxGenres.TabIndex = 0;
            // 
            // checkBoxMovieInEditMode
            // 
            checkBoxMovieInEditMode.AutoSize = true;
            checkBoxMovieInEditMode.Enabled = false;
            checkBoxMovieInEditMode.Location = new Point(311, 260);
            checkBoxMovieInEditMode.Name = "checkBoxMovieInEditMode";
            checkBoxMovieInEditMode.Size = new Size(116, 24);
            checkBoxMovieInEditMode.TabIndex = 10;
            checkBoxMovieInEditMode.Text = "In Edit Mode";
            checkBoxMovieInEditMode.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageFilms.ResumeLayout(false);
            tabPageFilms.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMovieDuration).EndInit();
            tabPageSessions.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPageGeneral.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageFilms;
        private TabPage tabPageSessions;
        private TabPage tabPageGeneral;
        private SplitContainer splitContainer1;
        private ListBox listBoxAgeRatings;
        private ListBox listBoxGenres;
        private ListBox listBoxMovies;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button buttonMovieSave;
        private Button buttonMovieClean;
        private NumericUpDown numericMovieDuration;
        private ComboBox comboBoxMovieGenre;
        private ComboBox comboBoxMovieAgeRating;
        private TextBox textBoxMovieTitle;
        private Label label4;
        private ListBox listBoxSessions;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerStartTime;
        private ComboBox comboBoxSessionMovie;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxHall;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndTime;
        private Button buttonRemoveMovie;
        private CheckBox checkBoxMovieInEditMode;
    }
}
