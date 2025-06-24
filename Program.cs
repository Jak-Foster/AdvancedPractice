using AdvancedPractice.McDroid;
using AdvancedPractice.IField;
using IFieldPig = AdvancedPractice.IField.Pig;
using McDroidPig = AdvancedPractice.McDroid.Pig;
using AdvancedPractice.The_Sieve;
internal class Program
{
    private static void Main(string[] args)
    {
        //Cow Cow = new();
        //Sheep Sheep = new();
        //IFieldPig FieldPig = new();
        //McDroidPig DroidPig = new();

        Console.WriteLine("Pick one of three filters to check whether a number is good or bad:");
        Console.WriteLine("IsEven, IsPositive, or IsMultipleOfTen");

        string? UserInput = Console.ReadLine();
        Sieve Sieve;

        if (UserInput == "IsEven") Sieve = new(X => X % 2 == 0);
        else if (UserInput == "IsMultipleOfTen") Sieve = new(X => X % 10 == 0);
        else if (UserInput == "IsPositive") Sieve = new(X => X >= 0);
        else
        {
            Console.WriteLine("Invalid input. Run the program again.");
            return;
        }

        while (true)
        {
            Console.WriteLine("--------------------\n\r");

            string? UserNumberInput = Console.ReadLine();

            try
            {
                int ConvertedInput = Convert.ToInt32(UserNumberInput);

                bool Response = Sieve.IsGood(ConvertedInput);

                if (Response)
                {
                    Console.WriteLine("Good number entered!");
                }
                else Console.WriteLine("Bad number entered :(");
            }
            catch
            {
                Console.WriteLine("Invalid number entered. Try again.");
            }
        }
    }
}