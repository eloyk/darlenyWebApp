using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using darlenyWebApp.Data;
using darlenyWebApp.Models.WebApp;

namespace darlenyWebApp.Controllers
{
    public class UnitMeasuresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UnitMeasuresController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: UnitMeasures
        public async Task<IActionResult> Index()
        {
            return View(await _context.UnitMeasure.ToListAsync());
        }

        // GET: UnitMeasures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitMeasure = await _context.UnitMeasure
                .SingleOrDefaultAsync(m => m.UnitMeasureID == id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            return View(unitMeasure);
        }

        // GET: UnitMeasures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnitMeasures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnitMeasureID,Description,Acron")] UnitMeasure unitMeasure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unitMeasure);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(unitMeasure);
        }

        // GET: UnitMeasures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitMeasure = await _context.UnitMeasure.SingleOrDefaultAsync(m => m.UnitMeasureID == id);
            if (unitMeasure == null)
            {
                return NotFound();
            }
            return View(unitMeasure);
        }

        // POST: UnitMeasures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnitMeasureID,Description,Acron")] UnitMeasure unitMeasure)
        {
            if (id != unitMeasure.UnitMeasureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unitMeasure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnitMeasureExists(unitMeasure.UnitMeasureID))
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
            return View(unitMeasure);
        }

        // GET: UnitMeasures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitMeasure = await _context.UnitMeasure
                .SingleOrDefaultAsync(m => m.UnitMeasureID == id);
            if (unitMeasure == null)
            {
                return NotFound();
            }

            return View(unitMeasure);
        }

        // POST: UnitMeasures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unitMeasure = await _context.UnitMeasure.SingleOrDefaultAsync(m => m.UnitMeasureID == id);
            _context.UnitMeasure.Remove(unitMeasure);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool UnitMeasureExists(int id)
        {
            return _context.UnitMeasure.Any(e => e.UnitMeasureID == id);
        }
    }
}
