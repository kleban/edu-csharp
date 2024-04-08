namespace OOPDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("John", 55, 2144.7);
            Console.WriteLine(w.GetInfo());
            w.Salary = 15;
            Console.WriteLine(w.Salary);
        }
    }
}
