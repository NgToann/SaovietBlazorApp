using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaovietServerBlazorApp.Models;

namespace SaovietServerBlazorApp.Data
{
    public class SaovietContext : DbContext
    {
        public SaovietContext(DbContextOptions<SaovietContext> options) : base(options)
        { }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OutsoleSupplierModel> OutsoleSuppliers { get; set; }
        public DbSet<OSMaterialWHCheckModel> OutsoleMaterialCheckingList { get; set; }

    }
}
