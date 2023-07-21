using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueMaster.Data;
using LeagueMaster.Models;
using Microsoft.AspNetCore.Authorization;

namespace LeagueMaster.Controllers
{
    [Authorize]
    public class CalendariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calendarios
        public async Task<IActionResult> Index()
        {
              return _context.Calendario != null ? 
                          View(await _context.Calendario.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Calendario'  is null.");
        }

        // GET: Calendarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Calendario == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendario == null)
            {
                return NotFound();
            }

            return View(calendario);
        }

        // GET: Calendarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calendarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Hora,Estadio,Equipo_Local,Equipo_Visitante,Jornada,Competicion,Notas_Adicionales,Arbitro_1,Arbitro_2,Mesa_principal")] Calendario calendario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calendario);
        }

        // GET: Calendarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Calendario == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario.FindAsync(id);
            if (calendario == null)
            {
                return NotFound();
            }
            return View(calendario);
        }

        // POST: Calendarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Hora,Estadio,Equipo_Local,Equipo_Visitante,Jornada,Competicion,Notas_Adicionales,Arbitro_1,Arbitro_2,Mesa_principal")] Calendario calendario)
        {
            if (id != calendario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarioExists(calendario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(calendario);
        }

        // GET: Calendarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Calendario == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendario == null)
            {
                return NotFound();
            }

            return View(calendario);
        }

        // POST: Calendarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Calendario == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Calendario'  is null.");
            }
            var calendario = await _context.Calendario.FindAsync(id);
            if (calendario != null)
            {
                _context.Calendario.Remove(calendario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarioExists(int id)
        {
          return (_context.Calendario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
