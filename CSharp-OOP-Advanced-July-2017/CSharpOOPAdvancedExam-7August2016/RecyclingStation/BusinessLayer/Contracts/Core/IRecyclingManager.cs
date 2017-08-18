namespace RecyclingStation.BusinessLayer.Contracts.Core
{
    public interface IRecyclingManager
    {
        string ProcessGarbage(string name, double volumePerKg, double weight, string type);

        string Status();
    }
}