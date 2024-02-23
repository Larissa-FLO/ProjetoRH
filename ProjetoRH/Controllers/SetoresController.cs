using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoRH.Models;

namespace ProjetoRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetoresController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public SetoresController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/Setores
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Setore>>> GetSetores()
        {
          if (_context.Setores == null)
          {
              return NotFound();
          }
            return await _context.Setores.ToListAsync();
        }

        // GET: api/Setores/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Setore>> GetSetore(int id)
        {
          if (_context.Setores == null)
          {
              return NotFound();
          }
            var setore = await _context.Setores.FindAsync(id);

            if (setore == null)
            {
                return NotFound();
            }

            return setore;
        }

        // PUT: api/Setores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutSetore(int id, Setore setore)
        {
            if (id != setore.CodSetor)
            {
                return BadRequest();
            }

            _context.Entry(setore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SetoreExists(id))
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

        // POST: api/Setores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Setore>> PostSetore(Setore setore)
        {
          if (_context.Setores == null)
          {
              return Problem("Entity set 'bemEstarRHContext.Setores'  is null.");
          }
            _context.Setores.Add(setore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSetore", new { id = setore.CodSetor }, setore);
        }

        // DELETE: api/Setores/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteSetore(int id)
        {
            if (_context.Setores == null)
            {
                return NotFound();
            }
            var setore = await _context.Setores.FindAsync(id);
            if (setore == null)
            {
                return NotFound();
            }

            _context.Setores.Remove(setore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SetoreExists(int id)
        {
            return (_context.Setores?.Any(e => e.CodSetor == id)).GetValueOrDefault();
        }
    }
}
