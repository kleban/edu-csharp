using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataReadWrite.Domain
{
    public class Publisher
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
    }
}
