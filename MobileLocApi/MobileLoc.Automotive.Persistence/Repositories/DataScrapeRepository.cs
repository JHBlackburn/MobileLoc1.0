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
    }
}