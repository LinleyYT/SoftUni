using RecyclingStation.BusinessLayer.Contracts.Core;
using RecyclingStation.BusinessLayer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BusinessLayer.Core
{
    public class RecyclingManager : IRecyclingManager
    {
        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;
        private double energyBalance;
        private double capitalBalance;

        public RecyclingManager(IGarbageProcessor garbageProcessor, IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
        }

        public string ProcessGarbage(string name, double volumePerKg, double weight, string type)
        {
            var currentWaste = this.wasteFactory.CreateWaste(name, volumePerKg, weight, type);

            IProcessingData info = this.garbageProcessor.ProcessWaste(currentWaste);

            this.energyBalance += info.EnergyBalance;
            this.capitalBalance += info.CapitalBalance;
            return $"{currentWaste.Weight:F2} kg of {currentWaste.Name} successfully processed!";
        }

        public string Status()
        {
            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}