namespace Skeleton
{
    public interface ITarget
    {
        void TakeAttack(int attackPoints);
        int Health { get; set; }
        int GiveExperience();
        bool IsDead();
    }
}