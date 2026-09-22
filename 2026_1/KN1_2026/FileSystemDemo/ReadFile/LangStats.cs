using System;
using System.Collections.Generic;
using System.Text;

namespace ReadFile
{
    public class LangStats
    {
        public string Language { get; set; }
        public int Count { get; set; }
        public double Percent { get; set; }

        public string CsvLine
        {
            get { return $"{Language};{Count};{Percent}"; }
        }

        public override string ToString()
        {
            return $"{Language}: {Count} ({Percent:0.00}%)";
        }
    }
}
