using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo.Model
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Price:0.00} UAH";
        }
    }
}
