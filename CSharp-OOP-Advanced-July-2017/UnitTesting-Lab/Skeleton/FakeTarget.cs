namespace Skeleton
{
    public class FakeTarget : ITarget
    {
        public int Health
        {
            get => 0;
            set {  }
        }

        public void TakeAttack(int attackPoints)
        {
        }

        public int GiveExperience()
        { return 20; }

        public bool IsDead()
        { return true; }
    }
}