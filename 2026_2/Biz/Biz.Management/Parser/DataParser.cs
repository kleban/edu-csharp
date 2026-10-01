using Biz.Data.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Biz.Management.Parser
{
    public class DataParser
    {
        public static (List<Business>, List<BusinessType>) ParseData(string path)
        {
            var list = new List<BusinessData>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                list = csv.GetRecords<BusinessData>().ToList();
            }

            var types = list.Select(x => x.BusinessType).Distinct()
                .Select(x => new BusinessType { Name = x }).ToList();

            var biz = list.Select(x => new Business
            {
                Age = x.Age,
                AnnualRevenue = x.AnnualRevenue,
                CustomerRating = x.CustomerRating,
                Type = types.First(d => x.BusinessType == d.Name)
            }).ToList();

            return (biz, types);
        }
    }
}
