﻿using System;

public class Dog : Animal
{
    public Dog(string name, string food)
    {
        this.Name = name;
        this.FavouriteFood = food;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}