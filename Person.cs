namespace ILife
{
    public class Person : IPerson
    {
        public virtual int Money => 0;
        public virtual HealthCondition Condition => HealthCondition.Healthy;
        public virtual int Luck => 0;
        public abstract int Age;
        public abstract string Name;
        public virtual ITrait?[] Traits = null;
        public virtual Responsibility?[] Responsibilities = null;

        public virtual uint Stress => 0;

        public virtual string Talk(IPerson person)
        {
            return $"Hi, I'm {this.Name}!";
        }

        public virtual void DoNeeds()
        {
            int relief = 1;
        }
    }
}