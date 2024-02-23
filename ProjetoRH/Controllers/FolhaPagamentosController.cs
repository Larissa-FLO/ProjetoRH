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
    public class FolhaPagamentosController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public FolhaPagamentosController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/FolhaPagamentos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<FolhaPagamento>>> GetFolhaPagamentos()
        {
          if (_context.FolhaPagamentos == null)
          {
              return NotFound();
          }
            return await _context.FolhaPagamentos.ToListAsync();
        }

        // GET: api/FolhaPagamentos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<FolhaPagamento>> GetFolhaPagamento(int id)
        {
          if (_context.FolhaPagamentos == null)
          {
              return NotFound();
          }
            var folhaPagamento = await _context.FolhaPagamentos.FindAsync(id);

            if (folhaPagamento == null)
            {
                return NotFound();
            }

            return folhaPagamento;
        }

        // PUT: api/FolhaPagamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutFolhaPagamento(int id, FolhaPagamento folhaPagamento)
        {
            if (id != folhaPagamento.IdLancamento)
            {
                return BadRequest();
            }

            _context.Entry(folhaPagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FolhaPagamentoExists(id))
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

        // POST: api/FolhaPagamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<FolhaPagamento>> PostFolhaPagamento(FolhaPagamento folhaPagamento)
        {
          if (_context.FolhaPagamentos == null)
          {
              return Problem("Entity set 'bemEstarRHContext.FolhaPagamentos'  is null.");
          }
            _context.FolhaPagamentos.Add(folhaPagamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFolhaPagamento", new { id = folhaPagamento.IdLancamento }, folhaPagamento);
        }

        // DELETE: api/FolhaPagamentos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteFolhaPagamento(int id)
        {
            if (_context.FolhaPagamentos == null)
            {
                return NotFound();
            }
            var folhaPagamento = await _context.FolhaPagamentos.FindAsync(id);
            if (folhaPagamento == null)
            {
                return NotFound();
            }

            _context.FolhaPagamentos.Remove(folhaPagamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FolhaPagamentoExists(int id)
        {
            return (_context.FolhaPagamentos?.Any(e => e.IdLancamento == id)).GetValueOrDefault();
        }
    }
}
