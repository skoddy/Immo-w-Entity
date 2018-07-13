using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoEF
{
    public class WohnungContext : DbContext
    {
        public DbSet<Haus> Haus { get; set; }
        public DbSet<Wohnung> Wohnung { get; set; }
    }
}
