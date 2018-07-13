using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoEF
{
    public class HausContext : DbContext
    {
        public DbSet<Liegenschaft> Liegenschaft { get; set; }
        public DbSet<Haus> Haus { get; set; }
    }
}
