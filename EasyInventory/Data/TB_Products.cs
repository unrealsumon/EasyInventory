using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Data
{
    public class TB_Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string UnitName { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public TB_Category TB_Category { get; set; }
        public TB_Inventory TB_Inventory { get; set; }

    }
}
