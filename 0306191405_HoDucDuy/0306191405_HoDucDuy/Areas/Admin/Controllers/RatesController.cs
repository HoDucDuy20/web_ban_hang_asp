using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using X.PagedList;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RatesController : Controller
    {
        private readonly MinicsContext _context;

        public RatesController(MinicsContext context)
        {
            _context = context;
        }

        // GET: Admin/Rates
        public async Task<IActionResult> Index(int? page, string name, int star)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.search = name;
            ViewBag.star = star;

            if (star == 0)
            {
                if (name != null)
                {
                    return View(_context.Rates.Include(c => c.Account).Include(c => c.Product).Where(c => c.Product.Name.Contains(name)).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View(_context.Rates.Include(c => c.Account).Include(c => c.Product).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            else
            {
                if (name != null)
                {
                    return View(_context.Rates.Include(c => c.Account).Include(c => c.Product).Where(c => c.Product.Name.Contains(name)).Where(c => c.Star == star).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View(_context.Rates.Include(c => c.Account).Include(c => c.Product).Where(c => c.Star == star).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
        }

        //public async Task<IActionResult> Index(int? page)
        //{
        //    var minicsContext = _context.Rates.Include(r => r.Account).Include(r => r.Product).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10);
        //    return View(minicsContext);
        //}

        // GET: Admin/Rates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rate = await _context.Rates
                .Include(r => r.Account)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rate == null)
            {
                return NotFound();
            }

            return View(rate);
        }

        // GET: Admin/Rates/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        // POST: Admin/Rates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,ProductId,Star,Description,Time")] Rate rate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", rate.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", rate.ProductId);
            return View(rate);
        }

        // GET: Admin/Rates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rate = await _context.Rates.FindAsync(id);
            if (rate == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", rate.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", rate.ProductId);
            return View(rate);
        }

        // POST: Admin/Rates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,ProductId,Star,Description,Time")] Rate rate)
        {
            if (id != rate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RateExists(rate.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", rate.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", rate.ProductId);
            return View(rate);
        }

        // GET: Admin/Rates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rate = await _context.Rates
                .Include(r => r.Account)
                .Include(r => r.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rate == null)
            {
                return NotFound();
            }

            return View(rate);
        }

        // POST: Admin/Rates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rate = await _context.Rates.FindAsync(id);
            _context.Rates.Remove(rate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RateExists(int id)
        {
            return _context.Rates.Any(e => e.Id == id);
        }
    }
}
