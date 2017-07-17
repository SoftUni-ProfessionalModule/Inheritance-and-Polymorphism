namespace CrueltyPlan
{
    public class Melon : Food
    {
        private const int MelonFoodPoints = 1;

        public override int FoodPoints
        {
            get { return MelonFoodPoints; }
        }
    }
}