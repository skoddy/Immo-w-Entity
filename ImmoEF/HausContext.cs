using System.Data.Entity;

namespace ImmoEF
{
    public class HausContext : DbContext
    {
        public DbSet<Liegenschaft> Liegenschaft { get; set; }
        public DbSet<Haus> Haus { get; set; }
    }
}
