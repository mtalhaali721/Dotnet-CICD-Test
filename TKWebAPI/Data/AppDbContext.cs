using Microsoft.EntityFrameworkCore;
using TKWebAPI.Models;

namespace TKWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<DevicesModel> Devices { get; set; }
    }
}
