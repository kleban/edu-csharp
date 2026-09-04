using DanceSchoolApp.Models;
using DanceSchoolApp.Services;

namespace DanceSchoolApp
{
    public partial class Form1 : Form
    {
        private DataManager _dm = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateStudentsList();
            updateTeachersList();
            updateGroupsList();
            updateLessonsList();
        }

        void updateLessonsList()
        {
            listBoxLessons.Items.Clear();
            listBoxLessons.Items.AddRange(_dm.GetLessons().ToArray());
        }

        void updateStudentsList()
        {
            var array = _dm.GetStudents().ToArray();

            listBoxStudents.Items.Clear();
            listBoxStudents.Items.AddRange(array);

            checkedListBoxStudents.Items.Clear();
            checkedListBoxStudents.Items.AddRange(array);
        }

        void updateGroupsList()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.Items.AddRange(_dm.GetGroups().ToArray());

            comboBoxGroups.Items.Clear();
            comboBoxGroups.Items.AddRange(_dm.GetGroups().ToArray());
            comboBoxGroups.SelectedIndex = 0;
        }

        void updateTeachersList()
        {
            var array = _dm.GetTeachers().ToArray();
            listBoxTeachers.Items.Clear();
            listBoxTeachers.Items.AddRange(array);
            comboBoxTeachers.Items.Clear();
            comboBoxTeachers.Items.AddRange(array);
            comboBoxTeachers.SelectedIndex = 0;


        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedIndex != -1)
            {
                buttonRemoveStudent.Enabled = true;
            }
            else
            {
                buttonRemoveStudent.Enabled = false;
            }
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            var selectedStudent = listBoxStudents.SelectedItem as Student;
            if (selectedStudent != null)
            {
                _dm.RemoveStudent(selectedStudent.Id);
                updateStudentsList();
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStudentName.Text))
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }

            var std = new Student
            {
                Age = (int)numericUpDownStudentAge.Value,
                Name = textBoxStudentName.Text,
            };

            _dm.AddStudent(std);
            updateStudentsList();
        }

        private void buttonAddStdToGroup_Click(object sender, EventArgs e)
        {
            var group = new Group
            {
                Name = textBoxGroupName.Text,
                Teacher = comboBoxTeachers.SelectedItem as Teacher,
                Students = new()
            };

            foreach (var c in checkedListBoxStudents.CheckedItems)
            {
                var std = c as Student;
                group.Students.Add(std);
            }

            _dm.AddGroup(group);
            updateGroupsList();
        }

        private void buttonAddLesson_Click(object sender, EventArgs e)
        {
            var lesson = new Lesson
            {
                StartTime = dateTimePickerStart.Value,
                EndTime = dateTimePickerEnd.Value,
                Group = comboBoxGroups.SelectedItem as Group
            };
            _dm.AddLesson(lesson);
            updateLessonsList();
        }
    }
}
