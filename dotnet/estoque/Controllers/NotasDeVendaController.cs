#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using estoque.Models;

namespace estoque.Controllers
{
    public class NotasDeVendaController : Controller
    {
        private readonly MyDbContext _context;

        public NotasDeVendaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NotasDeVenda
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NotaDeVenda.Include(n => n.Cliente).Include(n => n.Transportadora).Include(n => n.Vendedor);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NotasDeVenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotaDeVenda
                .Include(n => n.Cliente)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.NotaDeVendaId == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId");
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadora, "TransportadoraId", "TransportadoraId");
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "VendedorId");
            return View();
        }

        // POST: NotasDeVenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NotaDeVendaId,Data,Tipo,ClienteId,VendedorId,TransportadoraId")] NotaDeVenda notaDeVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notaDeVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadora, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotaDeVenda.FindAsync(id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadora, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NotaDeVendaId,Data,Tipo,ClienteId,VendedorId,TransportadoraId")] NotaDeVenda notaDeVenda)
        {
            if (id != notaDeVenda.NotaDeVendaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaDeVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaDeVendaExists(notaDeVenda.NotaDeVendaId))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadora, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedor, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotaDeVenda
                .Include(n => n.Cliente)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.NotaDeVendaId == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaDeVenda = await _context.NotaDeVenda.FindAsync(id);
            _context.NotaDeVenda.Remove(notaDeVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaDeVendaExists(int id)
        {
            return _context.NotaDeVenda.Any(e => e.NotaDeVendaId == id);
        }
    }
}
