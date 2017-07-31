namespace _10.Tuple
{
    public class Tuple<T, TV, TU>
    {
        public Tuple(T item1, TV item2, TU item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1 { get; private set; }
        public TV Item2 { get; private set; }
        public TU Item3 { get; private set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}