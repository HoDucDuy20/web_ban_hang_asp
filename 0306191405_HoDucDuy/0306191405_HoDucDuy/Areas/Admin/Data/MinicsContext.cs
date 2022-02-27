using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _0306191405_HoDucDuy.Areas.Admin.Models;

namespace _0306191405_HoDucDuy.Data
{
    public class MinicsContext : DbContext
    {
        internal object cart;

        public MinicsContext(DbContextOptions<MinicsContext> options)
            : base(options)
        {
        }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.About> Abouts { get; set; }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Account> Accounts { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Cart> Carts { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.InfoShop> InfoShops { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Invoice> Invoices { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.InvoiceDetail> InvoiceDetails { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Product> Products { get; set; }
        
        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.ProductType> ProductTypes { get; set; }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.ReasonForChoice> ReasonForChoices { get; set; }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.SlideShow> SlideShows { get; set; }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Testimonial> Testimonials { get; set; }

        public DbSet<_0306191405_HoDucDuy.Areas.Admin.Models.Rate> Rates { get; set; }

    }
}
