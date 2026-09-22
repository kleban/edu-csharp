using StdPerfomance.Core;
using StdPerfomance.Core.Entities;
using StdPerfomance.Repos;

namespace DatabaseDemo_Std
{
    public partial class Form1 : Form
    {
        private ScoresRepository scores;
        private LevelsRepository levels;
        public Form1()
        {
            InitializeComponent();
            var ctx = new DataContext();
            scores = new ScoresRepository(ctx);
            levels = new LevelsRepository(ctx);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var r = new Random();

            var score = new StudentScore
            {
                Name = $"Student {r.Next(1000, 10000)}",
                ExamScore = r.Next(0, 101),
                SleepHours = r.Next(0, 13),
                SocialMediaHours = r.Next(0, 13),
                StudyHours = r.Next(0, 13),
                StressLevel = levels.GetAll().OrderBy(x => Guid.NewGuid()).FirstOrDefault()
            };

            scores.Add(score);
            updateList();
        }

        private void updateList()
        {
            listBoxScores.Items.Clear();
            listBoxScores.Items.AddRange(scores.GetAll().ToArray());
        }
    }
}
