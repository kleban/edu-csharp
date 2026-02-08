using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class ExamTasksGenerator
    {
        private QuestionCounter[] qc;
        private Random rnd = new Random();

        public ExamTasksGenerator(string[] questions)
        {

            qc = new QuestionCounter[questions.Length];

            for (int i = 0; i < qc.Length; i++)
                qc[i] = new QuestionCounter(questions[i]);
        }

        public QuestionCounter[] QC
        {
            get { return qc; }
        }

        private string getRandomQuestion()
        {
            bool flag = true;
            string question = string.Empty;
            while (flag)
            {
                var index = rnd.Next(0, qc.Length);
                if (qc[index].Counter < 2)
                {
                    flag = false;
                    question = qc[index].Question;
                    qc[index].IncCount();
                }
            }

            return question;
        }

        public ExamTask[] GetTasks(int count)
        {
            var tasks = new ExamTask[count];

            for (int i = 0;i < tasks.Length;i++)
            {
                tasks[i] = new ExamTask(i + 1);
                for(int j = 0; j < 5; j++)
                {
                    tasks[i].SetQuestion(getRandomQuestion(), j);
                }
            }

            return tasks;
        }

        public static StudentTaskGrade[] SetTasksForStudents(ExamTask[] tasks, Student[] students)
        {
            var rnd = new Random();
            var results = new StudentTaskGrade[students.Length];

            for (int i = 0; i < results.Length; i++)
            {
                bool flag = true;
                ExamTask task = tasks[rnd.Next(0, tasks.Length)];
                while (flag)
                {
                    /*if (i == 0)
                    {
                        flag = false;
                        continue;
                    }*/

                    task = tasks[rnd.Next(0, tasks.Length)];

                    flag = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (results[j].Task.Variant == task.Variant)
                        {
                            flag = true;
                        }
                    }
                }

                results[i] = new StudentTaskGrade(students[i], task);
                results[i].Grade = rnd.Next(0, 101);
            }

            return results;
        } 
    }
}
