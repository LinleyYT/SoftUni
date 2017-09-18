using RecyclingStation.BusinessLayer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace RecyclingStation.BusinessLayer.Factories
{
    public class WasteFactory : IWasteFactory
    {
        private const string WasteSuffix = "Garbage";

        public IWaste CreateWaste(string name, double volumePerKg, double weight, string type)
        {
            Type garbageCreateType = Assembly.GetExecutingAssembly()
                .GetTypes().FirstOrDefault(
                    t => t.Name.Equals($"{type}{WasteSuffix}", StringComparison.OrdinalIgnoreCase));

            object[] wasteArgs = new object[] {name, volumePerKg, weight};

            return (IWaste) Activator.CreateInstance(garbageCreateType, wasteArgs);
        }
    }
}