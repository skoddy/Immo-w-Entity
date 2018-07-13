using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoEF
{
    public class Wohnung
    {
        public int WohnungId { get; set; }
        public double Qm { get; set; }
        public double QmPreis { get; set; }
        public double Zimmer { get; set; }

        public int HausId { get; set; }
        public virtual Haus Haus { get; set; }
    }
}
