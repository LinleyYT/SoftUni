namespace _08.MilitaryElite.Models.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        string State { get; }

        void CompleteMission();
    }
}