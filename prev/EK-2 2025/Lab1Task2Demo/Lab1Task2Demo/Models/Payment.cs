using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab1Task2Demo.Models
{
    public class Payment
    {
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"[{PaymentDate.ToString("dd/MM/yyyy HH:mm")}] - ${Amount}, ({PaymentType})";
        }
    }
}
