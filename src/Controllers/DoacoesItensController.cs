using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using skateparatodos.Models;

namespace skateparatodos.Controllers
{
    public class DoacoesItensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoacoesItensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DoacoesItens
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DoacoesItens.Include(d => d.Doacao).Include(d => d.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DoacoesItens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacaoItem = await _context.DoacoesItens
                .Include(d => d.Doacao)
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doacaoItem == null)
            {
                return NotFound();
            }

            return View(doacaoItem);
        }

        // GET: DoacoesItens/Create
        public IActionResult Create()
        {
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: DoacoesItens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DoacaoId,Descricao,Peca,UsuarioId")] DoacaoItem doacaoItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doacaoItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", doacaoItem.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacaoItem.UsuarioId);
            return View(doacaoItem);
        }

        // GET: DoacoesItens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacaoItem = await _context.DoacoesItens.FindAsync(id);
            if (doacaoItem == null)
            {
                return NotFound();
            }
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", doacaoItem.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacaoItem.UsuarioId);
            return View(doacaoItem);
        }

        // POST: DoacoesItens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DoacaoId,Descricao,Peca,UsuarioId")] DoacaoItem doacaoItem)
        {
            if (id != doacaoItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doacaoItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoItemExists(doacaoItem.Id))
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
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", doacaoItem.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacaoItem.UsuarioId);
            return View(doacaoItem);
        }


        // POST: DoacoesItens/Doar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Doar(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacaoItem = await _context.DoacoesItens.FindAsync(id);
            if (doacaoItem == null)
            {
                return NotFound();
            }

            doacaoItem.Usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doacaoItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoItemExists(doacaoItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                //return RedirectToAction(nameof(Index));
                //return View(doacaoItem.Doacao);
                //ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", doacaoItem.DoacaoId);
                return RedirectToAction("Details","Doacoes", new { id = doacaoItem.DoacaoId });
            }
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", doacaoItem.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacaoItem.UsuarioId);
            return View(doacaoItem.Doacao);
        }

        // GET: DoacoesItens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacaoItem = await _context.DoacoesItens
                .Include(d => d.Doacao)
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doacaoItem == null)
            {
                return NotFound();
            }

            return View(doacaoItem);
        }

        // POST: DoacoesItens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doacaoItem = await _context.DoacoesItens.FindAsync(id);
            _context.DoacoesItens.Remove(doacaoItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoacaoItemExists(int id)
        {
            return _context.DoacoesItens.Any(e => e.Id == id);
        }
    }
}
