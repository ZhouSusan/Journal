using Microsoft.EntityFrameworkCore;

namespace Journal.Models
{
    public class JournalContext: DbContext
    {
        public JournalContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users{ get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}