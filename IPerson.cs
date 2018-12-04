namespace ILife
{
    public interface IPerson : ITalkable, IAlive, IResponsable
    {
        int Money { get; set; }
    }
}