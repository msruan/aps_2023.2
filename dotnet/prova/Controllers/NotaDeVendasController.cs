#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prova.Models;

namespace prova.Controllers
{
    public class NotaDeVendasController : Controller
    {
        private readonly MyDbContext _context;

        public NotaDeVendasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NotaDeVendas
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NotasDeVenda.Include(n => n.Cliente).Include(n => n.Transportadora).Include(n => n.Vendedor);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NotaDeVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
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

        // GET: NotaDeVendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId");
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "TransportadoraId", "TransportadoraId");
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "VendedorId", "VendedorId");
            return View();
        }

        // POST: NotaDeVendas/Create
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotaDeVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // POST: NotaDeVendas/Edit/5
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteId", notaDeVenda.ClienteId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "TransportadoraId", "TransportadoraId", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "VendedorId", "VendedorId", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotaDeVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
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

        // POST: NotaDeVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            _context.NotasDeVenda.Remove(notaDeVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaDeVendaExists(int id)
        {
            return _context.NotasDeVenda.Any(e => e.NotaDeVendaId == id);
        }
    }
}
