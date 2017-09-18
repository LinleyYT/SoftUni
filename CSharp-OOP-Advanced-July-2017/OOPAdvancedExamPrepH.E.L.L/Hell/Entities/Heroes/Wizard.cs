public class Wizard : AbstractHero
{
    private const long WizardStrength = 25;
    private const long WizardAgility = 25;
    private const long WizardIntelligence = 100;
    private const long WizardHitPoints = 100;
    private const long WizardDamage = 250;

    public Wizard(string name)
        : base(name)
    {
        this.strength = WizardStrength;
        this.agility = WizardAgility;
        this.intelligence = WizardIntelligence;
        this.hitPoints = WizardHitPoints;
        this.damage = WizardDamage;
    }
}
