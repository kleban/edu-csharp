

using StaticDemo;

Worker w1 = new Worker
{
    Name = "John Doe",
    Salary = 50000
};

w1.Salary += 5000; // Give a raise

Worker w2 = new Worker
{
    Name = "Jane Smith",
    Salary = 60000
};
w2.IncreaseCount(5);

Console.WriteLine(Worker.GetWorkerCount());

