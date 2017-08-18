using _02.Blobs.Core;
using _02.Blobs.Data;
using _02.Blobs.Factories;
using _02.Blobs.Interfaces;

namespace _02.Blobs
{
    public class StartUp
    {
        public static void Main()
        {
            IRepository repository = new Repository();
            IBehaviourFactory behaviourFactory = new BehaviorFactory();
            IAttackFactory attackFactory = new AttackFactory();
            ICommandInterpretable commandInterpreter = new CommandInterpreter(repository, behaviourFactory, attackFactory);
            IRunable engine = new Engine(commandInterpreter);

            engine.Run();
        }
    }
}
