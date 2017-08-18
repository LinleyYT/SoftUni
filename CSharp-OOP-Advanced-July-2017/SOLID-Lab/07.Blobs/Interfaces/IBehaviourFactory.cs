namespace _02.Blobs.Interfaces
{
    public interface IBehaviourFactory
    {
        IBehavior CreateBehavior(string type);
    }
}