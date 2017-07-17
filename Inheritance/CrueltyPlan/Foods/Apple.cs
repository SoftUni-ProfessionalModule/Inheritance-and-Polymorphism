namespace CrueltyPlan
{
    public class Apple : Food
    {
        private const int AppleFoodPoints = 1;

        public override int FoodPoints
        {
            get { return AppleFoodPoints; }
        }
    }
}