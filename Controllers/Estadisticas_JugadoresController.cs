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
    public class Estadisticas_JugadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Estadisticas_JugadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estadisticas_Jugadores
        public async Task<IActionResult> Index()
        {
              return _context.Estadisticas_Jugadores != null ? 
                          View(await _context.Estadisticas_Jugadores.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Estadisticas_Jugadores'  is null.");
        }

        // GET: Estadisticas_Jugadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estadisticas_Jugadores == null)
            {
                return NotFound();
            }

            var estadisticas_Jugadores = await _context.Estadisticas_Jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticas_Jugadores == null)
            {
                return NotFound();
            }

            return View(estadisticas_Jugadores);
        }

        // GET: Estadisticas_Jugadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadisticas_Jugadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_Jugador,Nombre_Jugador,Minutos_Jugados,Tiros_Campo_Intentados,Tiros_Campo_Exitosos,Porcentaje_Tiros_Campo,Tiros_3P_Intentados,Tiros_3P_Exitosos,Porcentaje_Tiros_3P,Tiros_2P_Intentados,Tiros_2P_Exitosos,Porcentaje_Tiros_2P,Tiros_Libres_Intentados,Tiros_Libres_Exitosos,Porcentaje_Tiros_Libres,Rebotes_Ofensivos,Rebotes_Densivos,Total_Rebotes,Asistencias,Robos,Bloqueos,Perdidas")] Estadisticas_Jugadores estadisticas_Jugadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadisticas_Jugadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadisticas_Jugadores);
        }

        // GET: Estadisticas_Jugadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estadisticas_Jugadores == null)
            {
                return NotFound();
            }

            var estadisticas_Jugadores = await _context.Estadisticas_Jugadores.FindAsync(id);
            if (estadisticas_Jugadores == null)
            {
                return NotFound();
            }
            return View(estadisticas_Jugadores);
        }

        // POST: Estadisticas_Jugadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_Jugador,Nombre_Jugador,Minutos_Jugados,Tiros_Campo_Intentados,Tiros_Campo_Exitosos,Porcentaje_Tiros_Campo,Tiros_3P_Intentados,Tiros_3P_Exitosos,Porcentaje_Tiros_3P,Tiros_2P_Intentados,Tiros_2P_Exitosos,Porcentaje_Tiros_2P,Tiros_Libres_Intentados,Tiros_Libres_Exitosos,Porcentaje_Tiros_Libres,Rebotes_Ofensivos,Rebotes_Densivos,Total_Rebotes,Asistencias,Robos,Bloqueos,Perdidas")] Estadisticas_Jugadores estadisticas_Jugadores)
        {
            if (id != estadisticas_Jugadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadisticas_Jugadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Estadisticas_JugadoresExists(estadisticas_Jugadores.Id))
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
            return View(estadisticas_Jugadores);
        }

        // GET: Estadisticas_Jugadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estadisticas_Jugadores == null)
            {
                return NotFound();
            }

            var estadisticas_Jugadores = await _context.Estadisticas_Jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticas_Jugadores == null)
            {
                return NotFound();
            }

            return View(estadisticas_Jugadores);
        }

        // POST: Estadisticas_Jugadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estadisticas_Jugadores == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Estadisticas_Jugadores'  is null.");
            }
            var estadisticas_Jugadores = await _context.Estadisticas_Jugadores.FindAsync(id);
            if (estadisticas_Jugadores != null)
            {
                _context.Estadisticas_Jugadores.Remove(estadisticas_Jugadores);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Estadisticas_JugadoresExists(int id)
        {
          return (_context.Estadisticas_Jugadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
