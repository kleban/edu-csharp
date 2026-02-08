using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public class Membership
    {
        public Membership()
        {
            Payments = new Payment[0];
        }
        public string MembershipNumber { get; set; }
        public string Name { get; set; }
        public Payment[] Payments { get; set; }

        public void AddPayment(Payment payment)
        {
            List<Payment> payments = new List<Payment>(Payments);
            payments.Add(payment);
            Payments = payments.ToArray();
        }
    }
}
