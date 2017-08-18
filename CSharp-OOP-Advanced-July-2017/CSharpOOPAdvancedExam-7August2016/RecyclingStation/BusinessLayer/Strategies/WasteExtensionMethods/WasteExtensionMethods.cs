namespace RecyclingStation.WasteDisposal.Interfaces
{
    public static class WasteExtensionMethods
    {
        public static double CalculateTotalGarbageVolume(this IWaste waste)
        {
            return waste.Weight * waste.VolumePerKg;
        }
    }
}