using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoApp.ReadFromExcel
{
    class ReadFromExcelFile
    {
        private static MasterItem masterItem = new MasterItem();
        private static List<MasterItem> masterItemList = new List<MasterItem>();
        private static string hsn;
        public static string ReadExcelFile(string searchItem)
        {
            
            var ep = new ExcelPackage(new FileInfo(@"C:\MagentoSetting\ItemMaster\ItemMaster.xlsx"));
            var ws = ep.Workbook.Worksheets["Sheet1"];

            for (int rw = 1; rw <= ws.Dimension.End.Row; rw++)
            {
                if (rw > 1)
                {
                    string Item_Code = ws.Cells[rw, 1].Value.ToString();                
                    hsn = ws.Cells[rw, 8].Value.ToString();

                    if (Item_Code.Equals(searchItem))
                    {
                        
                        return hsn;

                    }

                }

            }
            ep.Dispose();
            return hsn;


        }
    }
}
