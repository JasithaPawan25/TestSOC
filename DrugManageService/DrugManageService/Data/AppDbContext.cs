using DrugManageService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugManageService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Drug> Drugsmm { get; set; }

        public DbSet<Order> Ordersm { get; set; }

    }
}
