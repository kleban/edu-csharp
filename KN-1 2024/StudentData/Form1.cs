using StudentData.Exceptions;
using StudentData.Model;
using StudentData.Services;

namespace StudentData
{
    public partial class Form1 : Form
    {
        List<Student> _students = new();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void _updateListBox()
        {
            listBoxStd.Items.Clear();
            listBoxStd.Items.AddRange(_students.ToArray());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "KN files (*.kn) | *.kn";

            if (DialogResult.OK == open.ShowDialog())
            {
                var fileName = open.FileName;

                try
                {
                    _students = StdManagementService.Read(fileName);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(fe.Message);
                }
                catch (GradeMoreThan100Exception g100)
                {
                    MessageBox.Show(g100.Message);
                }
                catch
                {
                    MessageBox.Show("Unknown error!");
                }
                _updateListBox();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var r = new Random();

            _students.Add(new Student
            {
                Id = _students.Any() ? _students.Max(x => x.Id) + 1 : 1,
                Name = "Name_" + r.Next(10, 100),
                Group = "KN-1",
                AvgGrade = r.Next(100, 1000) / 10.0
            });

            _updateListBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.Filter = "KN files (*.kn) | *.kn";

            if (DialogResult.OK == save.ShowDialog())
            {
                var fileName = save.FileName;

                StdManagementService.Save(fileName, _students);
                MessageBox.Show("Saved!");
            }
        }
    }
}
