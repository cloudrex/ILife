namespace ILife {
    public interface IJob
    {
        int Salary { get; set; }

        IJobRisk?[] Risks { get; set; }

        Person[] Employees { get; set; }

        uint Intensity { get; set; }
    }
}