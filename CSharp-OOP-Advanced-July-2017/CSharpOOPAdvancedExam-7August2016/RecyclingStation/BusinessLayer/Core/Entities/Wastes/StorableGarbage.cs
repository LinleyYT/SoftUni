using RecyclingStation.BusinessLayer.Attributes;
using RecyclingStation.BusinessLayer.Strategies;

namespace RecyclingStation.BusinessLayer.Core.Entities.Wastes
{
    [StorableStrategy(typeof(StorableGarbageDisposalStrategy))]
    public class StorableGarbage : Waste
    {
        public StorableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}