using Microsoft.EntityFrameworkCore;
using System;

namespace CoreDAL
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
