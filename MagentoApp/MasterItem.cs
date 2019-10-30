using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoApp
{
    class MasterItem
    {
        public string Item_Code { get; set; }
        public string Product_Name { get; set; }
        public string Packing_Size { get; set; }
        public double MRP { get; set; }
        public string IGST { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
       
    }
}
