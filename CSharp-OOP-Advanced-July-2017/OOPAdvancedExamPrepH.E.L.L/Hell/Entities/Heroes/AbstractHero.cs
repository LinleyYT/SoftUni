using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class AbstractHero : IHero, IComparable<AbstractHero>
{
    private IInventory inventory;
    protected long strength;
    protected long agility;
    protected long intelligence;
    protected long hitPoints;
    protected long damage;

    protected AbstractHero(string name)
    {
        this.Name = name;
        this.inventory = new HeroInventory();
    }

    public string Name { get; private set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        private set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        private set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        private set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        private set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        private set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    public IInventory Inventory
    {
        get { return this.inventory; }
        private set { this.inventory = value; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            Type getType = this.Inventory.GetType();
            FieldInfo commonItemsFieldInfo = getType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => Attribute.IsDefined(f, typeof(ItemAttribute)));

            Dictionary<string, IItem> commonItems =
                (Dictionary<string, IItem>) commonItemsFieldInfo.GetValue(this.inventory);

            return commonItems.Values;
        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }
    
    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }
        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Hero: {this.Name}, Class: {this.GetType().Name}");
        sb.AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}");
        sb.AppendLine($"Strength: {this.Strength}");
        sb.AppendLine($"Agility: {this.Agility}");
        sb.AppendLine($"Intelligence: {this.Intelligence}");
        

        if (this.Items.Count > 0)
        {
            sb.AppendLine("Items:");

            foreach (var item in this.Items)
            {
                sb.AppendLine(item.ToString());
            }
        }
        else
        {
            sb.AppendLine("Items: None");
        }
        
        return sb.ToString().Trim();
    }
}