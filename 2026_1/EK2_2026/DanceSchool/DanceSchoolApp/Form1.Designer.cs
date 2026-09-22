namespace DanceSchoolApp
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
            tabControl1 = new TabControl();
            tabPageStudents = new TabPage();
            buttonAddStudent = new Button();
            numericUpDownStudentAge = new NumericUpDown();
            textBoxStudentName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonRemoveStudent = new Button();
            listBoxStudents = new ListBox();
            tabPageTeachers = new TabPage();
            listBoxTeachers = new ListBox();
            tabPageGroups = new TabPage();
            buttonAddStdToGroup = new Button();
            checkedListBoxStudents = new CheckedListBox();
            comboBoxTeachers = new ComboBox();
            textBoxGroupName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBoxGroups = new ListBox();
            tabPageLessons = new TabPage();
            buttonAddLesson = new Button();
            comboBoxGroups = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            listBoxLessons = new ListBox();
            tabControl1.SuspendLayout();
            tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentAge).BeginInit();
            panel1.SuspendLayout();
            tabPageTeachers.SuspendLayout();
            tabPageGroups.SuspendLayout();
            tabPageLessons.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageStudents);
            tabControl1.Controls.Add(tabPageTeachers);
            tabControl1.Controls.Add(tabPageGroups);
            tabControl1.Controls.Add(tabPageLessons);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(528, 341);
            tabControl1.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            tabPageStudents.Controls.Add(buttonAddStudent);
            tabPageStudents.Controls.Add(numericUpDownStudentAge);
            tabPageStudents.Controls.Add(textBoxStudentName);
            tabPageStudents.Controls.Add(label2);
            tabPageStudents.Controls.Add(label1);
            tabPageStudents.Controls.Add(panel1);
            tabPageStudents.Location = new Point(4, 24);
            tabPageStudents.Name = "tabPageStudents";
            tabPageStudents.Padding = new Padding(3);
            tabPageStudents.Size = new Size(520, 313);
            tabPageStudents.TabIndex = 0;
            tabPageStudents.Text = "Учні школи";
            tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(219, 125);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(100, 23);
            buttonAddStudent.TabIndex = 7;
            buttonAddStudent.Text = "Додати";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // numericUpDownStudentAge
            // 
            numericUpDownStudentAge.Location = new Point(219, 85);
            numericUpDownStudentAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDownStudentAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownStudentAge.Name = "numericUpDownStudentAge";
            numericUpDownStudentAge.Size = new Size(100, 23);
            numericUpDownStudentAge.TabIndex = 6;
            numericUpDownStudentAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Location = new Point(219, 41);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(100, 23);
            textBoxStudentName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 67);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "Вік";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 17);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Ім'я";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(buttonRemoveStudent);
            panel1.Controls.Add(listBoxStudents);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 307);
            panel1.TabIndex = 2;
            // 
            // buttonRemoveStudent
            // 
            buttonRemoveStudent.Dock = DockStyle.Bottom;
            buttonRemoveStudent.Enabled = false;
            buttonRemoveStudent.Location = new Point(0, 284);
            buttonRemoveStudent.Name = "buttonRemoveStudent";
            buttonRemoveStudent.Size = new Size(200, 23);
            buttonRemoveStudent.TabIndex = 1;
            buttonRemoveStudent.Text = "Видалити учня/ученицю";
            buttonRemoveStudent.UseVisualStyleBackColor = true;
            buttonRemoveStudent.Click += buttonRemoveStudent_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.Dock = DockStyle.Fill;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(0, 0);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(200, 307);
            listBoxStudents.TabIndex = 0;
            listBoxStudents.SelectedIndexChanged += listBoxStudents_SelectedIndexChanged;
            // 
            // tabPageTeachers
            // 
            tabPageTeachers.Controls.Add(listBoxTeachers);
            tabPageTeachers.Location = new Point(4, 24);
            tabPageTeachers.Name = "tabPageTeachers";
            tabPageTeachers.Padding = new Padding(3);
            tabPageTeachers.Size = new Size(520, 313);
            tabPageTeachers.TabIndex = 1;
            tabPageTeachers.Text = "Вчителі школи";
            tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // listBoxTeachers
            // 
            listBoxTeachers.Dock = DockStyle.Left;
            listBoxTeachers.FormattingEnabled = true;
            listBoxTeachers.Location = new Point(3, 3);
            listBoxTeachers.Name = "listBoxTeachers";
            listBoxTeachers.Size = new Size(195, 307);
            listBoxTeachers.TabIndex = 1;
            // 
            // tabPageGroups
            // 
            tabPageGroups.Controls.Add(buttonAddStdToGroup);
            tabPageGroups.Controls.Add(checkedListBoxStudents);
            tabPageGroups.Controls.Add(comboBoxTeachers);
            tabPageGroups.Controls.Add(textBoxGroupName);
            tabPageGroups.Controls.Add(label5);
            tabPageGroups.Controls.Add(label4);
            tabPageGroups.Controls.Add(label3);
            tabPageGroups.Controls.Add(listBoxGroups);
            tabPageGroups.Location = new Point(4, 24);
            tabPageGroups.Name = "tabPageGroups";
            tabPageGroups.Padding = new Padding(3);
            tabPageGroups.Size = new Size(520, 313);
            tabPageGroups.TabIndex = 2;
            tabPageGroups.Text = "Групи";
            tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // buttonAddStdToGroup
            // 
            buttonAddStdToGroup.Location = new Point(242, 282);
            buttonAddStdToGroup.Name = "buttonAddStdToGroup";
            buttonAddStdToGroup.Size = new Size(136, 23);
            buttonAddStdToGroup.TabIndex = 9;
            buttonAddStdToGroup.Text = "Додати";
            buttonAddStdToGroup.UseVisualStyleBackColor = true;
            buttonAddStdToGroup.Click += buttonAddStdToGroup_Click;
            // 
            // checkedListBoxStudents
            // 
            checkedListBoxStudents.FormattingEnabled = true;
            checkedListBoxStudents.Location = new Point(243, 140);
            checkedListBoxStudents.Name = "checkedListBoxStudents";
            checkedListBoxStudents.Size = new Size(135, 130);
            checkedListBoxStudents.TabIndex = 8;
            // 
            // comboBoxTeachers
            // 
            comboBoxTeachers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeachers.FormattingEnabled = true;
            comboBoxTeachers.Location = new Point(243, 85);
            comboBoxTeachers.Name = "comboBoxTeachers";
            comboBoxTeachers.Size = new Size(135, 23);
            comboBoxTeachers.TabIndex = 7;
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Location = new Point(243, 33);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(135, 23);
            textBoxGroupName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 113);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Учні";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 62);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Вчитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Назва";
            // 
            // listBoxGroups
            // 
            listBoxGroups.Dock = DockStyle.Left;
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.Location = new Point(3, 3);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(222, 307);
            listBoxGroups.TabIndex = 2;
            // 
            // tabPageLessons
            // 
            tabPageLessons.Controls.Add(buttonAddLesson);
            tabPageLessons.Controls.Add(comboBoxGroups);
            tabPageLessons.Controls.Add(dateTimePickerEnd);
            tabPageLessons.Controls.Add(dateTimePickerStart);
            tabPageLessons.Controls.Add(label8);
            tabPageLessons.Controls.Add(label7);
            tabPageLessons.Controls.Add(label6);
            tabPageLessons.Controls.Add(listBoxLessons);
            tabPageLessons.Location = new Point(4, 24);
            tabPageLessons.Name = "tabPageLessons";
            tabPageLessons.Padding = new Padding(3);
            tabPageLessons.Size = new Size(520, 313);
            tabPageLessons.TabIndex = 3;
            tabPageLessons.Text = "Заняття";
            tabPageLessons.UseVisualStyleBackColor = true;
            // 
            // buttonAddLesson
            // 
            buttonAddLesson.Location = new Point(243, 151);
            buttonAddLesson.Name = "buttonAddLesson";
            buttonAddLesson.Size = new Size(134, 23);
            buttonAddLesson.TabIndex = 10;
            buttonAddLesson.Text = "Додати заняття";
            buttonAddLesson.UseVisualStyleBackColor = true;
            buttonAddLesson.Click += buttonAddLesson_Click;
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(243, 122);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(134, 23);
            comboBoxGroups.TabIndex = 9;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(243, 79);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(134, 23);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(243, 35);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(134, 23);
            dateTimePickerStart.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 104);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 6;
            label8.Text = "Група";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 61);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 5;
            label7.Text = "Час завершення";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 16);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 4;
            label6.Text = "Час початку";
            // 
            // listBoxLessons
            // 
            listBoxLessons.Dock = DockStyle.Left;
            listBoxLessons.FormattingEnabled = true;
            listBoxLessons.Location = new Point(3, 3);
            listBoxLessons.Name = "listBoxLessons";
            listBoxLessons.Size = new Size(222, 307);
            listBoxLessons.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 341);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Школа танців";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageStudents.ResumeLayout(false);
            tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentAge).EndInit();
            panel1.ResumeLayout(false);
            tabPageTeachers.ResumeLayout(false);
            tabPageGroups.ResumeLayout(false);
            tabPageGroups.PerformLayout();
            tabPageLessons.ResumeLayout(false);
            tabPageLessons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageStudents;
        private TabPage tabPageTeachers;
        private ListBox listBoxStudents;
        private ListBox listBoxTeachers;
        private Panel panel1;
        private Button buttonRemoveStudent;
        private TextBox textBoxStudentName;
        private Label label2;
        private Label label1;
        private Button buttonAddStudent;
        private NumericUpDown numericUpDownStudentAge;
        private TabPage tabPageGroups;
        private ListBox listBoxGroups;
        private TextBox textBoxGroupName;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxTeachers;
        private Button buttonAddStdToGroup;
        private CheckedListBox checkedListBoxStudents;
        private TabPage tabPageLessons;
        private ListBox listBoxLessons;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePickerStart;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonAddLesson;
        private ComboBox comboBoxGroups;
    }
}
