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
    public class TreinamentosController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public TreinamentosController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/Treinamentos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Treinamento>>> GetTreinamentos()
        {
          if (_context.Treinamentos == null)
          {
              return NotFound();
          }
            return await _context.Treinamentos.ToListAsync();
        }

        // GET: api/Treinamentos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Treinamento>> GetTreinamento(int id)
        {
          if (_context.Treinamentos == null)
          {
              return NotFound();
          }
            var treinamento = await _context.Treinamentos.FindAsync(id);

            if (treinamento == null)
            {
                return NotFound();
            }

            return treinamento;
        }

        // PUT: api/Treinamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutTreinamento(int id, Treinamento treinamento)
        {
            if (id != treinamento.IdTreinamento)
            {
                return BadRequest();
            }

            _context.Entry(treinamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreinamentoExists(id))
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

        // POST: api/Treinamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Treinamento>> PostTreinamento(Treinamento treinamento)
        {
          if (_context.Treinamentos == null)
          {
              return Problem("Entity set 'bemEstarRHContext.Treinamentos'  is null.");
          }
            _context.Treinamentos.Add(treinamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreinamento", new { id = treinamento.IdTreinamento }, treinamento);
        }

        // DELETE: api/Treinamentos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteTreinamento(int id)
        {
            if (_context.Treinamentos == null)
            {
                return NotFound();
            }
            var treinamento = await _context.Treinamentos.FindAsync(id);
            if (treinamento == null)
            {
                return NotFound();
            }

            _context.Treinamentos.Remove(treinamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TreinamentoExists(int id)
        {
            return (_context.Treinamentos?.Any(e => e.IdTreinamento == id)).GetValueOrDefault();
        }
    }
}
