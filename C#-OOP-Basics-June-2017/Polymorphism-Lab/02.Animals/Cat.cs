﻿using System;

public class Cat : Animal
{
    public Cat(string name, string food)
    {
        this.Name = name;
        this.FavouriteFood = food;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}
