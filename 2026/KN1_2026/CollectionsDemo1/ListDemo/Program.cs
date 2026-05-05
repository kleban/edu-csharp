using ListDemo;
using System.Collections.Generic;

var list2 = new List<string>();
list2.Sort();


var orders = DataGenerator.GenerateOrders();

//orders.RemoveAll(order => order.IsComplete);

//var selected = orders.Select(x => x.ClientName + (x.IsComplete? "+": "-")).ToList();
//selected.ForEach(Console.WriteLine);

//orders.Where(x => x.IsComplete && x.TotalPrice > 100 && x.OrderDate > new DateTime(2025,3,4)).ToList();

//var order = orders.First(x=> x.ClientName == "Олена Коваль1");

var order = orders.FirstOrDefault(x => x.ClientName == "Олена Коваль1");

if(order is not null)
    Console.WriteLine(order.ClientName);

//orders.FirstOrDefault();


//orders.OrderByDescending(x => x.OrderDate);


