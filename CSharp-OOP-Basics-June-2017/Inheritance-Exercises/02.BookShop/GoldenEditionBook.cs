namespace _02.BookShop
{
    internal class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get { return decimal.Multiply(base.Price, 1.3m); }
        }
    }
}