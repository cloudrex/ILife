namespace ILife {
    public class Trait : ITrait
    {
        public abstract string Name;

        public abstract void Effect();

        public virtual ITrait? Merge(ITrait trait)
        {
            return null;
        }
    }
}