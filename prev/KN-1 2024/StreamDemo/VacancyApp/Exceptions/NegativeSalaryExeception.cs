using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyApp.Models;

namespace VacancyApp.Exceptions
{
    public class NegativeSalaryExeception : ApplicationException
    {
        private readonly Adv adv;
        public NegativeSalaryExeception(Adv adv)
        {
            this.adv = adv;
        }

        public Adv Adv => adv;
        public override string Message => $"Negative salary found. Check adv #{adv.Id}. Adv info: {adv}";

    }
}
