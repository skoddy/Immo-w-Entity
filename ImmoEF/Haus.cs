namespace ImmoEF
{
    public class Haus
    {
        public int HausId { get; set; }
        public string Strasse { get; set; }
        public string HausNr { get; set; }
        public int PLZ { get; set; }
        public string Ort { get; set; }

        public int LiegenschaftId { get; set; }
        public virtual Liegenschaft Liegenschaft { get; set; }
    }
}