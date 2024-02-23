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
    public class CargosController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public CargosController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/Cargos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Cargo>>> GetCargos()
        {
          if (_context.Cargos == null)
          {
              return NotFound();
          }
            return await _context.Cargos.ToListAsync();
        }

        // GET: api/Cargos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Cargo>> GetCargo(int id)
        {
          if (_context.Cargos == null)
          {
              return NotFound();
          }
            var cargo = await _context.Cargos.FindAsync(id);

            if (cargo == null)
            {
                return NotFound();
            }

            return cargo;
        }

        // PUT: api/Cargos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutCargo(int id, Cargo cargo)
        {
            if (id != cargo.CodCargo)
            {
                return BadRequest();
            }

            _context.Entry(cargo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargoExists(id))
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

        // POST: api/Cargos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Cargo>> PostCargo(Cargo cargo)
        {
          if (_context.Cargos == null)
          {
              return Problem("Entity set 'bemEstarRHContext.Cargos'  is null.");
          }
            _context.Cargos.Add(cargo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCargo", new { id = cargo.CodCargo }, cargo);
        }

        // DELETE: api/Cargos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCargo(int id)
        {
            if (_context.Cargos == null)
            {
                return NotFound();
            }
            var cargo = await _context.Cargos.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }

            _context.Cargos.Remove(cargo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CargoExists(int id)
        {
            return (_context.Cargos?.Any(e => e.CodCargo == id)).GetValueOrDefault();
        }
    }
}
