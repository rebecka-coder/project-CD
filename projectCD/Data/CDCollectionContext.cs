using projectCD.Models;
using Microsoft.EntityFrameworkCore;

namespace projectCD.Data
{
    public class CDCollectionContext : DbContext
    {
        public CDCollectionContext(DbContextOptions<CDCollectionContext> options) : base(options)
        {
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }
    }
}