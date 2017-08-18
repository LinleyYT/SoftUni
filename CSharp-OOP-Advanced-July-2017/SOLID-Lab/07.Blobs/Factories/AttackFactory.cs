using System;
using _02.Blobs.Interfaces;

namespace _02.Blobs.Factories
{
    public class AttackFactory : IAttackFactory
    {
        private const string NamespaceName = "_02.Blobs.Entities.Attacks";


        public IAttack CreateAttack(string attackType)
        {
            Type getType = Type.GetType($"{NamespaceName}.{attackType}");

            return (IAttack) Activator.CreateInstance(getType, new object[] { });
        }
    }
}