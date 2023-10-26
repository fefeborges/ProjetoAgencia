using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAgencia.Models;

namespace ProjetoAgencia.Controllers
{
    public class AtracoesController : Controller
    {
        private readonly Contexto _context;

        public AtracoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Atracoes
        public async Task<IActionResult> Index()
        {
            return _context.Atracoes != null ?
                        View(await _context.Atracoes.ToListAsync()) :
                        Problem("Entity set 'Contexto.Atracoes'  is null.");
        }

        // GET: Atracoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atracoes == null)
            {
                return NotFound();
            }

            var atracoes = await _context.Atracoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atracoes == null)
            {
                return NotFound();
            }

            return View(atracoes);
        }

        // GET: Atracoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atracoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeAtracoes")] Atracoes atracoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atracoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atracoes);
        }

        // GET: Atracoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atracoes == null)
            {
                return NotFound();
            }

            var atracoes = await _context.Atracoes.FindAsync(id);
            if (atracoes == null)
            {
                return NotFound();
            }
            return View(atracoes);
        }

        // POST: Atracoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeAtracoes")] Atracoes atracoes)
        {
            if (id != atracoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atracoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtracoesExists(atracoes.Id))
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
            return View(atracoes);
        }

        // GET: Atracoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atracoes == null)
            {
                return NotFound();
            }

            var atracoes = await _context.Atracoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atracoes == null)
            {
                return NotFound();
            }

            return View(atracoes);
        }

        // POST: Atracoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atracoes == null)
            {
                return Problem("Entity set 'Contexto.Atracoes'  is null.");
            }
            var atracoes = await _context.Atracoes.FindAsync(id);
            if (atracoes != null)
            {
                _context.Atracoes.Remove(atracoes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtracoesExists(int id)
        {
            return (_context.Atracoes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
