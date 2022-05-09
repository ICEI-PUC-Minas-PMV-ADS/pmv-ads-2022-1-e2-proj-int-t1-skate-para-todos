using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using skateparatodos.Models;

namespace skateparatodos.Controllers
{
    [Authorize]
    public class DoacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Doacoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doacoes.Include(d => d.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Doacoes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes
                .Include(d => d.Usuario)
                .Include(d => d.DoacoesItens)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // GET: Doacoes/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }


        // GET: Doacoes/CreateDois
        public IActionResult CreateDois()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Doacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,")] Doacao doacao)
        {
            if (ModelState.IsValid)
            {
                doacao.DataCriacao = DateTime.Now;
                doacao.Usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == User.FindFirstValue(ClaimTypes.NameIdentifier));
                doacao.Status = StatusDoacao.Aberta;
                _context.Add(doacao);
                await _context.SaveChangesAsync();

                doacao.DoacoesItens = new List<DoacaoItem>();
                // Add parts to the list.
                foreach (TipoPeca tipopeca in Enum.GetValues(typeof(TipoPeca)))
                {
                    DoacaoItem doacaoItem = new DoacaoItem();
                    doacaoItem.Doacao = doacao;
                    doacaoItem.Peca = tipopeca;
                    doacaoItem.DoacaoId = doacao.Id;
                    doacao.DoacoesItens.Add(doacaoItem);
                    _context.Add(doacaoItem);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacao.UsuarioId);
            //return View("CreatePecas");
            return View(doacao);
        }

        // GET: Doacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes.FindAsync(id);
            if (doacao == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacao.UsuarioId);
            return View(doacao);
        }

        // POST: Doacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,DataCriacao,Status,UsuarioId")] Doacao doacao)
        {
            if (id != doacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var doacaoDB = await _context.Doacoes.FirstOrDefaultAsync(d => d.Id == doacao.Id);
                    doacaoDB.Titulo = doacao.Titulo;
                    doacaoDB.Descricao = doacao.Descricao;
                    doacaoDB.Status = doacao.Status;
                    _context.Update(doacaoDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoacaoExists(doacao.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", doacao.UsuarioId);
            return View(doacao);
        }

        // GET: Doacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes
                .Include(d => d.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doacao == null)
            {
                return NotFound();
            }

            return View(doacao);
        }

        // POST: Doacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doacao = await _context.Doacoes.FindAsync(id);
            _context.Doacoes.Remove(doacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoacaoExists(int id)
        {
            return _context.Doacoes.Any(e => e.Id == id);
        }
    }
}
