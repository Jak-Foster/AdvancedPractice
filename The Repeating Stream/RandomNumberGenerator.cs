
namespace AdvancedPractice.The_Repeating_Stream
{
    public static class RandomNumberGenerator
    {
        public static void Generate(RecentNumbers RecentNumbers)
        {
            
            while (true)
            {
                Random RandomNumber = new();
                int Num = RandomNumber.Next(10);
                Console.WriteLine(Num);

                Thread.Sleep(1000);
            }
        }
    }
}
