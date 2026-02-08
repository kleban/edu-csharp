using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class QuestionCounter
    {
        private string question;
        private int counter;

        public QuestionCounter(string question)
        {
            this.question = question;
            counter = 0;
        }

        public void IncCount()
        {
            counter++;
        }

        public int Counter { get { return counter; } }
        public string Question { get { return question; } }

        public override string ToString()
        {
            return $"{question}: {counter}";
        }
    }
}
