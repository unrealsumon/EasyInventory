using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Data
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        public DbSet<TB_Products> TB_Products { get; set; }
        public DbSet<TB_Category> TB_Category { get; set; }
        public DbSet<TB_Inventory> TB_Inventory { get; set; }

    }
}
