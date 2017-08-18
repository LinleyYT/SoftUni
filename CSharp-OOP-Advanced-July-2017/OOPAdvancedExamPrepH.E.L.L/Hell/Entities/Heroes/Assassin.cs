public class Assassin : AbstractHero
{
    private const long AssassinStrength = 25;
    private const long AssassinAgility = 100;
    private const long AssassinIntelligence = 15;
    private const long AssassinHitPoints = 150;
    private const long AssassinDamage = 300;

    public Assassin(string name, IInventory inventory)
        : base(name, inventory)
    {
        this.strength = AssassinStrength;
        this.agility = AssassinAgility;
        this.intelligence = AssassinIntelligence;
        this.hitPoints = AssassinHitPoints;
        this.damage = AssassinDamage;
    }
}
