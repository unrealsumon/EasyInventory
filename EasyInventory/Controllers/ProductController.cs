using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyInventory.Business;
using EasyInventory.Data;
using EasyInventory.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {

        private InventoryManager manager; 

        public ProductController(InventoryContext context)
        {
            manager = new InventoryManager(context);
        }

        [HttpGet]
        public ActionResult GetProduct()
        {            
                var result = manager.GetProduct();
                return Ok(result);             
        }

        [HttpGet("{id}")]
        public ActionResult GetProductByID(int id)
        {
            var result = manager.GetProductByID(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("[action]")]

        public ActionResult Post(Product model)
        {
            string result = manager.AddUpdateProduct(model);
            if (result == string.Empty)
            {
                return Ok("Save Changes.");
            }
            else
            {
                return Ok(result);
            }
            //return Ok();

        }


        //[HttpPost]
        //public ActionResult DeleteProduct(int id)
        //{
        //    string result = manager.Delete(id);
        //    if (result == string.Empty)
        //    {
        //        return Ok("Save Changes.");
        //    }
        //    else
        //    {
        //        return Ok(result);
        //    }

        //}




    }
}