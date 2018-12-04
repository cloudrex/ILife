namespace ILife {
    public interface ITrait
    {
        public string Name { get; set; }

        void Effect();

        ITrait? Merge(ITrait trait);
    }
}