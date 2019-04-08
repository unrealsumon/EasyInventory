using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Data
{
    public class TB_Inventory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public float UnitPrice { get; set; }
        public int Quanity { get; set; }
        public float TotalPrice { get; set; }
        public TB_Products TB_Products { get; set; }
     
    }
}
