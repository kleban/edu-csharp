namespace OOPDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Worker w1 = new SalesPerson("John", 55, 2144.7, 50);
            Worker w2 = new TopManager("John", 55, 2144.7, 10, 0.02);
            Worker w3 = new Manager("John", 55, 2144.7, 10);
            Worker w4 = new TopManager("John", 55, 2144.7, 10, 0.06);
            Worker w5 = new TopManager("John", 55, 2144.7, 10, 0.03);

            Worker[] workers = { w1, w2, w3, w4, w5 };

            double share_total = 0;

            foreach(Worker worker in workers)
            {
                // #1
                /*if (worker is TopManager)
                {
                    TopManager top = (TopManager)worker; 
                    share_total += top.GetMyShare();
                }*/             
                
                TopManager top = worker as TopManager; //null is crash
                if (top is not null)                
                    share_total += top.GetMyShare();

                Console.WriteLine(worker.GetInfo());
            }

        }
    }
}
