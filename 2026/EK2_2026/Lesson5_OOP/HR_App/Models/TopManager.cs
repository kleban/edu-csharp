using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class TopManager : Manager
    {
        private double companyShare;

        public TopManager(string name, 
            DateTime dob,
            double salary,
            int wcount,
            double share) : base(name, dob, salary, wcount)
        {
            companyShare = share;
        }

        public override string GetInfo()
        {
            string str = "Top-";
            str += base.GetInfo();
            str += $"Share: {companyShare*100}%.";
            return str;
        }
    }
}
