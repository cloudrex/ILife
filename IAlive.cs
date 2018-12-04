namespace ILife {
    public interface IAlive {
        HealthCondition Condition { get; set; }

        int Age { get; set; }

        uint Stress { get; set; }

        string Name { get; set; }

        ITrait?[] Traits { get; set; }

        void DoNeeds();
    }
}