using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.ConsoleApp.Model
{
    public class ForbsDataItem
    {
        public int rank { get; set; }
        public string personName { get; set; }
        public int? age { get; set; }
        public decimal finalWorth { get; set; }
        public string category { get; set; }
        public string? country { get; set; }
        public string? city { get; set; }
        public DateTime? birthDate { get; set; }
    }
}
