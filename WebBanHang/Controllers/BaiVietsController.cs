using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class BaiVietsController : Controller
    {
        private readonly MyDBContext _context;

        public BaiVietsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: BaiViets
        public async Task<IActionResult> Index()
        {
            return View(await _context.BaiViet.ToListAsync());
        }

        // GET: BaiViets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiViet = await _context.BaiViet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (baiViet == null)
            {
                return NotFound();
            }

            return View(baiViet);
        }

        // GET: BaiViets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BaiViets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NoiDung,MaLoai")] BaiViet baiViet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baiViet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(baiViet);
        }

        // GET: BaiViets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiViet = await _context.BaiViet.FindAsync(id);
            if (baiViet == null)
            {
                return NotFound();
            }
            return View(baiViet);
        }

        // POST: BaiViets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NoiDung,MaLoai")] BaiViet baiViet)
        {
            if (id != baiViet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baiViet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaiVietExists(baiViet.ID))
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
            return View(baiViet);
        }

        // GET: BaiViets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiViet = await _context.BaiViet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (baiViet == null)
            {
                return NotFound();
            }

            return View(baiViet);
        }

        // POST: BaiViets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var baiViet = await _context.BaiViet.FindAsync(id);
            _context.BaiViet.Remove(baiViet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaiVietExists(int id)
        {
            return _context.BaiViet.Any(e => e.ID == id);
        }
    }
}
