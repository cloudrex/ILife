namespace ILife
{
    public class Joe : EmployedPerson
    {
        public HealthCondition Condition => HealthCondition.Good;
        public int Age => 20;
        public string Name => "Joe";
    }
}