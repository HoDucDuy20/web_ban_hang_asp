using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Controllers
{
    public class CartController : Controller
    {
        private readonly MinicsContext _context;

        public CartController(MinicsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CartAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            var cart = from m in _context.Carts.Include(p => p.Product).OrderByDescending(p => p.Id) where m.AccountId == int.Parse(Request.Cookies["id"]) select m;

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();


            return View(await cart.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddCart(int id, int? quantity)
        {

            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];
            try
            {
                var cart_lst = from m in _context.Carts where m.AccountId == int.Parse(Request.Cookies["id"]) select m;
                if (cart_lst.Count() != 0)
                {
                    Cart cart = new Cart();
                    cart = await _context.Carts.FirstOrDefaultAsync(m => m.ProductId == id);
                    if (cart != null)
                    {
                        try
                        {
                            if (quantity.HasValue)
                            {
                                cart.Quantity += quantity.Value;
                            }
                            else
                            {
                                cart.Quantity += 1;
                            }
                            _context.Update(cart);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!CartExists(cart.Id))
                            {
                                return NotFound();
                            }
                            else
                            {
                                throw;
                            }
                        }
                        return RedirectToAction("Cart");
                    }
                }
                Cart cart_new = new Cart();
                cart_new.ProductId = id;
                if (quantity.HasValue)
                {
                    cart_new.Quantity = quantity.Value;
                }
                else
                {
                    cart_new.Quantity = 1;
                }
                cart_new.AccountId = int.Parse(Request.Cookies["id"]);
                _context.Add(cart_new);
                await _context.SaveChangesAsync();
                return RedirectToAction("Cart");
            }
            catch
            {
                return NotFound();
            }
        }
        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }

        //[HttpPost, ActionName("RemoveCart")]
        public async Task<IActionResult> RemoveCart(int id)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> CheckOutAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            var cart = from m in _context.Carts.Include(p => p.Product) where m.AccountId == int.Parse(Request.Cookies["id"]) select m;

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["Accounts"] = await _context.Accounts.ToListAsync();

            return View(await cart.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CheckOutAsync(string phone, string address, int total)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            //code random
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var code = new String(stringChars);

            //Lưu hoá đơn
            if (ModelState.IsValid)
            {
                Invoice invoice_add = new Invoice();
                invoice_add.Code = code;
                invoice_add.IssuedDate = DateTime.Now;
                invoice_add.ShippingPhone = phone;
                invoice_add.ShippingAddress = address;
                invoice_add.Total = total;
                invoice_add.AccountId = int.Parse(Request.Cookies["id"]);
                invoice_add.Status = 1;
                _context.Add(invoice_add);
                await _context.SaveChangesAsync();
            }
            var invoices = from m in _context.Invoices where m.AccountId == int.Parse(Request.Cookies["id"]) select m;
            invoices = invoices.OrderByDescending(s => s.IssuedDate);
            Invoice invoice = new Invoice();
            foreach (var item in invoices)
            {
                invoice = item;
                break;
            }
            //Lưu chi tiết hoá đơn
            var cart = from m in _context.Carts.Include(p => p.Product) where m.AccountId == int.Parse(Request.Cookies["id"]) select m;
            foreach (var item in cart)
            {
                InvoiceDetail invoiceDetail = new InvoiceDetail();
                invoiceDetail.InvoiceId = invoice.Id;
                invoiceDetail.ProductId = item.ProductId;
                invoiceDetail.Quantity = item.Quantity;
                invoiceDetail.UnitPrice = (item.Product.Price * item.Quantity);
                _context.Add(invoiceDetail);
            }
            await _context.SaveChangesAsync();

            //Xoá giỏ hàng
            foreach (var item in cart)
            {
                _context.Carts.Remove(item);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction("Order", "User");
        }

        public async Task<IActionResult> PlusCart(int id)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            var cart = await _context.Carts.FindAsync(id);
            cart.Quantity++;
            _context.Update(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> MinusCart(int id)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Us = Request.Cookies["user"];

            var cart = await _context.Carts.FindAsync(id);
            if (cart.Quantity > 1)
            {
                cart.Quantity--;
                _context.Update(cart);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Cart");
        }
    }
}
