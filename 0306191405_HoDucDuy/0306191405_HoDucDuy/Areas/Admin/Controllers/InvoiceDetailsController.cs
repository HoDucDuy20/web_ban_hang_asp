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
    public class InvoiceDetailsController : Controller
    {
        private readonly MinicsContext _context;

        public InvoiceDetailsController(MinicsContext context)
        {
            _context = context;
        }

        // GET: Admin/InvoiceDetails
        public async Task<IActionResult> Index(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            //var minicsContext = _context.InvoiceDetails.Include(i => i.Invoice).Include(i => i.Product);
            //return View(await minicsContext.ToListAsync());
            if (id == null)
            {
                return NotFound();
            }

            var invoiceDetail = from m in _context.InvoiceDetails.Include(i => i.Product).Include(i => i.Invoice) where m.InvoiceId == id select m;
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            ViewData["Invoices"] = await _context.Invoices.Include(i => i.Account).FirstOrDefaultAsync(m => m.Id == invoiceDetail.First().InvoiceId);

            return View(await invoiceDetail.ToListAsync());
        }

        // GET: Admin/InvoiceDetails/Details/5
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

            var invoiceDetail = await _context.InvoiceDetails
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            return View(invoiceDetail);
        }

        // GET: Admin/InvoiceDetails/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Code");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description");
            return View();
        }

        // POST: Admin/InvoiceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InvoiceId,ProductId,Quantity,UnitPrice")] InvoiceDetail invoiceDetail)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.Add(invoiceDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Code", invoiceDetail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", invoiceDetail.ProductId);
            return View(invoiceDetail);
        }

        // GET: Admin/InvoiceDetails/Edit/5
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

            var invoiceDetail = await _context.InvoiceDetails.FindAsync(id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Code", invoiceDetail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", invoiceDetail.ProductId);
            return View(invoiceDetail);
        }

        // POST: Admin/InvoiceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InvoiceId,ProductId,Quantity,UnitPrice")] InvoiceDetail invoiceDetail)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != invoiceDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceDetailExists(invoiceDetail.Id))
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
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Code", invoiceDetail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Description", invoiceDetail.ProductId);
            return View(invoiceDetail);
        }

        // GET: Admin/InvoiceDetails/Delete/5
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

            var invoiceDetail = await _context.InvoiceDetails
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            return View(invoiceDetail);
        }

        // POST: Admin/InvoiceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var invoiceDetail = await _context.InvoiceDetails.FindAsync(id);
            _context.InvoiceDetails.Remove(invoiceDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceDetailExists(int id)
        {
            return _context.InvoiceDetails.Any(e => e.Id == id);
        }

        public async Task<IActionResult> CancelAsync(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }
            var invoice = await _context.Invoices.Include(i => i.Account).FirstOrDefaultAsync(m => m.Id == id);

            invoice.Status = 0;
            _context.Update(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = id });
        }

        public async Task<IActionResult> DeliveringAsync(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }
            var invoice = await _context.Invoices.Include(i => i.Account).FirstOrDefaultAsync(m => m.Id == id);

            invoice.Status = 2;
            _context.Update(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = id });
        }

        public async Task<IActionResult> DeliveredAsync(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }
            var invoice = await _context.Invoices.Include(i => i.Account).FirstOrDefaultAsync(m => m.Id == id);

            invoice.Status = 3;
            _context.Update(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = id });
        }
    }
}
