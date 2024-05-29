using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyApp.Models
{
    public class Adv
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Company}): ${Salary}";
        }
    }
}
