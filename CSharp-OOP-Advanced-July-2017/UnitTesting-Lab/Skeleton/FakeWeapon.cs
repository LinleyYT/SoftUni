namespace Skeleton
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints { get; }
        public int DurabilityPoints { get; }

        public void Attack(ITarget target)
        {
        }
    }
}