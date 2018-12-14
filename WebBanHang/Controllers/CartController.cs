using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBanHang.Models;

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
        public IActionResult Index()
        {
            var cart = SessionHelper.Get<List<Item>>(HttpContext.Session, "cart");
            if(cart == null)
            {
                return NotFound();
            }
            else
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.DonGia * item.Quantity);
            return View();
        }

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

    }
}