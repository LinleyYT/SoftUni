using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BusinessLayer.Strategies
{
    public class StorableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste waste)
        {
            return 0 - 0.13 * waste.CalculateTotalGarbageVolume();
        }

        protected override double CalculateCapitalBalance(IWaste waste)
        {
            return 0 - 0.65 * waste.CalculateTotalGarbageVolume();
        }
    }
}