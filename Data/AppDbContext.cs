using PhamMinhPhuc_2122110044.Model;
using Microsoft.EntityFrameworkCore;

namespace PhamMinhPhuc_2122110044.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
