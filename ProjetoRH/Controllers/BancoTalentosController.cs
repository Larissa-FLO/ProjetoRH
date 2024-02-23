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
    public class BancoTalentosController : ControllerBase
    {
        private readonly bemEstarRHContext _context;

        public BancoTalentosController(bemEstarRHContext context)
        {
            _context = context;
        }

        // GET: api/BancoTalentos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<BancoTalento>>> GetBancoTalentos()
        {
          if (_context.BancoTalentos == null)
          {
              return NotFound();
          }
            return await _context.BancoTalentos.ToListAsync();
        }

        // GET: api/BancoTalentos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<BancoTalento>> GetBancoTalento(int id)
        {
          if (_context.BancoTalentos == null)
          {
              return NotFound();
          }
            var bancoTalento = await _context.BancoTalentos.FindAsync(id);

            if (bancoTalento == null)
            {
                return NotFound();
            }

            return bancoTalento;
        }

        // PUT: api/BancoTalentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutBancoTalento(int id, BancoTalento bancoTalento)
        {
            if (id != bancoTalento.IdFuncionario)
            {
                return BadRequest();
            }

            _context.Entry(bancoTalento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BancoTalentoExists(id))
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

        // POST: api/BancoTalentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<BancoTalento>> PostBancoTalento(BancoTalento bancoTalento)
        {
          if (_context.BancoTalentos == null)
          {
              return Problem("Entity set 'bemEstarRHContext.BancoTalentos'  is null.");
          }
            _context.BancoTalentos.Add(bancoTalento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBancoTalento", new { id = bancoTalento.IdFuncionario }, bancoTalento);
        }

        // DELETE: api/BancoTalentos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteBancoTalento(int id)
        {
            if (_context.BancoTalentos == null)
            {
                return NotFound();
            }
            var bancoTalento = await _context.BancoTalentos.FindAsync(id);
            if (bancoTalento == null)
            {
                return NotFound();
            }

            _context.BancoTalentos.Remove(bancoTalento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BancoTalentoExists(int id)
        {
            return (_context.BancoTalentos?.Any(e => e.IdFuncionario == id)).GetValueOrDefault();
        }
    }
}
