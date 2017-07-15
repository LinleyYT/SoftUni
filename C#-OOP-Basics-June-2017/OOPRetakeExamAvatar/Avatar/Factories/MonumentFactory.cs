using System.Collections.Generic;

public class MonumentFactory
{
    public Monument CreateMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                return new AirMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            case "Fire":
                return new FireMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            default:
                return null;
        }
    }
}

