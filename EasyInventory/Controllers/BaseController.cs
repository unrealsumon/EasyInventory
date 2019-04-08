using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyInventory.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {

        public  InventoryContext _context;

      

    }
}