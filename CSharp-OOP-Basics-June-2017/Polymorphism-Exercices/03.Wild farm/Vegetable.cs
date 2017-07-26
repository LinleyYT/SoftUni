namespace _03.Wild_farm
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) 
            : base(quantity)
        {
            this.FoodQuantity = quantity;
        }
    }
}
