namespace _08.RawData
{
    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int speed, int power)
        {
            this.EngineSpeed = speed;
            this.EnginePower = power;
        }
    }
}