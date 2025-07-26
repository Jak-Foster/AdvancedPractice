


internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Enter a word for the program to guess");
        while (true)
        {
            string UserInput = Console.ReadLine() ?? "hello";
            _ = Communicate(UserInput);
        }
        
    }

    public static int RandomlyRecreate(string Word)
    {
        Random Random = new();

        int Counter = 0;
        string JoinedCharacters = "";

        while (Word != JoinedCharacters)
        {
            JoinedCharacters = "";
            for (int I = Word.Length; I-- > 0;)
            {
                JoinedCharacters += ((Char)('a' + Random.Next(26)));  
            }
            Counter++;
        }
        return Counter;
    }

    public static Task<int> RandomlyRecreateAsync(string Word)
    {
        return Task.Run(() => RandomlyRecreate(Word));
    }

    public static async Task Communicate(string UserInput)
    {
        DateTime BeforeTask = DateTime.Now;
        Console.WriteLine("Time before task started: " + BeforeTask);

        int NumberOfAttempts = await RandomlyRecreateAsync(UserInput);

        DateTime AfterTask = DateTime.Now;
        Console.WriteLine("Time when task ended: " + AfterTask);
        Console.WriteLine("Number of attempts: " + NumberOfAttempts);

        TimeSpan TimeElapsed = AfterTask - BeforeTask;
        Console.WriteLine("Total time elapsed: " + TimeElapsed);
    }
}