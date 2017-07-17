namespace CrueltyPlan
{
    public class Mushrooms : Food
    {
        private const int MushroomsFoodPoints = -10;

        public override int FoodPoints
        {
            get { return MushroomsFoodPoints; }
        }
    }
}