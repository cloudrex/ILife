namespace ILife {
    public class World {
        public event EventHandler OnDay;

        public event EventHandler<Person> OnDeath;

        public event EventHandler<Person> OnBirth;
    }
}