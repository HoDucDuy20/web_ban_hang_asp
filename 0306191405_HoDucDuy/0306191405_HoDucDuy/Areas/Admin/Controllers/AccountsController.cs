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
using X.PagedList;
using _0306191405_HoDucDuy.Areas.Admin.Data;

namespace _0306191405_HoDucDuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private readonly MinicsContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountsController(MinicsContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Admin/Accounts
        public async Task<IActionResult> Index(int? page, string sdt, int isAd, int stt)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.search = sdt;
            ViewBag.isAd = isAd;
            ViewBag.stt = stt;

            if (isAd == 1)
            {
                if(stt == 0)
                {
                    if (sdt != null)
                    {
                        return View(_context.Accounts.Where(c => c.IsAdmin == true).Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                    }
                    return View(_context.Accounts.Where(c => c.IsAdmin == true).Where(c => c.Status == true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                if (stt == 1)
                {
                    if (sdt != null)
                    {
                        return View(_context.Accounts.Where(c => c.IsAdmin == true).Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                    }
                    return View( _context.Accounts.Where(c => c.IsAdmin == true).Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View( _context.Accounts.Where(c=>c.IsAdmin==true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            if (isAd == 2)
            {
                if (stt == 0)
                {
                    if (sdt != null)
                    {
                        return View(_context.Accounts.Where(c => c.IsAdmin == false).Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                    }
                    return View( _context.Accounts.Where(c => c.IsAdmin == false).Where(c => c.Status == true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                if (stt == 1)
                {
                    if (sdt != null)
                    {
                        return View(_context.Accounts.Where(c => c.IsAdmin == false).Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                    }
                    return View( _context.Accounts.Where(c => c.IsAdmin == false).Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View( _context.Accounts.Where(c => c.IsAdmin == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }

            if (stt == 0)
            {
                if (sdt != null)
                {
                    return View(_context.Accounts.Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == true).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View( _context.Accounts.Where(c => c.Status == true).OrderByDescending(c=>c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            if (stt == 1)
            {
                if (sdt != null)
                {
                    return View(_context.Accounts.Where(c => c.Phone.Contains(sdt)).Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
                }
                return View( _context.Accounts.Where(c => c.Status == false).OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
            }
            return View( _context.Accounts.OrderByDescending(c => c.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 10));
        }

        // GET: Admin/Accounts/Details/5
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

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/Accounts/Create
        public IActionResult Create()
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        // POST: Admin/Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,AvatarFile,Status")] Account account)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (ModelState.IsValid)
            {
                account.Password = StringProcessing.MD5Encode(StringProcessing.Base64Encode(account.Password));
                //account.Password = StringProcessing.Encrypt(account.Password);
                _context.Add(account);
                await _context.SaveChangesAsync();

                // Upload ảnh
                if (account.AvatarFile != null)
                {
                    var fileName = account.Id.ToString() + Path.GetExtension(account.AvatarFile.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "account");
                    var filePath = Path.Combine(uploadPath, fileName);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        account.AvatarFile.CopyTo(fs);
                        fs.Flush();
                    }
                    account.Avatar = fileName;
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Admin/Accounts/Edit/5
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

            var account = await _context.Accounts.FindAsync(id);
            //account.Password = "";
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Admin/Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,AvatarFile,Status")] Account account)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Xóa ảnh cũ
                    if (account.AvatarFile != null)
                    {
                        var fileToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "img", "account", account.Avatar);
                        FileInfo file = new FileInfo(fileToDelete);
                        file.Delete();
                    }

                    // Upload ảnh
                    if (account.AvatarFile != null)
                    {
                        var fileName = account.Id.ToString() + Path.GetExtension(account.AvatarFile.FileName);
                        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "account");
                        var filePath = Path.Combine(uploadPath, fileName);
                        using (FileStream fs = System.IO.File.Create(filePath))
                        {
                            account.AvatarFile.CopyTo(fs);
                            fs.Flush();
                        }
                        account.Avatar = fileName;
                        _context.Update(account);
                        await _context.SaveChangesAsync();
                    }
                    account.Password = StringProcessing.MD5Encode(StringProcessing.Base64Encode(account.Password));
                    //account.Password = StringProcessing.Encrypt(account.Password);
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View(account);
        }

        // GET: Admin/Accounts/Delete/5
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

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Reset(int? id)
        {

            if (Request.Cookies["isAdmin"] != "True" || Request.Cookies["status"] != "True")
            {
                return RedirectToAction("Login", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            account.Password = "123456";
            _context.Update(account);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
