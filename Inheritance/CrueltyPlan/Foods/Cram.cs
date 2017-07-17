namespace CrueltyPlan
{
    public class Cram : Food
    {
        private const int CramFoodPoints = 2;

        public override int FoodPoints
        {
            get { return CramFoodPoints; }
        }
    }
}