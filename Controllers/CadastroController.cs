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
    public class CadastroController : Controller
    {
        private readonly Contexto _context;

        public CadastroController(Contexto context)
        {
            _context = context;
        }

        // GET: Cadastro
        public async Task<IActionResult> Index(string pesquisa)
        {   
            if (pesquisa == null)
            {
                return _context.Cadastro != null ?
                            View(await _context.Cadastro.ToListAsync()) :
                            Problem("Entity set 'Contexto.Cadastro'  is null.");
            }
            else
            {
                var cadastro =
                    _context.Cadastro
                    .Where(x => x.NomePessoa.Contains(pesquisa))
                    .OrderBy(x => x.NomePessoa);

                return View(cadastro);
            }
        }

        // GET: Cadastro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .Include(c => c.Destino)
                .Include(c => c.Estadia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // GET: Cadastro/Create
        public IActionResult Create()
        {
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Id");
            ViewData["EstadiaId"] = new SelectList(_context.Estadia, "Id", "Id");
            return View();
        }

        // POST: Cadastro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomePessoa,DestinoId,EstadiaId,NomeContato")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Id", cadastro.DestinoId);
            ViewData["EstadiaId"] = new SelectList(_context.Estadia, "Id", "Id", cadastro.EstadiaId);
            return View(cadastro);
        }

        // GET: Cadastro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Id", cadastro.DestinoId);
            ViewData["EstadiaId"] = new SelectList(_context.Estadia, "Id", "Id", cadastro.EstadiaId);
            return View(cadastro);
        }

        // POST: Cadastro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomePessoa,DestinoId,EstadiaId,NomeContato")] Cadastro cadastro)
        {
            if (id != cadastro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.Id))
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
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Id", cadastro.DestinoId);
            ViewData["EstadiaId"] = new SelectList(_context.Estadia, "Id", "Id", cadastro.EstadiaId);
            return View(cadastro);
        }

        // GET: Cadastro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .Include(c => c.Destino)
                .Include(c => c.Estadia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // POST: Cadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadastro == null)
            {
                return Problem("Entity set 'Contexto.Cadastro'  is null.");
            }
            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastro.Remove(cadastro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExists(int id)
        {
          return (_context.Cadastro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
