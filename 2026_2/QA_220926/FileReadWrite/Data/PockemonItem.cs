using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FileReadWrite.Data
{
    public class PockemonItem
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("name")]
        public string Name { get; set; }

        [Name("height_dm")]
        public double Height { get; set; }

        [Name("type_1")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }

    }
}
