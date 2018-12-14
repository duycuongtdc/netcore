using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
  
    public class TrangChusController : Controller
    {
        private readonly MyDBContext _context;

        public TrangChusController(MyDBContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.loais.ToListAsync());
        }
       
        public async Task<IActionResult> Showsp(int? id, int page=1)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = _context.HangHoas
                .Where(m => m.MaLoai == id).AsNoTracking().OrderBy(p => p.TenHH);
            var model = await PagingList.CreateAsync(loai, 1, page);
            if (loai == null)
            {
                return NotFound();
            }

           
          
            return View(model);

        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.HangHoas
                .FirstOrDefaultAsync(m => m.MaHH == id);
            if (loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }
    }
}