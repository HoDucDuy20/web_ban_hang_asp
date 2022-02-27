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
    public class AboutsController : Controller
    {
        private readonly MinicsContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutsController(MinicsContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: Admin/Abouts
        public async Task<IActionResult> Index(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if(id == null)
            {
                var about = await _context.Abouts.FirstOrDefaultAsync();
                if (about == null)
                {
                    return NotFound();
                }
                ViewData["About"] = about;
                ViewData["id"] = id;
                return View();
            }
            else
            {
                var about = await _context.Abouts.FirstOrDefaultAsync();
                if (about == null)
                {
                    return NotFound();
                }
                ViewData["About"] = about;
                ViewData["id"] = id;
                return View(await _context.Abouts.FirstOrDefaultAsync(c => c.Id == id));
            }
        }

        // GET: Admin/Abouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.Abouts.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        // POST: Admin/Abouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,ImageFile,Title,Description")] About about)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != about.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Xóa ảnh cũ
                    if (about.ImageFile != null)
                    {
                        var fileToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "img", "about", about.Image);
                        FileInfo file = new FileInfo(fileToDelete);
                        file.Delete();
                    }

                    // Upload ảnh
                    if (about.ImageFile != null)
                    {
                        var fileName = about.Id.ToString() + Path.GetExtension(about.ImageFile.FileName);
                        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "about");
                        var filePath = Path.Combine(uploadPath, fileName);
                        using (FileStream fs = System.IO.File.Create(filePath))
                        {
                            about.ImageFile.CopyTo(fs);
                            fs.Flush();
                        }
                        about.Image = fileName;
                        _context.Update(about);
                        await _context.SaveChangesAsync();
                    }

                    _context.Update(about);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutExists(about.Id))
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
            return View(about);
        }

        private bool AboutExists(int id)
        {
            return _context.Abouts.Any(e => e.Id == id);
        }
    }
}
