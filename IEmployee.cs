namespace ILife {
    public class EmployedPerson : Person
    {
        public IJob job { get; set; }

        public virtual void Work() {
            this.Money += this.job.Salary + this.Luck;
            this.Stress += this.job.Intensity - this.Luck;
        }
    }
}