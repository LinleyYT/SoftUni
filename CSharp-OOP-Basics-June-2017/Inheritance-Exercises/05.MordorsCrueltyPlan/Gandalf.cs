using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.MordorsCrueltyPlan.FoodModels;
using _05.MordorsCrueltyPlan.MoodModels;

namespace _05.MordorsCrueltyPlan
{
    public class Gandalf
    {
        public Gandalf(List<Food> foods)
        {
            this.Foods = foods;
            this.points = this.GetPoints(this.Foods);
            this.mood = moodF.GetMood(this.points);
        }

        private List<Food> foods;

        public List<Food> Foods
        {
            get { return this.foods; }
            set { this.foods = value; }
        }

        private Mood mood;
        MoodFactory moodF = new MoodFactory();
        private int points;

        private int GetPoints(List<Food> foods)
        {
            return foods.Sum(x => x.Happiness);
        }

        public override string ToString()
        {
            return $"{this.points}\n{this.mood.Type}";
        }
    }
}
