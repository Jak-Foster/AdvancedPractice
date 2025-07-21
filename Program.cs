using AdvancedPractice.McDroid;
using AdvancedPractice.IField;
using IFieldPig = AdvancedPractice.IField.Pig;
using McDroidPig = AdvancedPractice.McDroid.Pig;
using AdvancedPractice.The_Sieve;
using AdvancedPractice.CharberryTree;
using System.Security.Cryptography.X509Certificates;
using AdvancedPractice.PatternPotions;
using AdvancedPractice.OperandCity;
internal class Program
{
    private static void Main(string[] args)
    {
        //Cow Cow = new();
        //Sheep Sheep = new();
        //IFieldPig FieldPig = new();
        //McDroidPig DroidPig = new();

        //Console.WriteLine("Pick one of three filters to check whether a number is good or bad:");
        //Console.WriteLine("IsEven, IsPositive, or IsMultipleOfTen");

        //string? UserInput = Console.ReadLine();
        //Sieve Sieve;

        //if (UserInput == "IsEven") Sieve = new(X => X % 2 == 0);
        //else if (UserInput == "IsMultipleOfTen") Sieve = new(X => X % 10 == 0);
        //else if (UserInput == "IsPositive") Sieve = new(X => X >= 0);
        //else
        //{
        //    Console.WriteLine("Invalid input. Run the program again.");
        //    return;
        //}

        //while (true)
        //{
        //    Console.WriteLine("--------------------\n\r");

        //    string? UserNumberInput = Console.ReadLine();

        //    try
        //    {
        //        int ConvertedInput = Convert.ToInt32(UserNumberInput);

        //        bool Response = Sieve.IsGood(ConvertedInput);

        //        if (Response)
        //        {
        //            Console.WriteLine("Good number entered!");
        //        }
        //        else Console.WriteLine("Bad number entered :(");
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Invalid number entered. Try again.");
        //    }
        //}

        //CharberryTree Tree = new();
        //Notifier Notifier = new(Tree);
        //Harvester Harvester = new(Tree);

        //while(true)
        //{
        //    Tree.MaybeGrow();
        //    //if(Tree.Ripe)
        //    //    Console.WriteLine("Tree is ripe!");
        //}

        //Console.WriteLine("Please enter your name");
        //string? UserName = Console.ReadLine();
        //int UserScore = 0;

        //if (File.Exists($"../../../UserScores/{UserName}.txt")) UserScore = Convert.ToInt32(File.ReadAllText($"../../../UserScores/{UserName}.txt"));

        //Console.WriteLine("You get one point for every key press you make. Press enter to end the game. Begin!");
        //while (Console.ReadKey().Key != ConsoleKey.Enter)
        //{
        //    UserScore++;
        //    Console.WriteLine("Score: " + UserScore);
        //}

        //File.WriteAllText($"../../../UserScores/{UserName}.txt", UserScore.ToString());

        //bool ContinueConcoctingPotion = true;
        //Potion UserPotion = Potion.Water;

        //while (ContinueConcoctingPotion)
        //{
        //    Console.WriteLine($"The potion you currently have is {UserPotion}");
        //    Console.WriteLine("The available ingredients are:");
        //    Console.WriteLine("Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem");
        //    Console.WriteLine("Choose an ingredient...");

        //    string? UserIngredientChoice = Console.ReadLine();

        //    IngredientType Ingredient = UserIngredientChoice switch
        //    {
        //        "Stardust"     => IngredientType.Stardust,
        //        "SnakeVenom"   => IngredientType.SnakeVenom,
        //        "DragonBreath" => IngredientType.DragonBreath,
        //        "ShadowGlass"  => IngredientType.ShadowGlass,
        //        "EyeshineGem"  => IngredientType.EyeshineGem,
        //        _              => IngredientType.AnythingElse
        //    };

        //    UserPotion = PotionCreator.DeterminePotion(UserPotion, Ingredient);

        //    Console.WriteLine($"The potion you have concocted is a {UserPotion}!");
        //    if (UserPotion == Potion.RuinedPotion)
        //    {
        //        Console.WriteLine("Starting again from scratch...");
        //        UserPotion = Potion.Water;
        //    }

        //    Console.WriteLine("Do you want to continue concocting potions? yes/no");
        //    if (Console.ReadLine() == "no") return;
        //}

        BlockCoordinate BlockCoordinate = new(0, 0);
        BlockOffset BlockOffset = new(2, 2);
        Console.WriteLine(BlockCoordinate + BlockOffset);

        BlockCoordinate BlockCoordinate2 = new(0, 0);
        Console.WriteLine(BlockCoordinate + Direction.East);

        Console.WriteLine(BlockCoordinate[0]);
        Console.WriteLine(BlockCoordinate[1]);

        Direction East = Direction.East;
        BlockOffset EastOffset = East;
        Console.WriteLine(EastOffset);

    }  
}