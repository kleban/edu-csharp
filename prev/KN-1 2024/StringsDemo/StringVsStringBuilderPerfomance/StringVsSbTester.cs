using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilderPerfomance
{
    public class StringVsSbTester
    {
        private string str;
        private StringBuilder sb;

        public TestResult Test(int iterations, string textToAppend)
        {
            str = string.Empty;
            sb = new StringBuilder();

            return new TestResult
            {
                Iterations = iterations,
                AppendTextLength = textToAppend.Length,
                TimeMsString = testString(iterations, textToAppend),
                TimeMsSb = testSb(iterations, textToAppend)
            };
        }

        private int testSb(int iterations, string textToAppend)
        {
            var start = DateTime.Now;
            sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
                sb.Append(textToAppend);

            return (int)(DateTime.Now - start).TotalMilliseconds;
        }

        private int testString(int iterations, string textToAppend)
        {
            var start = DateTime.Now;
            str = string.Empty;

            for(int i = 0; i < iterations; i++)
                str += textToAppend;

            return (int)(DateTime.Now - start).TotalMilliseconds;
        }
    }

}
