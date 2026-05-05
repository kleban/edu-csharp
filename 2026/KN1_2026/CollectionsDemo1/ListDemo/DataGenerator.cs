using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class DataGenerator
    {
        public static List<Order> GenerateOrders()
        {
            var orders = new List<Order>
            {
                new Order { ClientName = "Олена Коваль",      OrderDate = new DateTime(2025, 1, 5),  TotalPrice = 1250.00, IsComplete = true  },
                new Order { ClientName = "Микола Бондаренко", OrderDate = new DateTime(2025, 1, 18), TotalPrice = 430.50,  IsComplete = true  },
                new Order { ClientName = "Ірина Савченко",    OrderDate = new DateTime(2025, 2, 3),  TotalPrice = 3100.00, IsComplete = false },
                new Order { ClientName = "Андрій Мельник",    OrderDate = new DateTime(2025, 2, 22), TotalPrice = 780.75,  IsComplete = true  },
                new Order { ClientName = "Тетяна Харченко",   OrderDate = new DateTime(2025, 3, 10), TotalPrice = 2200.00, IsComplete = false },
                new Order { ClientName = "Василь Кравченко",  OrderDate = new DateTime(2025, 3, 28), TotalPrice = 560.00,  IsComplete = true  },
                new Order { ClientName = "Наталія Поліщук",   OrderDate = new DateTime(2025, 4, 7),  TotalPrice = 4750.50, IsComplete = false },
                new Order { ClientName = "Дмитро Литвин",     OrderDate = new DateTime(2025, 4, 15), TotalPrice = 310.25,  IsComplete = true  },
                new Order { ClientName = "Світлана Гриценко", OrderDate = new DateTime(2025, 5, 1),  TotalPrice = 1890.00, IsComplete = false },
                new Order { ClientName = "Олексій Романенко", OrderDate = new DateTime(2025, 5, 20), TotalPrice = 675.00,  IsComplete = true  },
            };
            return orders;
        }
    }
}
