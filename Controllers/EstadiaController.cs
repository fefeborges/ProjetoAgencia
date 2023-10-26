using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoAgencia.Models;

namespace ProjetoAgencia.Controllers
{
    public class EstadiaController : Controller
    {
        private readonly Contexto _context;

        public EstadiaController(Contexto context)
        {
            _context = context;
        }

        // GET: Estadia
        public async Task<IActionResult> Index()
        {
              return _context.Estadia != null ? 
                          View(await _context.Estadia.ToListAsync()) :
                          Problem("Entity set 'Contexto.Estadia'  is null.");
        }

        // GET: Estadia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estadia == null)
            {
                return NotFound();
            }

            var estadia = await _context.Estadia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadia == null)
            {
                return NotFound();
            }

            return View(estadia);
        }

        // GET: Estadia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeEstadia")] Estadia estadia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadia);
        }

        // GET: Estadia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estadia == null)
            {
                return NotFound();
            }

            var estadia = await _context.Estadia.FindAsync(id);
            if (estadia == null)
            {
                return NotFound();
            }
            return View(estadia);
        }

        // POST: Estadia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeEstadia")] Estadia estadia)
        {
            if (id != estadia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadiaExists(estadia.Id))
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
            return View(estadia);
        }

        // GET: Estadia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estadia == null)
            {
                return NotFound();
            }

            var estadia = await _context.Estadia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadia == null)
            {
                return NotFound();
            }

            return View(estadia);
        }

        // POST: Estadia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estadia == null)
            {
                return Problem("Entity set 'Contexto.Estadia'  is null.");
            }
            var estadia = await _context.Estadia.FindAsync(id);
            if (estadia != null)
            {
                _context.Estadia.Remove(estadia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadiaExists(int id)
        {
          return (_context.Estadia?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
