namespace ImmoEF
{
    public class Liegenschaft
    {
        private readonly ObservableListSource<Haus> _haus =
            new ObservableListSource<Haus>();

        public int LiegenschaftId { get; set; }
        public string Name { get; set; }

        public virtual ObservableListSource<Haus> Haus { get { return _haus; } }
    }
}
