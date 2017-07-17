namespace CrueltyPlan
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var foodTokens = Console.ReadLine().Split();
            var totalPoints = 0;

            foreach (var currentFood in foodTokens)
            {
                var foodType = FoodFactory.Get(currentFood);
                totalPoints += foodType.FoodPoints;
            }

            var moodType = MoodFactory.Get(totalPoints);

            Console.WriteLine(totalPoints);
            Console.WriteLine(moodType.MoodType);
        }
    }
}