﻿namespace _10.Explicit_Interfaces.Models.Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        string Age { get; }

        string GetName();
    }
}