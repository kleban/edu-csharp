using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;

namespace ForbesRank.DataParser
{
    [CsvRecord]
    public partial record RankDataItem(int rank,
        string personName,
        int? age,
        double? finalWorth,
        string category,
        string country,
        DateTime? birthDate);
}
