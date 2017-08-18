using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.BusinessLayer.Attributes
{
    public class RecyclableStrategyAttribute : DisposableAttribute
    {
        public RecyclableStrategyAttribute(Type correspondingStrategyType) 
            : base(correspondingStrategyType)
        {
        }
    }
}