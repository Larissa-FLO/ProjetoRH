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
    public class FuncionariosInativosController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public FuncionariosInativosController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/FuncionariosInativos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<FuncionariosInativo>>> GetFuncionariosInativos()
        {
          if (_context.FuncionariosInativos == null)
          {
              return NotFound();
          }
            return await _context.FuncionariosInativos.ToListAsync();
        }

        // GET: api/FuncionariosInativos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<FuncionariosInativo>> GetFuncionariosInativo(int id)
        {
          if (_context.FuncionariosInativos == null)
          {
              return NotFound();
          }
            var funcionariosInativo = await _context.FuncionariosInativos.FindAsync(id);

            if (funcionariosInativo == null)
            {
                return NotFound();
            }

            return funcionariosInativo;
        }

        // PUT: api/FuncionariosInativos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutFuncionariosInativo(int id, FuncionariosInativo funcionariosInativo)
        {
            if (id != funcionariosInativo.IdFuncionario)
            {
                return BadRequest();
            }

            _context.Entry(funcionariosInativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionariosInativoExists(id))
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

        // POST: api/FuncionariosInativos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<FuncionariosInativo>> PostFuncionariosInativo(FuncionariosInativo funcionariosInativo)
        {
          if (_context.FuncionariosInativos == null)
          {
              return Problem("Entity set 'bemEstarRHContext.FuncionariosInativos'  is null.");
          }
            _context.FuncionariosInativos.Add(funcionariosInativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuncionariosInativo", new { id = funcionariosInativo.IdFuncionario }, funcionariosInativo);
        }

        // DELETE: api/FuncionariosInativos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteFuncionariosInativo(int id)
        {
            if (_context.FuncionariosInativos == null)
            {
                return NotFound();
            }
            var funcionariosInativo = await _context.FuncionariosInativos.FindAsync(id);
            if (funcionariosInativo == null)
            {
                return NotFound();
            }

            _context.FuncionariosInativos.Remove(funcionariosInativo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuncionariosInativoExists(int id)
        {
            return (_context.FuncionariosInativos?.Any(e => e.IdFuncionario == id)).GetValueOrDefault();
        }
    }
}
