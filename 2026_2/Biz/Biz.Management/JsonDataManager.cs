using Biz.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Biz.Management
{
    public class JsonDataManager : IDataManager
    {
        public List<Business> Read(string path)
        {
            string json = File.OpenText(path).ReadToEnd();
            return JsonSerializer.Deserialize<List<Business>>(json).ToList();

        }

        public void Write(string path, List<Business> biz)
        {
            var json = JsonSerializer.Serialize(biz);
            File.WriteAllText(path, json);
        }
    }
}
