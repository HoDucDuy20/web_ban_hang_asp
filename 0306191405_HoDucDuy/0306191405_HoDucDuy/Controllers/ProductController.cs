using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace _0306191405_HoDucDuy.Controllers
{
    public class ProductController : Controller
    {
        private readonly MinicsContext _context;

        public ProductController(MinicsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ProductAsync(int? page, string name, int type)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            //var produtGroup = _context.Rates.GroupBy(x => x.ProductId)
            //                .Select(x => new { id = x.Key, star = x.Count() });

        
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.Product = "active";
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes.Where(c => c.Status == true), "Id", "Name", type);    
            ViewData["Rates"] = await _context.Rates.ToListAsync();
            ViewBag.type = type;
            ViewBag.search = name;
            if (type != 0)
            {
                if (name != null)
                {
                    return View(_context.Products.Where(c => c.Name.Contains(name)).Where(c => c.ProductTypeId == type).Where(c => c.status == true).OrderByDescending(s => s.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 9));
                }
                return View(_context.Products.Where(c => c.ProductTypeId == type).Where(c => c.status == true).OrderByDescending(s => s.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 9));
            }
            if (name != null)
            {
                return View(_context.Products.Where(c=>c.Name.Contains(name)).Where(c => c.status == true).OrderByDescending(s => s.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 9));
            }            
            return View(_context.Products.Where(c => c.status == true).OrderByDescending(s => s.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 9));
        }

        public async Task<IActionResult> DetailAsync(int? page, int? id)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.Product = "active";
            ViewData["Rates"] = await _context.Rates.ToListAsync();
            ViewData["RatesById"] = _context.Rates.Include(c => c.Account).Where(c => c.ProductId == id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 5);
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["id"] = Request.Cookies["id"];
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
               .Include(p => p.ProductType)
               .FirstOrDefaultAsync(m => m.Id == id);
            ViewData["Products"] = await _context.Products.Where(c => c.status == true).Where(c => c.ProductTypeId == product.ProductTypeId).OrderByDescending(s => s.Id).ToListAsync();
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddRate(int ProductId, int Star, string Descrition)
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
                Rate rate_new = new Rate();
                rate_new.AccountId = int.Parse(Request.Cookies["id"]);
                rate_new.ProductId = ProductId;
                rate_new.Star = Star;
                rate_new.Description = Descrition;
                rate_new.Time = DateTime.Now;
                _context.Add(rate_new);
                await _context.SaveChangesAsync();
                return RedirectToAction("detail", new { id = ProductId });
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
