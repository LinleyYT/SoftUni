using _02.Blobs.Attributes;
using _02.Blobs.Entities;
using _02.Blobs.Interfaces;

namespace _02.Blobs.Core.Commands
{
    public class CreateCommand : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IBehaviourFactory behaviourFactory;

        [Inject]
        private IAttackFactory attackFactory;

        public CreateCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            var currentBehavior = this.behaviourFactory.CreateBehavior(Data[3]);
            var currentAttack = this.attackFactory.CreateAttack(Data[4]);

            var currentBlob = new Blob(this.Data[0], int.Parse(this.Data[1]), int.Parse(this.Data[2]), currentBehavior, currentAttack);

            this.repository.AddUnit(currentBlob);

            return string.Empty;
        }
    }
}