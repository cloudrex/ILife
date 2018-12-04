namespace ILife {
    public interface IAlive {
        HealthCondition Condition { get; set; }

        int Age { get; set; }

        string Name { get; set; }

        ITrait?[] Traits { get; set; }
    }
}