﻿namespace _02.Blobs.Entities.Attacks
{
    using _02.Blobs.Interfaces;

    public abstract class Attack : IAttack
    {
        public abstract void Execute(IBlob attacker, IBlob target);
    }
}