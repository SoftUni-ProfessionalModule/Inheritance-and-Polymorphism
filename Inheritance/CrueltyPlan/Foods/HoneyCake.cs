namespace CrueltyPlan
{
    public class HoneyCake : Food
    {
        private const int HoneyCakeFoodPoints = 5;

        public override int FoodPoints
        {
            get { return HoneyCakeFoodPoints; }
        }
    }
}