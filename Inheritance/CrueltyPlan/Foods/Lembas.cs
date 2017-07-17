namespace CrueltyPlan
{
    public class Lembas : Food
    {
        private const int LembasFoodPoints = 3;

        public override int FoodPoints
        {
            get { return LembasFoodPoints; }
        }
    }
}