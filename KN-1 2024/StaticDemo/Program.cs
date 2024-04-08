namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            User u1 = new User();
            Console.WriteLine(u1.Info());
            User u2 = new User();

            User.Increase();

            Console.WriteLine(u1.Info());
        }
    }
}
