using _0306191405_HoDucDuy.Areas.Admin.Data;
using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using _0306191405_HoDucDuy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace _0306191405_HoDucDuy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MinicsContext _context;

        public HomeController(ILogger<HomeController> logger, MinicsContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync(int? page)
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.Index = "active";            
            //dynamic mymodel = new ExpandoObject();
            //mymodel.SlideShows = await _context.SlideShows.ToListAsync();
            //mymodel.Abouts = await _context.Abouts.ToListAsync();
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["SlideShows"] = await _context.SlideShows.Where(c => c.Status == true).ToListAsync();
            ViewData["Abouts"] = await _context.Abouts.ToListAsync();
            ViewData["ReasonForChoices"] = await _context.ReasonForChoices.ToListAsync();
            ViewData["Testimonials"] = await _context.Testimonials.Where(c => c.Status == true).ToListAsync();
            ViewData["FeaturedProducts"] = _context.Products.Where(c => c.Highlights).Where(c => c.status == true).OrderByDescending(s => s.Id).ToList();
            ViewData["Products"] = _context.Products.Where(c => c.status == true).OrderByDescending(s => s.Id).ToList().ToPagedList(pageNumber: page ?? 1, pageSize: 9);
            ViewData["Rates"] = await _context.Rates.ToListAsync();
            return View();
            //.ToPagedList(pageNumber: 1, pageSize: 3)
        }

        public async Task<IActionResult> AboutAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.About = "active";            
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            return View(await _context.Abouts.ToListAsync());
        }

        public async Task<IActionResult> LoginAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(string username, string password)
        {
            ViewBag.Us = Request.Cookies["user"];
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            password = StringProcessing.MD5Encode(StringProcessing.Base64Encode(password));
            //password = StringProcessing.Encrypt(password);

            if (!String.IsNullOrEmpty(username))
            {
                var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Username == username);
                if (account.Password == password)
                {
                    if (account.Status)
                    {
                        //Tạo cookie
                        CookieOptions opt = new CookieOptions();
                        opt.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Append("isAdmin", account.IsAdmin.ToString(), opt);
                        Response.Cookies.Append("status", account.Status.ToString(), opt);
                        Response.Cookies.Append("user", account.Username, opt);
                        Response.Cookies.Append("id", account.Id.ToString(), opt);
                        HttpContext.Session.SetString("token", StringProcessing.Base64Encode(DateTime.Now.ToShortTimeString()));
                        ViewBag.Us = Request.Cookies["user"];
                        if (Request.Cookies["isAdmin"] == "True")
                        {
                            return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
                        }
                        //Response.Cookies.Delete("user"); Xóa cookie
                        return RedirectToAction("Info", "User");
                    }
                    else
                    {
                        ViewBag.Result = false;
                        return View();
                    }
                }
                else
                {
                    ViewBag.Result = false;
                    return View();
                }
            }
            ViewBag.Result = false;
            return View();
        }

        public IActionResult LogOut()
        {
            Response.Cookies.Delete("user");
            Response.Cookies.Delete("isAdmin");
            Response.Cookies.Delete("status");

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> RegistrationAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            if (Request.Cookies["isAdmin"] != "False" || Request.Cookies["status"] != "True")
            {
                ViewBag.Us = Request.Cookies["user"];
                ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
                return View();
            }

            ViewBag.Us = Request.Cookies["user"];
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationAsync(string UserName, string FullName,  string Phone, string Pass, string Pass2)
        {
            ViewBag.Us = Request.Cookies["user"];
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            if(Pass == Pass2)
            {
                Pass = StringProcessing.MD5Encode(StringProcessing.Base64Encode(Pass));
                //Pass = StringProcessing.Encrypt(Pass);

                var account_db = await _context.Accounts.FirstOrDefaultAsync(m => m.Username == UserName);
                if (account_db == null)
                {
                    Account account = new Account();
                    account.Username = UserName;
                    account.FullName = FullName;
                    account.Phone = Phone;
                    account.Address = "";
                    account.Password = Pass;
                    account.Status = true;
                    _context.Add(account);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Login");
                }
            }
            ViewBag.Result = false;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
