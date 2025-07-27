
using System.Dynamic;

internal class Program
{
    private static void Main(string[] args)
    {
        int IdIncrementer = 1;
        while (true)
        {
            dynamic Robot = new ExpandoObject();
            Robot.Id = IdIncrementer;

            Console.WriteLine($"You are producing robot #{Robot.Id}");

            Console.WriteLine("Do you want to name this robot?");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("What is its name?");
                Robot.Name = Console.ReadLine();
            }

            Console.WriteLine("Does this robot have a specific size?");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("What is its height?");
                Robot.Height = Console.ReadLine();

                Console.WriteLine("What is its width?");
                Robot.Width = Console.ReadLine();
            }

            Console.WriteLine("Does this robot need to be a specific color?");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("What colour?");
                Robot.Colour = Console.ReadLine();
            }

            foreach (KeyValuePair<string, object> Property in (IDictionary<string, object>)Robot)
            {
                Console.WriteLine($"{Property.Key}: {Property.Value}");
            }

            IdIncrementer++;
        }
    }
}