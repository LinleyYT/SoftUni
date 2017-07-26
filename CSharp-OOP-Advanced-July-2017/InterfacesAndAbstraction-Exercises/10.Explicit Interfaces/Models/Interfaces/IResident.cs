namespace _10.Explicit_Interfaces.Models.Interfaces
{
    public interface IResident
    {
        string Name { get; }
        string Country { get; }

        string GetName();
    }
}