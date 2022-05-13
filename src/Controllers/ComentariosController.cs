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
    public class ComentariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComentariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comentarios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Comentarios.Include(c => c.Doacao).Include(c => c.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Comentarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentarios
                .Include(c => c.Doacao)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // GET: Comentarios/Create
        public IActionResult Create()
        {
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Comentarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DoacaoId,UsuarioId,Texto,Data")] Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", comentario.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", comentario.UsuarioId);
            return View(comentario);
        }

        // GET: Comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentarios.FindAsync(id);
            if (comentario == null)
            {
                return NotFound();
            }
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", comentario.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", comentario.UsuarioId);
            return View(comentario);
        }

        // POST: Comentarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DoacaoId,UsuarioId,Texto,Data")] Comentario comentario)
        {
            if (id != comentario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentarioExists(comentario.Id))
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
            ViewData["DoacaoId"] = new SelectList(_context.Doacoes, "Id", "Descricao", comentario.DoacaoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", comentario.UsuarioId);
            return View(comentario);
        }

        // POST: DoacoesItens/Doar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateComentario(string Texto, int DoacaoId)
        {
            //if (DoacaoId == null)
            //{
            //    return NotFound();
            //}

            if (Texto == null || Texto.Length == 0)
            {
                return NotFound();
            }

            var doacao = await _context.Doacoes.FindAsync(DoacaoId);
            if (doacao == null)
            {
                return NotFound();
            }

            Usuario usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (usuario == null)
            {
                return NotFound();
            }
            Comentario comentario = new Comentario();
            comentario.UsuarioId = usuario.Id;
            comentario.Usuario = usuario;
            comentario.DoacaoId = DoacaoId;
            comentario.Doacao = doacao;
            comentario.Texto = Texto;
            comentario.Data = DateTime.Now;

            if (ModelState.IsValid)
            {

                _context.Add(comentario);
                await _context.SaveChangesAsync();
            }
            
            return RedirectToAction("Details", "Doacoes", new { id = comentario.DoacaoId });
        }

        // GET: Comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentarios
                .Include(c => c.Doacao)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // POST: Comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comentario = await _context.Comentarios.FindAsync(id);
            _context.Comentarios.Remove(comentario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComentarioExists(int id)
        {
            return _context.Comentarios.Any(e => e.Id == id);
        }
    }
}
