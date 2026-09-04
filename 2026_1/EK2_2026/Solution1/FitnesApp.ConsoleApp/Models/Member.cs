using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesApp.ConsoleApp.Models
{
    public class Member : Person
    {
        private Membership membership;

        public Member(string name, int age, Membership membership) 
            : base(name, age)
        {
            this.membership = membership;
        }
    }
}
