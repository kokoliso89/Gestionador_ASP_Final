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
    public class Estadisticas_PartidosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Estadisticas_PartidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estadisticas_Partidos
        public async Task<IActionResult> Index()
        {
              return _context.Estadisticas_Partidos != null ? 
                          View(await _context.Estadisticas_Partidos.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Estadisticas_Partidos'  is null.");
        }

        // GET: Estadisticas_Partidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estadisticas_Partidos == null)
            {
                return NotFound();
            }

            var estadisticas_Partidos = await _context.Estadisticas_Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticas_Partidos == null)
            {
                return NotFound();
            }

            return View(estadisticas_Partidos);
        }

        // GET: Estadisticas_Partidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadisticas_Partidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Equipo_Local,Equipo_Visitante,Puntos_Local,Puntos_Visitantes,Canastas_3,Canastas_2,Canastas_1,Total_Faltas,Fecha,Hora,Estadio,Jornada,Competicion,Notas_Adicionales,Arbitro_1,Arbitro_2,Mesa_principal")] Estadisticas_Partidos estadisticas_Partidos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadisticas_Partidos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadisticas_Partidos);
        }

        // GET: Estadisticas_Partidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estadisticas_Partidos == null)
            {
                return NotFound();
            }

            var estadisticas_Partidos = await _context.Estadisticas_Partidos.FindAsync(id);
            if (estadisticas_Partidos == null)
            {
                return NotFound();
            }
            return View(estadisticas_Partidos);
        }

        // POST: Estadisticas_Partidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Equipo_Local,Equipo_Visitante,Puntos_Local,Puntos_Visitantes,Canastas_3,Canastas_2,Canastas_1,Total_Faltas,Fecha,Hora,Estadio,Jornada,Competicion,Notas_Adicionales,Arbitro_1,Arbitro_2,Mesa_principal")] Estadisticas_Partidos estadisticas_Partidos)
        {
            if (id != estadisticas_Partidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadisticas_Partidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Estadisticas_PartidosExists(estadisticas_Partidos.Id))
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
            return View(estadisticas_Partidos);
        }

        // GET: Estadisticas_Partidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estadisticas_Partidos == null)
            {
                return NotFound();
            }

            var estadisticas_Partidos = await _context.Estadisticas_Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticas_Partidos == null)
            {
                return NotFound();
            }

            return View(estadisticas_Partidos);
        }

        // POST: Estadisticas_Partidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estadisticas_Partidos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Estadisticas_Partidos'  is null.");
            }
            var estadisticas_Partidos = await _context.Estadisticas_Partidos.FindAsync(id);
            if (estadisticas_Partidos != null)
            {
                _context.Estadisticas_Partidos.Remove(estadisticas_Partidos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Estadisticas_PartidosExists(int id)
        {
          return (_context.Estadisticas_Partidos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
