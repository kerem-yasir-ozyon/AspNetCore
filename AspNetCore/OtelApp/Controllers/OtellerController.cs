using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtelApp.Data;
using OtelApp.Data.Entities;
using OtelApp.Library;

namespace OtelApp.Controllers
{
    public class OtellerController : Controller
    {
        private readonly AppDbContext _context;
        private SelectBoxCustom selectBoxCustom;

        public OtellerController(AppDbContext context)
        {
            _context = context;
            selectBoxCustom = new SelectBoxCustom(context);
        }

        // GET: Oteller
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Otels.Include(o => o.OtelTuru).Include(o => o.Sehir).Include(o => o.Ulke);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Oteller/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otel = await _context.Otels
                .Include(o => o.OtelTuru)
                .Include(o => o.Sehir)
                .Include(o => o.Ulke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otel == null)
            {
                return NotFound();
            }

            return View(otel);
        }

        // GET: Oteller/Create
        public IActionResult Create()
        {
            ViewData["OtelTuruId"] = selectBoxCustom.OtelTuruList();
            ViewData["SehirId"] = selectBoxCustom.SehirList();
            ViewData["UlkeId"] = selectBoxCustom.UlkeList();
            return View();
        }

        // POST: Oteller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Adi,Aciklama,OtelTuruId,YildizSayisi,Adres,UlkeId,SehirId,Telefon,Email,Logo")] Otel otel, IFormFile logoFile)
        {
            ModelState.Remove("OtelTuru");
            ModelState.Remove("Ulke");
            ModelState.Remove("Sehir");
            ModelState.Remove("OtelKapasiteler");

            if (ModelState.IsValid)
            {
                var extent = Path.GetExtension(logoFile.FileName); // .jpeg / .png / .*
                var dumyName = Guid.NewGuid().ToString();
                dumyName += extent;

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images", dumyName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await logoFile.CopyToAsync(stream);
                }

                otel.Logo = "/images/" + dumyName;
             
                _context.Add(otel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OtelTuruId"] = selectBoxCustom.OtelTuruList(otel.OtelTuruId);
            ViewData["SehirId"] = selectBoxCustom.SehirList(otel.SehirId);
            ViewData["UlkeId"] = selectBoxCustom.UlkeList(otel.UlkeId);
            return View(otel);
        }

        // GET: Oteller/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otel = await _context.Otels.FindAsync(id);
            if (otel == null)
            {
                return NotFound();
            }
            ViewData["OtelTuruId"] = selectBoxCustom.OtelTuruList(otel.OtelTuruId);
            ViewData["SehirId"] = selectBoxCustom.SehirList(otel.SehirId);
            ViewData["UlkeId"] = selectBoxCustom.UlkeList(otel.UlkeId);
            return View(otel);
        }

        // POST: Oteller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Adi,Aciklama,OtelTuruId,YildizSayisi,Adres,UlkeId,SehirId,Telefon,Email,Logo")] Otel otel)
        {
            if (id != otel.Id)
            {
                return NotFound();
            }

            ModelState.Remove("OtelTuru");
            ModelState.Remove("Ulke");
            ModelState.Remove("Sehir");
            ModelState.Remove("OtelKapasiteler");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(otel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtelExists(otel.Id))
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
            ViewData["OtelTuruId"] = selectBoxCustom.OtelTuruList(otel.OtelTuruId);
            ViewData["SehirId"] = selectBoxCustom.SehirList(otel.SehirId);
            ViewData["UlkeId"] = selectBoxCustom.UlkeList(otel.UlkeId);
            return View(otel);
        }

        // GET: Oteller/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otel = await _context.Otels
                .Include(o => o.OtelTuru)
                .Include(o => o.Sehir)
                .Include(o => o.Ulke)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otel == null)
            {
                return NotFound();
            }

            return View(otel);
        }

        // POST: Oteller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otel = await _context.Otels.FindAsync(id);
            if (otel != null)
            {
                _context.Otels.Remove(otel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OtelExists(int id)
        {
            return _context.Otels.Any(e => e.Id == id);
        }
    }
}
