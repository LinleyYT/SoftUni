namespace _03.Wild_farm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.FoodQuantity = quantity;
        }

        private int foodQuantity;

        public int FoodQuantity
        {
            get { return this.foodQuantity; }
            protected set { this.foodQuantity = value; }
        }
    }
}