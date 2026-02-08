using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class Student
    {
        private readonly int _id;
        private string name;

        public Student(int _id, string name)
        {
            this._id = _id;
            this.name = name;
        }
        public int Id { get { return _id; } }
        public string Name { get { return name; } }

        public override string ToString()
        {
            return $"{_id}: {name}";
        }
    }
}
