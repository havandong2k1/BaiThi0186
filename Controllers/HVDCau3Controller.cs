using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThi0186.Models;
// using BaiThi0186.Models.Process;
using MvcMovie.Data;

namespace BaiThi0186.Controllers
{
    public class HVDCau3Controller : Controller
    {    
        private readonly MvcMovieContext _context;

        public HVDCau3Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: HVDCau3
        public async Task<IActionResult> Index()
        {
              return _context.HVDCau3 != null ? 
                          View(await _context.HVDCau3.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.HVDCau3'  is null.");
        }

        // GET: HVDCau3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HVDCau3 == null)
            {
                return NotFound();
            }

            var hVDCau3 = await _context.HVDCau3
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hVDCau3 == null)
            {
                return NotFound();
            }

            return View(hVDCau3);
        }

        // GET: HVDCau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HVDCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,HoVaTen,NgaySinh")] HVDCau3 hVDCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hVDCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hVDCau3);
        }

        // GET: HVDCau3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HVDCau3 == null)
            {
                return NotFound();
            }

            var hVDCau3 = await _context.HVDCau3.FindAsync(id);
            if (hVDCau3 == null)
            {
                return NotFound();
            }
            return View(hVDCau3);
        }

        // POST: HVDCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("ID,HoVaTen,NgaySinh")] HVDCau3 hVDCau3)
        {
            if (id != hVDCau3.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hVDCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HVDCau3Exists(hVDCau3.ID))
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
            return View(hVDCau3);
        }

        // GET: HVDCau3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HVDCau3 == null)
            {
                return NotFound();
            }

            var hVDCau3 = await _context.HVDCau3
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hVDCau3 == null)
            {
                return NotFound();
            }

            return View(hVDCau3);
        }

        // POST: HVDCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.HVDCau3 == null)
            {
                return Problem("Entity set 'MvcMovieContext.HVDCau3'  is null.");
            }
            var hVDCau3 = await _context.HVDCau3.FindAsync(id);
            if (hVDCau3 != null)
            {
                _context.HVDCau3.Remove(hVDCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HVDCau3Exists(int? id)
        {
          return (_context.HVDCau3?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
