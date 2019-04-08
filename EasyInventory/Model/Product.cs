using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Model
{
    public class Product
    {        
        public int ProductID { get; set; }    
        public string ProductName { get; set; }       
        public int CategoryID { get; set; }       
        public string UnitName { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
