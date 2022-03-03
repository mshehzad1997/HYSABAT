using HYSABAT.Models;
using HYSABAT.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Features> features { get; set; }
        public DbSet<Video> videos { get; set; }
        public DbSet<ContactUs> contactUs { get; set; }
        public DbSet<PricingPlan> pricingPlans { get; set; }
        public DbSet<CompanyContactInformation> companyContactInformation { get; set; }
        public DbSet<ContactInformation> contactInformation { get; set; }
        public DbSet<Question> questions { get; set; }
       
    
    }
}
