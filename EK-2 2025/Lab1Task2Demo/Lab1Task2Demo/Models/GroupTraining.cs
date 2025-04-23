using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public class GroupTraining : Workout
    {
        public Member[] Participants { get; set; }
    }
}
