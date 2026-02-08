using StudentData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Exceptions
{
    public class GradeMoreThan100Exception : ApplicationException
    {
        private readonly Student _std;
        public GradeMoreThan100Exception(Student std)
        {
            _std = std;
        }

        public override string Message => $"Check user with id {_std.Id}: {_std}. Grade is {_std.AvgGrade}."; 
    }
}
