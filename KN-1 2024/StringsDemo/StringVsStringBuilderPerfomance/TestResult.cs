using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilderPerfomance
{
    public class TestResult
    {
        public int TimeMsString { get; set; }
        public int TimeMsSb { get; set; }
        public int Iterations { get; set; }
        public int AppendTextLength { get; set; }
    }
}
