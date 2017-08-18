using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BusinessLayer.Strategies
{
    public class RecyclableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste waste)
        {
            return 0 - 0.5 * waste.CalculateTotalGarbageVolume();
        }

        protected override double CalculateCapitalBalance(IWaste waste)
        {
            return 400 * waste.Weight;
        }
    }
}