namespace _02.Blobs.Interfaces
{
    public interface IRepository
    {
        void AddUnit(IBlob blob);
        string Status();
    }
}