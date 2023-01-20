using arcadian_exam.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arcadian_exam.DataLayer
{

    public class ArcadianDbContext : DbContext
    {
        public ArcadianDbContext(DbContextOptions
    <ArcadianDbContext> options) : base(options)
        {
        }
        public DbSet<arcadian> arcadian { get; set; }
        public DbSet<Country> Country { get; set; }

    }
}
