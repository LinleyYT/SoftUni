using System.Collections.Generic;

public class BenderFactory
{
    public Bender CreateBender(List<string> benderArgs)
    {
        var typeOfBender = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var typeSpecialty = double.Parse(benderArgs[3]);

        switch (typeOfBender)
        {
            case "Air":
                return new AirBender(name, power, typeSpecialty);
            case "Water":
                return new WaterBender(name, power, typeSpecialty);
            case "Fire":
                return new FireBender(name, power, typeSpecialty);
            case "Earth":
                return new EarthBender(name, power, typeSpecialty);
            default:
                return null;
        }
    }
}

