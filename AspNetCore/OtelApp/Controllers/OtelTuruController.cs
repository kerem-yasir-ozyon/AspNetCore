using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtelApp.Data;
using OtelApp.Data.Entities;

namespace OtelApp.Controllers
{
    public class OtelTuruController : Controller
    {
        private readonly AppDbContext _context;

        public OtelTuruController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OtelTuru
        public async Task<IActionResult> Index()
        {
            return View(await _context.OtelTurus.ToListAsync());
        }

        // GET: OtelTuru/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otelTuru = await _context.OtelTurus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otelTuru == null)
            {
                return NotFound();
            }

            return View(otelTuru);
        }

        // GET: OtelTuru/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OtelTuru/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,IsActive")] OtelTuru otelTuru)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otelTuru);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(otelTuru);
        }

        // GET: OtelTuru/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otelTuru = await _context.OtelTurus.FindAsync(id);
            if (otelTuru == null)
            {
                return NotFound();
            }
            return View(otelTuru);
        }

        // POST: OtelTuru/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,IsActive")] OtelTuru otelTuru)
        {
            if (id != otelTuru.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(otelTuru);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtelTuruExists(otelTuru.Id))
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
            return View(otelTuru);
        }

        // GET: OtelTuru/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otelTuru = await _context.OtelTurus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otelTuru == null)
            {
                return NotFound();
            }

            return View(otelTuru);
        }

        // POST: OtelTuru/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otelTuru = await _context.OtelTurus.FindAsync(id);
            if (otelTuru != null)
            {
                _context.OtelTurus.Remove(otelTuru);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OtelTuruExists(int id)
        {
            return _context.OtelTurus.Any(e => e.Id == id);
        }
    }
}
