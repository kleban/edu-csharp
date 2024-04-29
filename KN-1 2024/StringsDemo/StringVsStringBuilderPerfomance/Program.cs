using ConsoleTables;
using StringVsStringBuilderPerfomance;

Console.WriteLine("Iterations test\n");

StringVsSbTester tester = new StringVsSbTester();

TestResult[] results = { 
    tester.Test(1000, "text"), 
    tester.Test(10000, "text"), 
    tester.Test(100000, "text")};

Console.WriteLine(TableBuilder.Create(results));


Console.WriteLine("Text length test\n");

results = new TestResult[] {
    tester.Test(100000, "text"), 
    tester.Test(100000, "text 1111 1111"), 
    tester.Test(100000, "text 1111 1111 text 1111 1111") };

Console.WriteLine(TableBuilder.Create(results));
