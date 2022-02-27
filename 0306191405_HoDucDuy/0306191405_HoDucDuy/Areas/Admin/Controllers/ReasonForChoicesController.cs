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
    public class ReasonForChoicesController : Controller
    {
        private readonly MinicsContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReasonForChoicesController(MinicsContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Admin/ReasonForChoices
        public async Task<IActionResult> Index(int? id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            if(id == null)
            {
                ViewData["id"] = null;
                ViewData["ReasonForChoices"] = await _context.ReasonForChoices.ToListAsync();
                return View();
            }
            else
            {
                ViewData["id"] = id;
                ViewData["ReasonForChoices"] = await _context.ReasonForChoices.ToListAsync();
                return View(await _context.ReasonForChoices.FirstOrDefaultAsync(c => c.id == id));
            }
        }

        // GET: Admin/ReasonForChoices/Details/5
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

            var reasonForChoice = await _context.ReasonForChoices
                .FirstOrDefaultAsync(m => m.id == id);
            if (reasonForChoice == null)
            {
                return NotFound();
            }

            return View(reasonForChoice);
        }

        // GET: Admin/ReasonForChoices/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        // POST: Admin/ReasonForChoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Image,ImageFile,Reason,Description,Status")] ReasonForChoice reasonForChoice)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                _context.Add(reasonForChoice);
                await _context.SaveChangesAsync();
                // Upload ảnh
                if (reasonForChoice.ImageFile != null)
                {
                    var fileName = reasonForChoice.id.ToString() + Path.GetExtension(reasonForChoice.ImageFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "reason");
                    var filePath = Path.Combine(uploadPath, fileName);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        reasonForChoice.ImageFile.CopyTo(fs);
                        fs.Flush();
                    }
                    reasonForChoice.Image = fileName;
                    _context.Update(reasonForChoice);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reasonForChoice);
        }

        // GET: Admin/ReasonForChoices/Edit/5
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

            var reasonForChoice = await _context.ReasonForChoices.FindAsync(id);
            if (reasonForChoice == null)
            {
                return NotFound();
            }
            return View(reasonForChoice);
        }

        // POST: Admin/ReasonForChoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Image,ImageFile,Reason,Description,Status")] ReasonForChoice reasonForChoice)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != reasonForChoice.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Xóa ảnh cũ
                    if (reasonForChoice.ImageFile != null)
                    {
                        var fileToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "img", "reason", reasonForChoice.Image);
                        FileInfo file = new FileInfo(fileToDelete);
                        file.Delete();
                    }

                    // Upload ảnh
                    if (reasonForChoice.ImageFile != null)
                    {
                        var fileName = reasonForChoice.id.ToString() + Path.GetExtension(reasonForChoice.ImageFile.FileName);
                        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "reason");
                        var filePath = Path.Combine(uploadPath, fileName);
                        using (FileStream fs = System.IO.File.Create(filePath))
                        {
                            reasonForChoice.ImageFile.CopyTo(fs);
                            fs.Flush();
                        }
                        reasonForChoice.Image = fileName;

                        _context.Update(reasonForChoice);
                        await _context.SaveChangesAsync();
                    }
                    
                    _context.Update(reasonForChoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReasonForChoiceExists(reasonForChoice.id))
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
            return View(reasonForChoice);
        }

        // GET: Admin/ReasonForChoices/Delete/5
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

            var reasonForChoice = await _context.ReasonForChoices
                .FirstOrDefaultAsync(m => m.id == id);
            if (reasonForChoice == null)
            {
                return NotFound();
            }

            return View(reasonForChoice);
        }

        // POST: Admin/ReasonForChoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var reasonForChoice = await _context.ReasonForChoices.FindAsync(id);
            _context.ReasonForChoices.Remove(reasonForChoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReasonForChoiceExists(int id)
        {
            return _context.ReasonForChoices.Any(e => e.id == id);
        }
    }
}
