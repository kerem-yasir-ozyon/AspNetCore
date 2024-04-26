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
    public class SehirlerController : Controller
    {
        private readonly AppDbContext _context;

        public SehirlerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Sehirler
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Sehirler.Include(s => s.Ulke);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Sehirler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sehir = await _context.Sehirler
                .Include(s => s.Ulke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sehir == null)
            {
                return NotFound();
            }

            return View(sehir);
        }

        // GET: Sehirler/Create
        public IActionResult Create()
        {
            ViewData["UlkeId"] = new SelectList(_context.Ulkeler.Where(u =>u.IsActive == true).ToList(), "Id", "Name");
            return View();
        }

        // POST: Sehirler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,IsActive,UlkeId")] Sehir sehir)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sehir);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UlkeId"] = new SelectList(_context.Ulkeler.Where(u => u.IsActive == true).ToList(), "Id", "Name", sehir.UlkeId);
            return View(sehir);
        }

        // GET: Sehirler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sehir = await _context.Sehirler.FindAsync(id);
            if (sehir == null)
            {
                return NotFound();
            }
            ViewData["UlkeId"] = new SelectList(_context.Ulkeler.Where(u => u.IsActive == true).ToList(), "Id", "Name", sehir.UlkeId);
            return View(sehir);
        }

        // POST: Sehirler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,IsActive,UlkeId")] Sehir sehir)
        {
            if (id != sehir.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sehir);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SehirExists(sehir.Id))
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
            ViewData["UlkeId"] = new SelectList(_context.Ulkeler.Where(u => u.IsActive == true).ToList(), "Id", "Name", sehir.UlkeId);
            return View(sehir);
        }

        // GET: Sehirler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sehir = await _context.Sehirler
                .Include(s => s.Ulke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sehir == null)
            {
                return NotFound();
            }

            return View(sehir);
        }

        // POST: Sehirler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sehir = await _context.Sehirler.FindAsync(id);
            if (sehir != null)
            {
                _context.Sehirler.Remove(sehir);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SehirExists(int id)
        {
            return _context.Sehirler.Any(e => e.Id == id);
        }
    }
}
