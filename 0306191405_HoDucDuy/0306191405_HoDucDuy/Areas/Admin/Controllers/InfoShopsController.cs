using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InfoShopsController : Controller
    {
        private readonly MinicsContext _context;

        public InfoShopsController(MinicsContext context)
        {
            _context = context;
        }

        // GET: Admin/InfoShops
        public async Task<IActionResult> Index(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if(id == null)
            {
                var infoShop = await _context.InfoShops.FirstOrDefaultAsync();
                if (infoShop == null)
                {
                    return NotFound();
                }
                ViewData["InfoShops"] = infoShop;
                ViewData["id"] = id;
                return View();
            }
            else
            {
                var infoShop = await _context.InfoShops.FirstOrDefaultAsync();
                if (infoShop == null)
                {
                    return NotFound();
                }
                ViewData["InfoShops"] = infoShop;
                ViewData["id"] = id;
                return View(await _context.InfoShops.FirstOrDefaultAsync(c => c.Id == id));
            }            
        }

        // GET: Admin/InfoShops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var infoShop = await _context.InfoShops.FindAsync(id);
            if (infoShop == null)
            {
                return NotFound();
            }
            return View(infoShop);
        }

        // POST: Admin/InfoShops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Phone,Address,Info,Facebook,Instagram,Twitter,Youtube")] InfoShop infoShop)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != infoShop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoShop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoShopExists(infoShop.Id))
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
            return View(infoShop);
        }

        private bool InfoShopExists(int id)
        {
            return _context.InfoShops.Any(e => e.Id == id);
        }
    }
}
