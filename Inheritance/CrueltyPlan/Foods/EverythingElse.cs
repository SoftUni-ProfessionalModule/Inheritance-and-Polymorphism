namespace CrueltyPlan
{
    public class EverythingElse : Food
    {
        private const int OtherFoodsPoints = -1;

        public override int FoodPoints
        {
            get { return OtherFoodsPoints; }
        }
    }
}