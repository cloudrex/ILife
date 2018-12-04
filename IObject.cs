namespace ILife
{
    public interface IObject : IValuable
    {
        public string Name { get; set; }

        public ObjectCondition Condition { get; set; }
    }
}