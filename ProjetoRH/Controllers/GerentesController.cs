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
    public class GerentesController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public GerentesController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/Gerentes
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Gerente>>> GetGerentes()
        {
          if (_context.Gerentes == null)
          {
              return NotFound();
          }
            return await _context.Gerentes.ToListAsync();
        }

        // GET: api/Gerentes/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Gerente>> GetGerente(int id)
        {
          if (_context.Gerentes == null)
          {
              return NotFound();
          }
            var gerente = await _context.Gerentes.FindAsync(id);

            if (gerente == null)
            {
                return NotFound();
            }

            return gerente;
        }

        // PUT: api/Gerentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutGerente(int id, Gerente gerente)
        {
            if (id != gerente.CodGerente)
            {
                return BadRequest();
            }

            _context.Entry(gerente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GerenteExists(id))
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

        // POST: api/Gerentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Gerente>> PostGerente(Gerente gerente)
        {
          if (_context.Gerentes == null)
          {
              return Problem("Entity set 'bemEstarRHContext.Gerentes'  is null.");
          }
            _context.Gerentes.Add(gerente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGerente", new { id = gerente.CodGerente }, gerente);
        }

        // DELETE: api/Gerentes/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteGerente(int id)
        {
            if (_context.Gerentes == null)
            {
                return NotFound();
            }
            var gerente = await _context.Gerentes.FindAsync(id);
            if (gerente == null)
            {
                return NotFound();
            }

            _context.Gerentes.Remove(gerente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GerenteExists(int id)
        {
            return (_context.Gerentes?.Any(e => e.CodGerente == id)).GetValueOrDefault();
        }
    }
}
