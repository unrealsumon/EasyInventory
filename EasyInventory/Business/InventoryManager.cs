using EasyInventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyInventory.Business
{
    public class InventoryManager
    {
        private readonly InventoryContext _context;

        public InventoryManager(InventoryContext context)
        {
            _context = context;
        }


        protected void GetProduct()
        {
            var result = _context.TB_Products.Select(x => x).ToList();
            return result;
        }
        //protected int AddProduct()
        //{

        //}

    }
}
