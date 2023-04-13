using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaSisMVC.Models;

namespace LojaSisMVC.Data
{
    public class LojaSisMVCContext : DbContext
    {
        public LojaSisMVCContext (DbContextOptions<LojaSisMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LojaSisMVC.Models.Departments> Departments { get; set; } = default!;
    }
}
