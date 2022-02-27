using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using X.PagedList;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly MinicsContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(MinicsContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index(int? page, string name, int type, int stt)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.search = name;
            ViewBag.stt = stt;
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", type);
            if (stt == 0)
            {
                if (type != 0)
                {
                    if (name != null)
                    {
                        return View(_context.Products.Where(c => c.status == true).Where(c => c.Name.Contains(name)).Where(c => c.ProductTypeId == type).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                    }
                    return View(_context.Products.Where(c => c.status == true).Where(c => c.ProductTypeId == type).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                if (name != null)
                {
                    return View(_context.Products.Where(c => c.status == true).Where(c => c.Name.Contains(name)).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View(_context.Products.Where(c => c.status == true).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }

            if (type != 0)
            {
                if (name != null)
                {
                    return View(_context.Products.Where(c => c.status == false).Where(c => c.Name.Contains(name)).Where(c => c.ProductTypeId == type).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View(_context.Products.Where(c => c.status == false).Where(c => c.ProductTypeId == type).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            if (name != null)
            {
                return View(_context.Products.Where(c => c.status == false).Where(c => c.Name.Contains(name)).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            return View(_context.Products.Where(c => c.status == false).OrderByDescending(s => s.Id).OrderByDescending(s => s.Highlights).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));

            //var minicsContext = _context.Products.Include(p => p.ProductType);
            //return View(await minicsContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
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

            var product = await _context.Products
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SKU,Name,Description,Price,Stock,Star,ProductTypeId,ImageFile,Highlights,status")] Product product)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();

                // Upload ảnh
                if (product.ImageFile != null)
                {
                    var fileName = product.Id.ToString() + Path.GetExtension(product.ImageFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product");
                    var filePath = Path.Combine(uploadPath, fileName);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        product.ImageFile.CopyTo(fs);
                        fs.Flush();
                    }
                    product.Image = fileName;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
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

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SKU,Name,Description,Price,Stock,Star,ProductTypeId,Image,ImageFile,Highlights,status")] Product product)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Xóa ảnh cũ
                    if (product.ImageFile != null)
                    {
                        var fileToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product", product.Image);
                        FileInfo file = new FileInfo(fileToDelete);
                        file.Delete();
                    }

                    // Upload ảnh
                    if (product.ImageFile != null)
                    {
                        var fileName = product.Id.ToString() + Path.GetExtension(product.ImageFile.FileName);
                        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product");
                        var filePath = Path.Combine(uploadPath, fileName);
                        using (FileStream fs = System.IO.File.Create(filePath))
                        {
                            product.ImageFile.CopyTo(fs);
                            fs.Flush();
                        }
                        product.Image = fileName;
                        _context.Update(product);
                        await _context.SaveChangesAsync();
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
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

            var product = await _context.Products
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }


        public async Task<IActionResult> ActiveAsync(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            product.Highlights = true;
            _context.Update(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UnActiveAsync(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            product.Highlights = false;
            _context.Update(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
