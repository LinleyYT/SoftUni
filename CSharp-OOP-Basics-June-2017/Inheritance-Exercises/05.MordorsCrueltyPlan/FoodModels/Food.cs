namespace _05.MordorsCrueltyPlan.FoodModels
{
    public abstract class Food
    {
        public Food(int happiness)
        {
            this.Happiness = happiness;
        }

        private int happiness;

        public int Happiness
        {
            get { return this.happiness; }
            set { this.happiness = value; }
        }
    }
}