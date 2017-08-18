using _02.Blobs.Interfaces;

namespace _02.Blobs.Entities.Attacks
{
    public class PutridFart : Attack
    {
        public override void Execute(IBlob attacker, IBlob target)
        {
            target.Respond(attacker.Damage);
        }
    }
}