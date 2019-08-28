using Prodavam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Prodavam.App.Data
{
    public class ProdavamDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ProdavamDbContext(DbContextOptions<ProdavamDbContext> options)
            : base(options)
        {
        }

        public ProdavamDbContext()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DRASKOV-PC\\SQLEXPRESS;Database=ProdavamASP;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);

           
        }
    }
}
