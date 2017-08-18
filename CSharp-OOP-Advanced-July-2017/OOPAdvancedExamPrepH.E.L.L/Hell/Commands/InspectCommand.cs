using System;
using System.Collections.Generic;
using System.Linq;

public class InspectCommand : AbstractCommand
{
#pragma warning disable 649
    [Inject] private IList<IHero> heroes;
#pragma warning restore 649

    public InspectCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        var heroName = this.Data[0];

        var result = this.heroes.FirstOrDefault(h => h.Name.Equals(heroName, StringComparison.OrdinalIgnoreCase));

        return result.ToString();
    }
}
