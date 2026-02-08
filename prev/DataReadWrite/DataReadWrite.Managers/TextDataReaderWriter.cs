using DataReadWrite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadWrite.Managers
{
    public class TextDataReaderWriter : IBookReaderWriter
    {
        public IEnumerable<Book> Read(string path)
        {
            var data = new List<Book>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);
                string line = string.Empty;

                while ((line = reader.ReadLine()) is not null)
                { 
                    var items = line.Split(';');
                    data.Add(new Book {
                        Id = int.Parse(items[0]),
                        Title = items[1],
                        Year = int.Parse(items[2]),
                        Publisher = new Publisher
                        {
                            City = items[4],
                            Name = items[3]
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if(reader is not null) reader.Close();
            }
            return data;
        }

        public void Write(IEnumerable<Book> books, string path)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(path);
                foreach (Book b in books) 
                { 
                    sw.WriteLine($"{b.Id};{b.Title};{b.Year};{b.Publisher.City};{b.Publisher.Name}");
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if(sw is not null)
                {
                    sw.Flush();
                    sw.Close();
                }
            }

        }
    }
}
