using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class ExamTask
    {
        private int variant;
        private string[] questions;

        public ExamTask(int variant, int qs_count = 5)
        {
            this.variant = variant;
            questions = new string[qs_count];
        }

        public int Variant { get { return variant; } }

        public void SetQuestion(string question, int index)
        {
            questions[index] = question;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"\n\nВаріант №{variant}");
            for (int i = 0; i < questions.Length; i++)
                str.AppendLine($"{i + 1}. {questions[i]}");

            return str.ToString();
        }

    }
}
