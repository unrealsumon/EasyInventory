using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Data
{
    public class TB_Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public int CategoryName { get; set; }

        public bool IsActive { get; set; }

        public List<TB_Products> TB_Products { get; set; }
    }
}
