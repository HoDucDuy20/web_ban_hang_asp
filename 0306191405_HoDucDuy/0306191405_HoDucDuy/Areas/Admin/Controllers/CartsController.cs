﻿using System;
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
    public class CartsController : Controller
    {
        private readonly MinicsContext _context;

        public CartsController(MinicsContext context)
        {
            _context = context;
        }

        // GET: Admin/Carts
        public async Task<IActionResult> Index()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var minicsContext = _context.Carts.Include(c => c.Account).Include(c => c.Product);
            return View(await minicsContext.ToListAsync());
        }

        // GET: Admin/Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Admin/Carts/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        // POST: Admin/Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // GET: Admin/Carts/Edit/5
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

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // POST: Admin/Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Address", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", cart.ProductId);
            return View(cart);
        }

        // GET: Admin/Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Admin/Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
    }
}
