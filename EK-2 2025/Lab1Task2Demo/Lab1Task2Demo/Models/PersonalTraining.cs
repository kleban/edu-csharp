using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public class PersonalTraining : Workout
    {
       public Member Member { get; set; }
    }
}
