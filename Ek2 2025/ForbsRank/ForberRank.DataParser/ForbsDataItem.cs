using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForberRank.DataParser
{
    public record ForbsDataItem(int rank,
       string personName,
       int? age,
       double? finalWorth,
       string category,
       string country);
}
