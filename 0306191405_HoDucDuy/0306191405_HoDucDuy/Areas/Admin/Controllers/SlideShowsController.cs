using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlideShowsController : Controller
    {
        private readonly MinicsContext _context;
        
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SlideShowsController(MinicsContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context; 
            _webHostEnvironment = webHostEnvironment;
        }
        
        // GET: Admin/SlideShows
        public async Task<IActionResult> Index(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                ViewData["SlideShows"] = await _context.SlideShows.OrderByDescending(s => s.Id).ToListAsync();
                ViewData["id"] = id;
                return View();
            }
            else
            {
                ViewData["SlideShows"] = await _context.SlideShows.OrderByDescending(s => s.Id).ToListAsync();
                ViewData["id"] = id;
                return View(await _context.SlideShows.FirstOrDefaultAsync(s => s.Id == id));
            }
        }

        // GET: Admin/SlideShows/Details/5
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

            var slideShow = await _context.SlideShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slideShow == null)
            {
                return NotFound();
            }

            return View(slideShow);
        }

        // GET: Admin/SlideShows/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        // POST: Admin/SlideShows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,ImageFile,Title,Description,Status")] SlideShow slideShow)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.Add(slideShow);
                await _context.SaveChangesAsync();

                // Upload ảnh
                if (slideShow.ImageFile != null)
                {
                    var fileName = slideShow.Id.ToString() + Path.GetExtension(slideShow.ImageFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slideshow");
                    var filePath = Path.Combine(uploadPath, fileName);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        slideShow.ImageFile.CopyTo(fs);
                        fs.Flush();
                    }
                    slideShow.Image = fileName;
                    _context.Update(slideShow);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(slideShow);
        }

        // GET: Admin/SlideShows/Edit/5
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

            var slideShow = await _context.SlideShows.FindAsync(id);
            if (slideShow == null)
            {
                return NotFound();
            }
            return View(slideShow);
        }

        // POST: Admin/SlideShows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,ImageFile,Title,Description,Status")] SlideShow slideShow)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != slideShow.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Xóa ảnh cũ
                    if (slideShow.ImageFile != null)
                    {
                        var fileToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slideshow", slideShow.Image);
                        FileInfo file = new FileInfo(fileToDelete);
                        file.Delete();
                    }

                    // Upload ảnh
                    if (slideShow.ImageFile != null)
                    {
                        var fileName = slideShow.Id.ToString() + Path.GetExtension(slideShow.ImageFile.FileName);
                        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slideshow");
                        var filePath = Path.Combine(uploadPath, fileName);
                        using (FileStream fs = System.IO.File.Create(filePath))
                        {
                            slideShow.ImageFile.CopyTo(fs);
                            fs.Flush();
                        }
                        slideShow.Image = fileName;
                        _context.Update(slideShow);
                        await _context.SaveChangesAsync();
                    }
                    _context.Update(slideShow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlideShowExists(slideShow.Id))
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
            return View(slideShow);
        }

        // GET: Admin/SlideShows/Delete/5
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

            var slideShow = await _context.SlideShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slideShow == null)
            {
                return NotFound();
            }

            return View(slideShow);
        }

        // POST: Admin/SlideShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var slideShow = await _context.SlideShows.FindAsync(id);
            _context.SlideShows.Remove(slideShow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlideShowExists(int id)
        {
            return _context.SlideShows.Any(e => e.Id == id);
        }
    }
}
