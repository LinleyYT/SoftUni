using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BusinessLayer.Strategies
{
    public class BurnableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste waste)
        {
            return 0.8 * waste.CalculateTotalGarbageVolume();
        }

        protected override double CalculateCapitalBalance(IWaste waste)
        {
            return 0;
        }
    }
}