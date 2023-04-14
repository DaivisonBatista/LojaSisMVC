using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaSisMVC.Models;
using LojaSisMVC.Models.enums;

namespace LojaSisMVC.Data
{
    public class LojaSisMVCContext : DbContext
    {
        public LojaSisMVCContext (DbContextOptions<LojaSisMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departments> Departments { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
