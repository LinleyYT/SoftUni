﻿public class Barbarian : AbstractHero
{
    private const long BarbarianStrength = 90;
    private const long BarbarianAgility = 25;
    private const long BarbarianIntelligence = 10;
    private const long BarbarianHitPoints = 350;
    private const long BarbarianDamage = 150;

    public Barbarian(string name)
        : base(name)
    {
        this.strength = BarbarianStrength;
        this.agility = BarbarianAgility;
        this.intelligence = BarbarianIntelligence;
        this.hitPoints = BarbarianHitPoints;
        this.damage = BarbarianDamage;
    }
}
