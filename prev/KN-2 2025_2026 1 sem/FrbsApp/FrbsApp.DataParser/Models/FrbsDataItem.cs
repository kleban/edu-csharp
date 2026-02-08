using System;
using System.Collections.Generic;
using System.Text;

namespace FrbsApp.DataParser.Models
{
    public record FrbsDataItem(int rank,
      string personName,
      int? age,
      double? finalWorth,
      string category,
      string country,
      string city,
      DateTime? birthDate);
}
