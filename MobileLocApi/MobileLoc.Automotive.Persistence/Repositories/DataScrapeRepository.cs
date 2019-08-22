using SpreadsheetGear;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLoc.Automotive.Persistence.Repositories
{
    public class DataScrapeRepository
    {
        public string SpreadsheetTest()
        {
            // Open MyData.xls.
            SpreadsheetGear.IWorkbook workbook = SpreadsheetGear.Factory.GetWorkbook(@"C:\git\_DELETEME\MobileLoc1.0\MobileLocApi\Files\2019-auto-truck-key-blank-reference.xlsx");
            // Get a reference to the first worksheet.
            SpreadsheetGear.IWorksheet worksheet = workbook.Worksheets["Page 3"];
            // Get a reference to the top left cell of Sheet1.
            SpreadsheetGear.IRange a16 = worksheet.Cells["A16"];
            // Output the value of A1.
            var message = a16.Value.ToString();

            return message;
        }

        public object[,] SpreadsheetRead()
        {
            // Create a workbook and get the first worksheet
            SpreadsheetGear.IWorkbook workbook = SpreadsheetGear.Factory.GetWorkbook(@"C:\git\_DELETEME\MobileLoc1.0\MobileLocApi\Files\2019-auto-truck-key-blank-reference.xlsx");
            // Get a reference to the first worksheet.
            SpreadsheetGear.IWorksheet worksheet = workbook.Worksheets["Page 3"];

            // Create a 10 row by 2 column array of values
            object[,] values = new object[10, 2];
            for (int i = 0; i < 10; i++)
            {
                values[i, 0] = "Row=" + i + " Col=0";
                values[i, 1] = "Row=" + i + " Col=1";
            }

            // Set the values in the worksheet
            // Notice the range "A1:B10" has to match the size of the array
            worksheet.Cells["A1:B10"].Value = values;

            // Get the values from the worksheet
            object[,] retVals = (object[,])worksheet.Cells["A1:B10"].Value;

            // Save to C:\MyData.xls as Excel file.
            workbook.SaveAs(@"C:\git\_DELETEME\MobileLoc1.0\MobileLocApi\Files\MyData.csv", SpreadsheetGear.FileFormat.CSV);
            // Open C:\MyData.xls.
            workbook = SpreadsheetGear.Factory.GetWorkbook(@"C:\git\_DELETEME\MobileLoc1.0\MobileLocApi\Files\MyData.csv");
            return retVals;
        }
    }
}