using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class AppDB : DbContext
    {
        public DbSet<Good> Goods { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Saled> Saleds { get; set; } = null!;
        public DbSet<Good_saled> Good_Selads { get; set; } = null!;

        public AppDB()
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gooddb.db");
        }
    }
}
