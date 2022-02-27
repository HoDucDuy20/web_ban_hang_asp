using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Controllers
{
    public class UserController : Controller
    {
        private readonly MinicsContext _context;

        public UserController(MinicsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> InfoAsync()
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
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Id == int.Parse(Request.Cookies["id"]));
            return View(account);
        }

        public async Task<IActionResult> OrderAsync()
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var minicsContext = from m in _context.Invoices where m.AccountId == int.Parse(Request.Cookies["id"]) select m;
            minicsContext = minicsContext.OrderByDescending(s => s.IssuedDate);
            return View(await minicsContext.ToListAsync());
        }


        public async Task<IActionResult> CancelAsync(int id)
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var invoice = await _context.Invoices.Include(i => i.Account).FirstOrDefaultAsync(m => m.Id == id);

            invoice.Status = 0;
            _context.Update(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Order");
        }

        public async Task<IActionResult> InvoiceDetailsAsync(int id)
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var minicsContext = from m in _context.InvoiceDetails.Include(p => p.Product) where m.InvoiceId == id select m;
            return View(await minicsContext.ToListAsync());
        }

        public async Task<IActionResult> ChangePassAsync()
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassAsync(string Old_Password, string New_Password, string Confirm_Password)
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Id == int.Parse(Request.Cookies["id"]));

            if (!String.IsNullOrEmpty(Old_Password))
            {
                if (New_Password == Confirm_Password)
                {
                    if (account.Password == Old_Password)
                    {
                        account.Password = New_Password;
                        _context.Update(account);
                        await _context.SaveChangesAsync();

                        Response.Cookies.Delete("user");
                        Response.Cookies.Delete("isAdmin");
                        Response.Cookies.Delete("status");
                        return RedirectToAction("Login", "Home");
                    }
                }
            }
            ViewBag.Result = false;
            return View();
        }

        public async Task<IActionResult> EditProfileAsync()
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Id == int.Parse(Request.Cookies["id"]));
            return View(account);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfileAsync(string FullName, string Email, string Phone, string Address)
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

            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();

            var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Id == int.Parse(Request.Cookies["id"]));

            if (FullName != null && Email != null && Phone != null && Address != null)
            {
                account.FullName = FullName;
                account.Email = Email;
                account.Phone = Phone;
                account.Address = Address;
                _context.Update(account);
                await _context.SaveChangesAsync();

                return RedirectToAction("Info");
            }
            ViewBag.Result = false;
            return View();
        }
    }
}
