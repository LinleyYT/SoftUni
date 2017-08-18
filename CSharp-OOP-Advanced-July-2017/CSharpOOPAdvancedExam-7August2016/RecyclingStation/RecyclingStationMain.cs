using System;
using System.Collections.Generic;
using RecyclingStation.BusinessLayer.Contracts.Core;
using RecyclingStation.BusinessLayer.Contracts.Factories;
using RecyclingStation.BusinessLayer.Contracts.IO;
using RecyclingStation.BusinessLayer.Core;
using RecyclingStation.BusinessLayer.Core.IO;
using RecyclingStation.BusinessLayer.Factories;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation
{
    public class RecyclingStationMain
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
            IStrategyHolder strategyHolder = new StrategyHolder(strategies);
            IGarbageProcessor garbageProcessor = new GarbageProcessor(strategyHolder);
            IWasteFactory wasteFactory = new WasteFactory();
            IRecyclingManager recyclingManager = new RecyclingManager(garbageProcessor, wasteFactory);
            IEngine engine = new Engine(reader, writer, recyclingManager);

            engine.Run();
        }
    }
}
