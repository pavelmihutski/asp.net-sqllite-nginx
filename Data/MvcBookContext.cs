using Microsoft.EntityFrameworkCore;
using libraryApp.Models;

namespace libraryApp.Data
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext (DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}