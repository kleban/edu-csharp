using Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DataReaders
{
    public class SimpleTextDataManager : IDataManager
    {
        public List<Product> Read(string path)
        {
            throw new NotImplementedException();
        }

        public void Write(List<Product> list, string path)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path);
                foreach (var p in list)
                    writer.WriteLine($"{p.Id}|{p.Name}|{p.Price}|{p.Quantity}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer is not null)
                    writer.Close();
            }
        }
    }
}
