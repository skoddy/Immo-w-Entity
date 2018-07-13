namespace ImmoEF
{
    public class Haus
    {
        private readonly ObservableListSource<Wohnung> _wohnung =
            new ObservableListSource<Wohnung>();
        public int HausId { get; set; }
        public string Strasse { get; set; }
        public string HausNr { get; set; }
        public int PLZ { get; set; }
        public string Ort { get; set; }

        public int LiegenschaftId { get; set; }
        public virtual Liegenschaft Liegenschaft { get; set; }
        public virtual ObservableListSource<Wohnung> Wohnung { get { return _wohnung; } }
    }
}