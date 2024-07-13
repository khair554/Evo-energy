using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webdev_consultationPhotovoltaique.Models.photovoltaiqueDB;

namespace webdev_consultationPhotovoltaique.Controllers
{
    public class produitsController : Controller
    {
        private readonly PhotovoltaiqueDbContext _context;

        public produitsController(PhotovoltaiqueDbContext context)
        {
            _context = context;
        }

        // GET: produits
        public async Task<IActionResult> Index()
        {
            var photovoltaiqueDbContext = _context.produits.Include(p => p.Entreprise);
            return View(await photovoltaiqueDbContext.ToListAsync());
        }
        public IActionResult produitView()
        {
            return View();
        }
        public IActionResult listeproduit()
        {
            return View();
        }

        // GET: produits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = await _context.produits
                .Include(p => p.Entreprise)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        // GET: produits/Create
        public IActionResult Create()
        {
            ViewData["EntrepriseId"] = new SelectList(_context.Entreprises, "Id", "Adresse");
            return View();
        }

        // POST: produits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntrepriseId,Id,type,Description,MotDePasse,Logo")] produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EntrepriseId"] = new SelectList(_context.Entreprises, "Id", "Adresse", produit.EntrepriseId);
            return View(produit);
        }

        // GET: produits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = await _context.produits.FindAsync(id);
            if (produit == null)
            {
                return NotFound();
            }
            ViewData["EntrepriseId"] = new SelectList(_context.Entreprises, "Id", "Adresse", produit.EntrepriseId);
            return View(produit);
        }

        // POST: produits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntrepriseId,Id,type,Description,MotDePasse,Logo")] produit produit)
        {
            if (id != produit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!produitExists(produit.Id))
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
            ViewData["EntrepriseId"] = new SelectList(_context.Entreprises, "Id", "Adresse", produit.EntrepriseId);
            return View(produit);
        }

        // GET: produits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = await _context.produits
                .Include(p => p.Entreprise)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        // POST: produits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produit = await _context.produits.FindAsync(id);
            if (produit != null)
            {
                _context.produits.Remove(produit);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool produitExists(int id)
        {
            return _context.produits.Any(e => e.Id == id);
        }
    }
}
