namespace _02.Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; }

        int Health { get; set; }

        IBehavior Behavior { get; }

        void Attack(IBlob target);

        void Respond(int damage);

        int Damage { get; set; }
    }
}