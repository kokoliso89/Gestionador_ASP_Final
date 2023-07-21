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
    public class PartidosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Partidos
        public async Task<IActionResult> Index()
        {
              return _context.Partidos != null ? 
                          View(await _context.Partidos.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Partidos'  is null.");
        }

        // GET: Partidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Partidos == null)
            {
                return NotFound();
            }

            var partidos = await _context.Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partidos == null)
            {
                return NotFound();
            }

            return View(partidos);
        }

        // GET: Partidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Hora,Estadio,Resultado")] Partidos partidos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partidos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partidos);
        }

        // GET: Partidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Partidos == null)
            {
                return NotFound();
            }

            var partidos = await _context.Partidos.FindAsync(id);
            if (partidos == null)
            {
                return NotFound();
            }
            return View(partidos);
        }

        // POST: Partidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Hora,Estadio,Resultado")] Partidos partidos)
        {
            if (id != partidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartidosExists(partidos.Id))
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
            return View(partidos);
        }

        // GET: Partidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Partidos == null)
            {
                return NotFound();
            }

            var partidos = await _context.Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partidos == null)
            {
                return NotFound();
            }

            return View(partidos);
        }

        // POST: Partidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Partidos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Partidos'  is null.");
            }
            var partidos = await _context.Partidos.FindAsync(id);
            if (partidos != null)
            {
                _context.Partidos.Remove(partidos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartidosExists(int id)
        {
          return (_context.Partidos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
