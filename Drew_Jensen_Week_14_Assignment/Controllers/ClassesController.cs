#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Drew_Jensen_Week_14_Assignment.Data;
using Drew_Jensen_Week_14_Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Drew_Jensen_Week_14_Assignment;

namespace Drew_Jensen_Week_14_Assignment.Controllers

{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly Wossamotta_UContext _context;

        
        public ClassesController(Wossamotta_UContext context)
        {
            _context = context;
        }
        


        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(string id)
        {
            var @class = await _context.Classes.FindAsync(id);

            if (@class == null)
            {
                return NotFound();
            }

            return @class;
        }

        //public List<Product> GetClass()
        //{
        //    throw new NotImplementedException();
        //}

        // PUT: api/Classes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(string id, Class @class)
        {
            if (id != @class.ClassId)
            {
                return BadRequest();
            }

            _context.Entry(@class).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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

        // POST: api/Classes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class @class)
        {
            _context.Classes.Add(@class);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClassExists(@class.ClassId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClass", new { id = @class.ClassId }, @class);
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(string id)
        {
            var @class = await _context.Classes.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassExists(string id)
        {
            return _context.Classes.Any(e => e.ClassId == id);
        }
    }
}
