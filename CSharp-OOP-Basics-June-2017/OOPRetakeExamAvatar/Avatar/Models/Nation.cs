using System.Collections.Generic;
using System.Linq;

public class Nation
{
    public Nation()
    {
        this.AllBenders = new List<Bender>();
    }

    private List<Bender> allBenders;

    public List<Bender> AllBenders
    {
        get { return this.allBenders; }
        private set { this.allBenders = value; }
    }

    public void AddBender(Bender bender)
    {
        AllBenders.Add(bender);
    }

    public void RemoveLosers(string winner)
    {
        this.AllBenders = this.AllBenders.Where(x => x.GetType().Name.Contains(winner)).ToList();
    }
}