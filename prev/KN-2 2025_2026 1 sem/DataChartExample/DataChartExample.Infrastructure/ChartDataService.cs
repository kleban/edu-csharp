using DataChartExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataChartExample.Infrastructure
{
    public class ChartDataService
    {
        public static List<KeyValuePair<DateTime, double>> GetSales(List<CoffeDataItem> items)
        {
            return items
                .GroupBy(i => i.Date)
                .Select(g => new KeyValuePair<DateTime, double>(g.Key, g.Sum(i => i.Money)))
                .OrderBy(kv => kv.Key)
                .ToList();
        }

        public static List<KeyValuePair<string, double>> GetByCoffe(List<CoffeDataItem> items)
        {
            return items
                .GroupBy(i => i.CoffeeName)
                .Select(g => new KeyValuePair<string, double>(g.Key, g.Sum(i => i.Money)))
                .OrderBy(kv => kv.Key)
                .ToList();
        }
    }
}
