using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.BusinessLayer.Attributes
{
    public class StorableStrategyAttribute : DisposableAttribute
    {
        public StorableStrategyAttribute(Type correspondingStrategyType) 
            : base(correspondingStrategyType)
        {
        }
    }
}