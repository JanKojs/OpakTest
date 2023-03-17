using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravTest
{
    public class AppDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=MasterPassword;Host=localhost;Port=5432;Database=OpTest;");
        }
    }
}
