using _02.Blobs.Interfaces;
using System;

namespace _02.Blobs.Factories
{
    public class BehaviorFactory : IBehaviourFactory
    {
        private const string NamespaceName = "_02.Blobs.Entities.Behaviors";

        public IBehavior CreateBehavior(string type)
        {
            Type getType = Type.GetType($"{NamespaceName}.{type}");

            return (IBehavior) Activator.CreateInstance(getType, new object[] { });
        }
    }
}