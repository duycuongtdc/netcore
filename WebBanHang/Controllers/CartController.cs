using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBanHang.Models;
using WebBanHang.DAO;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WebBanHang.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {

        private readonly MyDBContext _context;
        
        public CartController(MyDBContext context)
        {
            _context = context;
        }
        [Route("index")]
        public async Task<IActionResult> Index()
        {
           
            var model = _context.loais.ToList();
            ViewBag.model = model;
            var cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            if(cart == null)
            {
                return View("View");
            }
            else
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => (item.Product.DonGia * item.Quantity)-((item.Product.GiamGia)*(item.Product.DonGia))/100);
            ViewBag.quantity = cart.Sum(item => item.Quantity);
            return View();
        }
        //public async Task<IActionResult> Details(int? id, int? id2, int page = 1)
        //{
        //    var model = _context.loais.ToList();
        //    ViewBag.model = model;
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var loai = await _context.HangHoas
        //        .FirstOrDefaultAsync(m => m.MaHH == id);
        //    var loai2 = _context.HangHoas
        //       .Where(m => m.MaLoai == id2).AsNoTracking().OrderByDescending(p => p.NgayDang);

        //    ViewBag.loai2 = loai2;
        //    var loai3 = _context.HangHoas
        //       .Where(m => m.MaLoai == id2).AsNoTracking().OrderBy(p => p.NgayDang);

        //    ViewBag.loai3 = loai3;
        //    if (loai == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(loai);
        //}

        [Route("buy/{id}")]
        public IActionResult Buy(int id,int soluong)
        {
            
            if (SessionHelper.Get<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = _context.HangHoas.Find(id), Quantity = 1 });
                
                SessionHelper.Set(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
                int index = Exists(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _context.HangHoas.Find(id), Quantity = 1 });
                }
                SessionHelper.Set(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(id);
            cart.RemoveAt(index);
            SessionHelper.Set(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int Exists(int id)
        {
            List<Item> cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.MaHH == id)
                {
                    return i;
                }
            }
            return -1;
        }

        //public JsonResult Update(string cartModel)
        //{
        //    var jsonCart = JsonConvert.DeserializeObject<List<Item>>(cartModel);
        //    var sessioncart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
        //    foreach (var item in sessioncart)
        //    {
        //        var jsonItem = jsonCart.Where(x => x.Product.MaHH == item.Product.MaHH).First();
        //        if (jsonItem != null)
        //        {
        //            item.Quantity = jsonItem.Quantity;
        //        }

        //    }
        //    SessionHelper.Set(HttpContext.Session, "cart", sessioncart);
        //    return Json(new
        //    {
        //        status = true
        //    });
        //}
        [HttpPost("a")]
        public IActionResult Update(IFormCollection fc)
        {
            string[] quantites = fc["quantity"];
            var cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            for(int i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = Convert.ToInt32(quantites[i]);
            }
            SessionHelper.Set(HttpContext.Session, "cart", cart);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteAll()
        {
            SessionHelper.Set(HttpContext.Session, "cart", "");
            return RedirectToAction("Index");
        }
        public int Insert(Oder oder)
        {
            _context.Oders.Add(oder);
            _context.SaveChanges();
            return oder.ID;
        }
        public bool Insert1(OderDetail detail)
        {
            try
            {
                _context.OderDetails.Add(detail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }

        }
        public bool Insert2(int id,HangHoa hangHoa)
        {
            try
            {
             var hh=   _context.HangHoas.Where(x => x.MaHH == id);
               
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }

        }
        [HttpGet, Authorize]
        public IActionResult ThanhToan()
        {
            var model = _context.loais.ToList();
            ViewBag.model = model;
            var cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                return View("View");
            }
            else
                ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.DonGia * item.Quantity);
            return View();
        }
        [HttpPost, Authorize]
        public IActionResult ThanhToan(string shipName, int mobile, string address, string email)
        {
            var oder = new Oder();
            oder.CreatedDate = DateTime.Now;
            oder.ShipName = shipName;
            oder.ShipAddress = address;
            oder.ShipMobile = mobile;
            oder.ShipEmail = email;

            try
            {
                var id = Insert(oder);
                var cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
                foreach (var item in cart)
                {
                    var oderDetail = new OderDetail();
                    oderDetail.MaHH = item.Product.MaHH;
                    oderDetail.OderID = id;
                    oderDetail.Gia = item.Product.DonGia;
                    oderDetail.Quantity = item.Quantity;
                    Insert1(oderDetail);

                    var hanghoas = _context.HangHoas.Where(x => x.MaHH == item.Product.MaHH).First();
                    
                   
                        hanghoas.DaMua += item.Quantity;
                        _context.Update(hanghoas);
                        _context.SaveChanges();
                    
                    
                   
                }
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
            SessionHelper.Set(HttpContext.Session, "cart", "");
            return View("HoanThanh");

        }
        public async Task< IActionResult> xemdonhang()
        {
            return View(await _context.loais.ToListAsync());
        }
    }
}