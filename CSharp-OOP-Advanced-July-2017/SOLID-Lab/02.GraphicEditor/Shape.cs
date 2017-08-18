namespace _02.Graphic_Editor
{
    public abstract class Shape : IShape
    {
        public override string ToString()
        {
            return $"I'm {this.GetType().Name}";
        }
    }
}