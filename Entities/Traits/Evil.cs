namespace ILife {
    public class Evil : Trait
    {
        public string Name => "evil";

        public ITrait? Merge(ITrait trait)
        {
            if (trait is Mad) {
                return new Insane();
            }

            return null;
        }
    }
}