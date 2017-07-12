using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using darlenyWebApp.Data;
using darlenyWebApp.Models;
using darlenyWebApp.Models.WebApp;

namespace darlenyWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Product.Include(p => p.Offer).Include(p => p.UnitMeasure);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Offer)
                .Include(p => p.UnitMeasure)
                .SingleOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            ViewData["OfferID"] = new SelectList(_context.Set<Offer>(), "OfferID", "OfferPercent");
            ViewData["UnitMeasureID"] = new SelectList(_context.Set<UnitMeasure>(), "UnitMeasureID", "Description");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["OfferID"] = new SelectList(_context.Set<Offer>(), "OfferID", "OfferPercent", product.OfferID);
            ViewData["UnitMeasureID"] = new SelectList(_context.Set<UnitMeasure>(), "UnitMeasureID", "Description", product.UnitMeasureID);
            return View(product);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.SingleOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["OfferID"] = new SelectList(_context.Set<Offer>(), "OfferID", "OfferPercent", product.OfferID);
            ViewData["UnitMeasureID"] = new SelectList(_context.Set<UnitMeasure>(), "UnitMeasureID", "Description", product.UnitMeasureID);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["OfferID"] = new SelectList(_context.Set<Offer>(), "OfferID", "OfferPercent", product.OfferID);
            ViewData["UnitMeasureID"] = new SelectList(_context.Set<UnitMeasure>(), "UnitMeasureID", "Description", product.UnitMeasureID);
            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Offer)
                .Include(p => p.UnitMeasure)
                .SingleOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.SingleOrDefaultAsync(m => m.ProductID == id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
