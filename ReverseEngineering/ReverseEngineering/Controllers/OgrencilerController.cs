using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReverseEngineering.Data;
using ReverseEngineering.Models;

namespace ReverseEngineering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrencilerController : ControllerBase
    {
        private readonly PauDbContext _context;

        public OgrencilerController(PauDbContext context)
        {
            _context = context;
        }

        // GET: api/Ogrenciler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ogrenciler>>> GetOgrencilers()
        {
            return await _context.Ogrencilers.ToListAsync();
        }

        // GET: api/Ogrenciler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ogrenciler>> GetOgrenciler(int id)
        {
            var ogrenciler = await _context.Ogrencilers.FindAsync(id);

            if (ogrenciler == null)
            {
                return NotFound();
            }

            return ogrenciler;
        }

        // PUT: api/Ogrenciler/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOgrenciler(int id, Ogrenciler ogrenciler)
        {
            if (id != ogrenciler.Id)
            {
                return BadRequest();
            }

            _context.Entry(ogrenciler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgrencilerExists(id))
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

        // POST: api/Ogrenciler
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ogrenciler>> PostOgrenciler(Ogrenciler ogrenciler)
        {
            _context.Ogrencilers.Add(ogrenciler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOgrenciler", new { id = ogrenciler.Id }, ogrenciler);
        }

        // DELETE: api/Ogrenciler/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOgrenciler(int id)
        {
            var ogrenciler = await _context.Ogrencilers.FindAsync(id);
            if (ogrenciler == null)
            {
                return NotFound();
            }

            _context.Ogrencilers.Remove(ogrenciler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OgrencilerExists(int id)
        {
            return _context.Ogrencilers.Any(e => e.Id == id);
        }
    }
}
