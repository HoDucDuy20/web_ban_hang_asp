using _0306191405_HoDucDuy.Areas.Admin.Data;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        private readonly MinicsContext _context;

        public HomeController(MinicsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> DashboardAsync(int month)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login");
            }
            ViewData["Accounts"] = await _context.Accounts.Where(c => c.Status == true).ToListAsync();
            ViewData["Invoices"] = await _context.Invoices.ToListAsync();
            ViewData["InvoiceDetails"] = await _context.InvoiceDetails.Include(c=>c.Product).ToListAsync();
            ViewData["ProductTypes"] = await _context.ProductTypes.Where(c => c.Status == true).ToListAsync();
            //ViewData["Products"] = await _context.Products.Where(c => c.status == true).ToListAsync();
            if(month == 0)
            {
                month = 1;
            }
            ViewBag.month = month;
            DateTime now = DateTime.Now;            
            DateTime begin = new DateTime(now.Year, month, 01, 0, 0, 0);
            DateTime end = new DateTime(month == 12 ? now.Year + 1 : now.Year, month == 12 ? 1 : month + 1, 01, 0, 0, 0);
            ViewData["RevenueStatistics"] = await _context.Invoices.Include(c => c.Account).Where(c => c.Status == 3).Where(c => c.IssuedDate >= begin && c.IssuedDate < end).ToListAsync();
            var products = await _context.Products.Include(p => p.ProductType).Where(c => c.status == true).ToListAsync();
            ViewData["Products"] = products;

            //var produtGroup = products.GroupBy(x => x.ProductType.Name)
            //                .Select(x => new { productType = x.Key, numProduct = x.Count() });
            //ViewData["ProductGroup"] = produtGroup;

            //foreach (var item in produtGroup)
            //{
            //    System.Diagnostics.Debug.WriteLine($"Key: {item}");
            //    System.Diagnostics.Debug.WriteLine($"Key: {item.numProduct}");
            //}
            return View();
        }

        public IActionResult Login()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(string username, string password)
        {
            password = StringProcessing.MD5Encode(StringProcessing.Base64Encode(password));
            //password = StringProcessing.Encrypt(password);
            //password = StringProcessing.Decrypt(password);
            if (!String.IsNullOrEmpty(username))
            {
                var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Username == username);
                if (account.Password == password)
                {
                    if (account.IsAdmin && account.Status)
                    {
                        //Tạo cookie
                        CookieOptions opt = new CookieOptions();
                        opt.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Append("isAdmin", account.IsAdmin.ToString(), opt);
                        Response.Cookies.Append("status", account.Status.ToString(), opt);
                        Response.Cookies.Append("user", account.Username, opt);
                        HttpContext.Session.SetString("token", StringProcessing.Base64Encode(DateTime.Now.ToShortTimeString()));
                        ViewBag.Us = Request.Cookies["user"];
                        //Response.Cookies.Delete("user"); Xóa cookie
                        return RedirectToAction("Dashboard");
                    }
                    else
                    {
                        ViewBag.Result = false;
                        return View();
                    }
                }
                else
                {
                    ViewBag.Result = false;
                    return View();
                }
            }
            ViewBag.Result = false;
            return View();
        }

        public IActionResult LogOut()
        {
            Response.Cookies.Delete("user");
            Response.Cookies.Delete("isAdmin");
            Response.Cookies.Delete("status");

            return RedirectToAction("Login");
        }
    }
}
