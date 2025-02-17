﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteVendasMVC.Models;

namespace SiteVendasMVC.Data
{
    public class SiteVendasMVCContext : DbContext
    {
        public SiteVendasMVCContext (DbContextOptions<SiteVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
    