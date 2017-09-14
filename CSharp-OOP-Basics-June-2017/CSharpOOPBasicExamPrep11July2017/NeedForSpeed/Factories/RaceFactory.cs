public class RaceFactory
{
    public Race CreateRace(string type, int length, string route, int prizePool)
    {
        switch (type.ToLower())
        {
            case "casual":
                return new CasualRace(length, route, prizePool);

            case "drag":
                return new DragRace(length, route, prizePool);

            case "drift":
                return new DriftRace(length, route, prizePool);

            default:
                return null;
        }
    }

    public Race CreateRace(string type, int length, string route, int prizePool, int goldTime)
    {
        if (type == "TimeLimit")
        {
            return new TimeLimitRace(length, route, prizePool, goldTime);
        }

        return null;
    }
}