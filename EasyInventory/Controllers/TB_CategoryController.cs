using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EasyInventory.Data;

namespace EasyInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TB_CategoryController : BaseController
    {
        
        // GET: api/TB_Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TB_Category>>> GetTB_Category()
        {
            return await _context.TB_Category.ToListAsync();
        }

        // GET: api/TB_Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TB_Category>> GetTB_Category(int id)
        {
            var tB_Category = await _context.TB_Category.FindAsync(id);

            if (tB_Category == null)
            {
                return NotFound();
            }

            return tB_Category;
        }

        // PUT: api/TB_Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTB_Category(int id, TB_Category tB_Category)
        {
            if (id != tB_Category.CategoryID)
            {
                return BadRequest();
            }

            _context.Entry(tB_Category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TB_CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TB_Category
        [HttpPost]
        public async Task<ActionResult<TB_Category>> PostTB_Category(TB_Category tB_Category)
        {
            _context.TB_Category.Add(tB_Category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTB_Category", new { id = tB_Category.CategoryID }, tB_Category);
        }

        // DELETE: api/TB_Category/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TB_Category>> DeleteTB_Category(int id)
        {
            var tB_Category = await _context.TB_Category.FindAsync(id);
            if (tB_Category == null)
            {
                return NotFound();
            }

            _context.TB_Category.Remove(tB_Category);
            await _context.SaveChangesAsync();

            return tB_Category;
        }

        private bool TB_CategoryExists(int id)
        {
            return _context.TB_Category.Any(e => e.CategoryID == id);
        }
    }
}
