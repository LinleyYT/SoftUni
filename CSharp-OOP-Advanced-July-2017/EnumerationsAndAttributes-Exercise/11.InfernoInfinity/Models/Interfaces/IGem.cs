using _11.InfernoInfinity.Models.Enums;

namespace _11.InfernoInfinity.Models.Interfaces
{
    public interface IGem
    {
        Clarity Clarity { get; }

        int GetTotalStrength();
        int GetTotalAgility();
        int GetTotalVitality();
    }
}