using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilderPerfomance
{
    public class TableBuilder
    {
        public static ConsoleTable Create(TestResult[] results)
        {
            var table = new ConsoleTable("Iterations", "String, ms", "StringBuilder, ms", "Diff, ms", "TextLength");
            foreach (var r in results)
            {
                table.AddRow(r.Iterations, r.TimeMsString, r.TimeMsSb, r.TimeMsString - r.TimeMsSb, r.AppendTextLength);
            }
            return table;
        }
    }
}
