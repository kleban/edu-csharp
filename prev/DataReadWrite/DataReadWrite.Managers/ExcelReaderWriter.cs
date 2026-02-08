using DataReadWrite.Domain;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadWrite.Managers
{
    public class ExcelReaderWriter : IBookReaderWriter
    {
        public IEnumerable<Book> Read(string path)
        {
            var list = new List<Book>();
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets[0];

                int rowCount = ws.Dimension.End.Row;

                for(int r = 2; r <= rowCount; r++)
                {
                    list.Add(new Book
                    {
                        Id = ws.Cells[r, 1].GetValue<int>(),
                        Title = ws.Cells[r,2].Value.ToString(),
                        Year = ws.Cells[r, 3].GetValue<int>(),
                        Publisher = new Publisher
                        {
                            Name = ws.Cells[r, 4].Value.ToString(),
                            City = ws.Cells[r, 5].Value.ToString(),
                        }
                    });
                }

            }
            return list;
        }

        public void Write(IEnumerable<Book> books, string path)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("library");

                ws.Cells[1, 1].Value = "Id";
                ws.Cells[1, 2].Value = "Title";
                ws.Cells[1, 3].Value = "Year";
                ws.Cells[1, 4].Value = "Publisher";
                ws.Cells[1, 5].Value = "PubCity";

                int r = 2;

                foreach(var b in books)
                {
                    ws.Cells[r, 1].Value = b.Id;
                    ws.Cells[r, 2].Value = b.Title;
                    ws.Cells[r, 3].Value = b.Year;
                    ws.Cells[r, 4].Value = b.Publisher.Name;
                    ws.Cells[r, 5].Value = b.Publisher.City;
                    r++;
                }
                
                package.Save();
            }
        }
    }
}
