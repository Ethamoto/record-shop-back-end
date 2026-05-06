using Microsoft.EntityFrameworkCore;
using RecordShopBackEnd.Models;

namespace RecordShopBackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
    }
}