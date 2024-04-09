namespace OOPDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new SalesPerson("John", 55, 2144.7, 15.5);
            Worker w2 = new Manager("John", 55, 2144.7, 100);
            Worker w3 = new TopManager("John", 55, 2144.7, 100, 0.02);
            Worker w4 = new TopManager("John", 55, 2144.7, 100, 0.03);

            Worker[] workers = { w1, w2, w3, w4 };
            var share_sum = 0.0;
            foreach (Worker worker in workers)
            {
                // 1
                if (worker is TopManager)
                {
                    TopManager topManager = worker as TopManager;
                    share_sum += topManager.GetMyShare();
                }
                // 2
                /*TopManager topManager = worker as TopManager;
                if (topManager != null)
                {
                    share_sum += topManager.GetMyShare();
                }*/

                Console.WriteLine(worker.GetInfo());
            }

            Console.WriteLine(share_sum);


        }
    }
}
