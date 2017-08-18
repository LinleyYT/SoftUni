namespace _02.Blobs.Interfaces
{
    public interface IAttackFactory
    {
        IAttack CreateAttack(string attackType);
    }
}