using DataReadWrite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataReadWrite.Managers
{
    public class XmlReaderWriter : IBookReaderWriter
    {
        public IEnumerable<Book> Read(string path)
        {
            XDocument xdoc = XDocument.Load(path);
            var list = new List<Book>();
     
            IEnumerable<XElement> xel = xdoc.Root.Element("books").Elements("book");
            foreach (var b in xel)
            {
                list.Add(new Book { Id = int.Parse(b.Attribute("id").Value),
                Title = b.Element("title").Value});
            }

            return list;

        }

        public void Write(IEnumerable<Book> books, string path)
        {
            XDocument xdoc = new XDocument();
            xdoc.Declaration = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Add(new XElement("library"));

            xdoc.Root.Add(new XElement("books"));

            var xbooks = xdoc.Root.Element("books");
            foreach (var b in books)
            {
                xbooks.Add(new XElement("book",
                    new XAttribute("id", b.Id),
                    new XElement("title", b.Title),
                    new XElement("year", b.Year),
                    new XElement("publisher", 
                        new XElement("name", b.Publisher.Name),
                        new XElement("city", b.Publisher.City))));
            }

            xdoc.Save(path);
        }
    }
}
