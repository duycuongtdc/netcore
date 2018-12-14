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
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly MyDBContext _context;

        public AdminController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
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
            var claims = new List<Claim> { new Claim(ClaimTypes.Name,kh.TenDangNhap) };
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
                return RedirectToAction("Index", "Home");//default
            }
        }//end Login POST
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("TenDangNhap");
            return RedirectToAction("Login");
        }


    }
}