public class IBuyerFactory
{
    public IBuyer CreateInhabitant(string[] inputArgs)
    {
        switch (inputArgs.Length)
        {
            case 4:
                var citizenName = inputArgs[0];
                var citizenAge = int.Parse(inputArgs[1]);
                var citizenId = inputArgs[2];
                var citizenBd = inputArgs[3];
                return new Citizen(citizenName, citizenAge, citizenId, citizenBd);
            case 3:
                var rebelName = inputArgs[0];
                var rebelAge = int.Parse(inputArgs[1]);
                var group = inputArgs[2];
                return new Rebel(rebelName, rebelAge, group);
            default:
                return null;
        }
    }
}
