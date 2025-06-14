
namespace AdvancedPractice.RandomExtensions
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random Random, int Multiplier)
        {
            return Random.NextDouble() * Multiplier;
        }

        public static string NextString(this Random Random, params string[] StringArray)
        {
            return StringArray[Random.Next(StringArray.Length)];
        }

        public static bool CoinFlip(this Random Random, double ProbabilityOfHeads = 0.5)
        {
            return Random.NextDouble() < ProbabilityOfHeads;
        }
    }
}
