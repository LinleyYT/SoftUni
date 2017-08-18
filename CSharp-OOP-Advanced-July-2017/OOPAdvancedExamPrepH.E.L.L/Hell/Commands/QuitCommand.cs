using System.Collections.Generic;
using System.Linq;
using System.Text;

public class QuitCommand : AbstractCommand
{
#pragma warning disable 649
    [Inject] private IList<IHero> heroes;
#pragma warning restore 649

    public QuitCommand(string[] data) : base(data)
    {
    }

    public override string Execute()
    {
        var sb = new StringBuilder();
        var counter = 1;

        foreach (var hero in this.heroes.OrderByDescending(h => h.PrimaryStats).ThenByDescending(x => x.SecondaryStats))
        {
            sb.AppendLine($"{counter}. {hero.GetType().Name}: {hero.Name}");
            sb.AppendLine($"###HitPoints: {hero.HitPoints}");
            sb.AppendLine($"###Damage: {hero.Damage}");
            sb.AppendLine($"###Strength: {hero.Strength}");
            sb.AppendLine($"###Agility: {hero.Agility}");
            sb.AppendLine($"###Intelligence: {hero.Intelligence}");

            if (hero.Items.Count > 0)
            {
                var names = hero.Items.Select(h => h.Name);
                sb.AppendLine($"###Items: {string.Join(", ", names)}");
            }
            else
            {
                sb.AppendLine("###Items: None");
            }

            counter++;
        }

        return sb.ToString().Trim();
    }
}