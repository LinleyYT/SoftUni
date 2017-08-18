using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BusinessLayer.Contracts.Factories
{
    public interface IWasteFactory
    {
        IWaste CreateWaste(string name, double volumePerKg, double weight, string type);
    }
}