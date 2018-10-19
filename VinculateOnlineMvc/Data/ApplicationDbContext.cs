using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VinculateOnlineMvc.Models;

namespace VinculateOnlineMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VinculateOnlineMvc.Models.DataInfo> DataInfo { get; set; }
        public DbSet<VinculateOnlineMvc.Models.IdentityDocument> IdentityDocument { get; set; }
        public DbSet<VinculateOnlineMvc.Models.ClientBasicInfo> ClientBasicInfo { get; set; }
        public DbSet<VinculateOnlineMvc.Models.ContactInfo> ContactInfo { get; set; }
        public DbSet<VinculateOnlineMvc.Models.EconomicActivity> EconomicActivity { get; set; }
        public DbSet<VinculateOnlineMvc.Models.Compliance> Compliance { get; set; }
    }
}
