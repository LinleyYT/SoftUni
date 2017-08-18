using System;
using _11.InfernoInfinity.Models.Classes.Gems;
using _11.InfernoInfinity.Models.Enums;
using _11.InfernoInfinity.Models.Interfaces;

namespace _11.InfernoInfinity.Factories
{
    public class GemFactory
    {
        public IGem CreateGem(string args)
        {
            var gemArgs = args.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var clarity = (Clarity) Enum.Parse(typeof(Clarity), gemArgs[0]);
            var gemType = gemArgs[1];

            switch (gemType)
            {
                case "Ruby":
                    return new Ruby(clarity);
                case "Emerald":
                    return new Emerald(clarity);
                case "Amethyst":
                    return new Amethyst(clarity);
                default:
                    return null;
            }
        }
    }
}