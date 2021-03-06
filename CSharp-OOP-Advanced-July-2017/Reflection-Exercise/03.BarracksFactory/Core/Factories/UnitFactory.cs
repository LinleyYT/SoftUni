﻿namespace _03BarracksFactory.Core.Factories
{
    using Contracts;
    using System;

    public class UnitFactory : IUnitFactory
    {
        private const string TypeNamespace = "_03BarracksFactory.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            Type getType = Type.GetType($"{TypeNamespace}.{unitType}");

            return (IUnit) Activator.CreateInstance(getType, new object[] { });
        }
    }
}