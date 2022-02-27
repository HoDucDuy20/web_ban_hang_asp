using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly MinicsContext _context;

        public FeedbackController(MinicsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> TestimonialAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.Testimonial = "active";
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["Testimonials"] = await _context.Testimonials.Where(c => c.Status == true).ToListAsync();
            return View();
        }

        public async Task<IActionResult> WhyAsync()
        {
            if (Request.Cookies["isAdmin"] == "True" && Request.Cookies["status"] == "True")
            {
                return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
            }
            ViewBag.Us = Request.Cookies["user"];
            ViewBag.Why = "active";
            ViewData["InfoShops"] = await _context.InfoShops.ToListAsync();
            ViewData["ReasonForChoices"] = await _context.ReasonForChoices.ToListAsync();
            return View();
        }
    }
}
