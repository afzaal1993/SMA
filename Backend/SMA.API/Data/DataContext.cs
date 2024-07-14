using Microsoft.EntityFrameworkCore;
using SMA.API.Entities;

namespace SMA.API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
