using RecyclingStation.BusinessLayer.Attributes;
using RecyclingStation.BusinessLayer.Strategies;

namespace RecyclingStation.BusinessLayer.Core.Entities.Wastes
{
    [RecyclableStrategy(typeof(RecyclableGarbageDisposalStrategy))]
    public class RecyclableGarbage : Waste
    {
        public RecyclableGarbage(string name, double weight, double volumePerKg)
            : base(name, weight, volumePerKg)
        {
        }
    }
}