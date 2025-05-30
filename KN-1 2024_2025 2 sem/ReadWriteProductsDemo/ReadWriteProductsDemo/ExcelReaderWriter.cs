using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteProductsDemo
{
    internal class ExcelReaderWriter
    {
        /*
         using OfficeOpenXml;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "path_to_your_excel_file.xlsx";
        FileInfo fileInfo = new FileInfo(filePath);

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming it's the first sheet

            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            // Read headers (Assuming headers are in the first row)
            for (int col = 1; col <= colCount; col++)
            {
                Console.Write(worksheet.Cells[1, col].Text + "\t");
            }
            Console.WriteLine();

            // Read data (Starting from row 2)
            for (int row = 2; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    Console.Write(worksheet.Cells[row, col].Text + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

         */
    }
}
