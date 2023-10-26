using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAgencia.Models;

namespace ProjetoAgencia.Controllers
{
    public class PassageirosController : Controller
    {
        private readonly Contexto _context;

        public PassageirosController(Contexto context)
        {
            _context = context;
        }

        // GET: Passageiros
        public async Task<IActionResult> Index()
        {
            return _context.Passageiros != null ?
                        View(await _context.Passageiros.ToListAsync()) :
                        Problem("Entity set 'Contexto.Passageiros'  is null.");
        }

        // GET: Passageiros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Passageiros == null)
            {
                return NotFound();
            }

            var passageiros = await _context.Passageiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passageiros == null)
            {
                return NotFound();
            }

            return View(passageiros);
        }

        // GET: Passageiros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Passageiros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomePassageiros")] Passageiros passageiros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passageiros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passageiros);
        }

        // GET: Passageiros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Passageiros == null)
            {
                return NotFound();
            }

            var passageiros = await _context.Passageiros.FindAsync(id);
            if (passageiros == null)
            {
                return NotFound();
            }
            return View(passageiros);
        }

        // POST: Passageiros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomePassageiros")] Passageiros passageiros)
        {
            if (id != passageiros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passageiros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassageirosExists(passageiros.Id))
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
            return View(passageiros);
        }

        // GET: Passageiros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Passageiros == null)
            {
                return NotFound();
            }

            var passageiros = await _context.Passageiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passageiros == null)
            {
                return NotFound();
            }

            return View(passageiros);
        }

        // POST: Passageiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Passageiros == null)
            {
                return Problem("Entity set 'Contexto.Passageiros'  is null.");
            }
            var passageiros = await _context.Passageiros.FindAsync(id);
            if (passageiros != null)
            {
                _context.Passageiros.Remove(passageiros);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassageirosExists(int id)
        {
            return (_context.Passageiros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
