namespace ILife
{
    public interface IPerson : ITalkable, IAlive, IResponsable, ILucky
    {
        int Money { get; set; }
    }
}