using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Domain.DTO
{
    public record ForbsDataItem(int rank,
       string personName,
       int? age,
       double? finalWorth,
       string category,
       string country);
}
