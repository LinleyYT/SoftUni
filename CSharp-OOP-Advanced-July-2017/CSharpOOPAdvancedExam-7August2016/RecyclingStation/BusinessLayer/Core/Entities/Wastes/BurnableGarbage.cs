using RecyclingStation.BusinessLayer.Attributes;
using RecyclingStation.BusinessLayer.Strategies;

namespace RecyclingStation.BusinessLayer.Core.Entities.Wastes
{
    [BurnableStrategy(typeof(BurnableGarbageDisposalStrategy))]
    public class BurnableGarbage : Waste
    {
        public BurnableGarbage(string name, double weight, double volumePerKg)
            : base(name, weight, volumePerKg)
        {
        }
    }
}