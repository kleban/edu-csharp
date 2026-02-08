using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    public class ExcelReaderWriter : IProductReaderWriter
    {
        
        public List<Product> Read(string path)
        {
            var list = new List<Product>();
            ExcelPackage.License.SetNonCommercialOrganization("NaU_OA");
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                var worksheet = package.Workbook.Worksheets[0];

                // Assuming your table starts from A1 and has headers in the first row
                var start = worksheet.Dimension.Start;
                var end = worksheet.Dimension.End;

                // Read the data from the table
                for (int row = start.Row + 1; row <= end.Row; row++) // start.Row + 1 skips header
                {
                    var name = worksheet.Cells[row, 1].Text;
                    var price = double.Parse(worksheet.Cells[row, 2].Text);
                    var q = int.Parse(worksheet.Cells[row, 3].Text);
                    var unit = worksheet.Cells[row, 4].Text;

                    list.Add(new Product
                    {
                        Name = name,
                        Price = price,
                        Quantity = q,
                        Unit = unit
                    });
                }
                return list;
            }
        }
        

        public void Write(List<Product> products, string path)
        {
            ExcelPackage.License.SetNonCommercialOrganization("NaU_OA");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Products");

                // Writing headers
                worksheet.Cells[1, 1].Value = "Name";
                worksheet.Cells[1, 2].Value = "Price";
                worksheet.Cells[1, 3].Value = "Quantity";
                worksheet.Cells[1, 4].Value = "Unit";

                // Writing data
                int row = 2;
                foreach (var product in products)
                {
                    worksheet.Cells[row, 1].Value = product.Name;
                    worksheet.Cells[row, 2].Value = Math.Round(product.Price, 4);
                    worksheet.Cells[row, 3].Value = product.Quantity;
                    worksheet.Cells[row, 4].Value = product.Unit;
                    row++;
                }

                // Auto-fit columns
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Save the Excel file
                package.SaveAs(new FileInfo(path));
            }
        }
    }
}
