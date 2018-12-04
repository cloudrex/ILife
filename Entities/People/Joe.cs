namespace ILife {
    public class Joe : IPerson
    {
        public HealthCondition Condition => HealthCondition.Good;
        public int Age => 20;
        public string Name => "Joe";

        public string Talk(IPerson person)
        {
            return "Hi, I'm Joe!";
        }
    }
}