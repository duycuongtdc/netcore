using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using WebBanHang.Models;
using WebBanHang.ViewModels;
namespace WebBanHang.Controllers
{
  
    public class TrangChusController : Controller
    {
        private readonly MyDBContext _context;

        public TrangChusController(MyDBContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index(int page=1)
        {
            var query = _context.HangHoas.AsNoTracking().OrderByDescending(p => p.NgayDang);
            var models = await PagingList.CreateAsync(query, 4, page);
            var model = _context.loais.ToList();
            ViewBag.model = model;
            var model2 = _context.HangHoas.Where(m => m.NoiBat == true);
            ViewBag.model2 = model2;
            var model3 = _context.HangHoas.AsNoTracking().OrderByDescending(p => p.DaMua);
            var model3s = await PagingList.CreateAsync(model3, 4, page);
            ViewBag.model3s = model3s;
           
            return View(models);
        }

       public async Task<IActionResult> showbaiviet()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;

            var loai = _context.BaiViet.ToList();
                

            return View(loai);
        }
        public async Task<IActionResult> GioiThieu()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;

           


            return View();
        }
        public async Task<IActionResult> DieuKhoan()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;




            return View();
        }
        public async Task<IActionResult> ChinhSach()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;




            return View();
        }
        public async Task<IActionResult> Contact()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;




            return View();
        }
        public async Task<IActionResult> Showsp(int? id)
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
           
            var loai = _context.HangHoas
                .Where(m => m.MaLoai == id).AsNoTracking().OrderBy(p => p.TenHH);
      
         

           
          
            return View(loai);

        }

        public async Task<IActionResult> Details(int? id,int?id2,int page=1)
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.HangHoas
                .FirstOrDefaultAsync(m => m.MaHH == id);
            var loai2 =  _context.HangHoas
               .Where(m => m.MaLoai == id2).AsNoTracking().OrderByDescending(p => p.NgayDang);
            var loai2s = await PagingList.CreateAsync(loai2, 6, page);
            ViewBag.loai2s = loai2s ;
            var loai3 = _context.HangHoas
               .Where(m => m.MaLoai == id2).AsNoTracking().OrderBy(p => p.NgayDang);
            var loai3s = await PagingList.CreateAsync(loai3, 5, page);
            ViewBag.loai3s = loai3s;


            var loai4 = _context.BaiViet
              .Where(m => m.MaLoai == id2).AsNoTracking().OrderBy(p => p.ID);
            var loai4s = await PagingList.CreateAsync(loai4, 3, page);
            ViewBag.loai4s = loai4s;

            if (loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }
        

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact([Bind("ID,Name,Email,Phone,NoiDung")] Contact contact)
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        public async Task<IActionResult> XemBaiViet(int? id,int? id2,int page=1)
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
            var loai3 = _context.HangHoas
             .Where(m => m.MaLoai == id2).AsNoTracking().OrderBy(p => p.NgayDang);
            var loai3s = await PagingList.CreateAsync(loai3, 5, page);
            ViewBag.loai3s = loai3s;


            var loai4 = _context.BaiViet
              .Where(m => m.MaLoai == id2).AsNoTracking().OrderBy(p => p.ID);
            var loai4s = await PagingList.CreateAsync(loai4, 3, page);
            ViewBag.loai4s = loai4s;
           
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.BaiViet
                .FirstOrDefaultAsync(m => m.ID == id);
            
         
            if (loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }

        public IActionResult Search(string Keyword = "")
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
            var data = _context.HangHoas.Where(p => p.TenHH.Contains(Keyword))
          .Include(p => p.Loai)
            .ToList();
            return View(data);
        }
        public IActionResult JSONSearch(string Name = "", double? From = 0,
        double? To = double.MaxValue)
        {
            var data = _context.HangHoas.Where(p => p.TenHH.Contains(Name) &&
           p.DonGia >= From && p.DonGia <= To)
            .Select(p => new {
                TenHH = p.TenHH,
                DonGia = p.DonGia,
                Loai = p.Loai.TenLoai,
                Hinh = p.Hinh
            
            });
            return Json(data);
        }
        public IActionResult TimKiem()
        {

            var model = _context.loais.ToList();
            ViewBag.model = model;
            return View();
        }
        public List<ProductViewmodels> list(int id)
        {
            var model = from a in _context.HangHoas
                        join b in _context.loais
                        on a.MaLoai equals b.MaLoai
                        where a.MaLoai == id
                        select new ProductViewmodels()
                        {
                            MaHH = a.MaHH,
                            TenHH = a.TenHH,
                            Hinh = a.Hinh,
                            NgayDang = a.NgayDang,
                            MaLoai = b.MaLoai,
                            SoLuong = a.SoLuong,
                            DonGia = a.DonGia,
                        };
            return model.ToList();
                        
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Login()
        {
            ViewBag.ReturnUrl = HttpContext.Request.Query["ReturnUrl"].ToString();
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Taikhoan()
        {
            return View(await _context.TaiKhoans.ToListAsync());
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            var urlReturn =
           HttpContext.Request.Query["ReturnUrl"].ToString();
            ViewBag.ReturnUrl = urlReturn;
            TaiKhoan kh = _context.TaiKhoans.SingleOrDefault(p => p.TenDangNhap
           == loginModel.UserName && p.MatKhau == loginModel.Password);
            if (kh == null)//không khớp
            {
                ViewBag.ThongBaoLoi = "Sai thông tin đăng nhập";
                return View();
            }

            //ghi nhận đăng nhập thành công
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, kh.TenDangNhap) };
            // create identity
            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            //Gán session
            HttpContext.Session.SetString("MaTK", kh.MaTK);
            //Lấy lại trang yêu cầu (nếu có)
            if (Url.IsLocalUrl(urlReturn))
            {
                return Redirect(urlReturn);
            }
            else
            {
                return RedirectToAction("Index", "TrangChus");//default
            }
        }//end Login POST
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("TenDangNhap");
            return RedirectToAction("Login");
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTK,TenDangNhap,MatKhau")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taiKhoan);
        }

    }
}