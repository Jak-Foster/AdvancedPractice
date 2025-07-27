


internal class Program
{
    private static void Main(string[] args)
    {

        int IntOne = 2;
        int IntTwo = 3;

        Console.WriteLine(Program.Add(IntOne, IntTwo));

        double DoubleOne = 1.0005;
        double DoubleTwo = 3.876543;

        Console.WriteLine(Program.Add(DoubleOne, DoubleTwo));

        string StringOne = "Hello";
        string StringTwo = " World";

        Console.WriteLine(Program.Add(StringOne, StringTwo));

        DateTime DateTimeOne = DateTime.Now;
        TimeSpan TimeSpanOne = TimeSpan.Zero;

        Console.WriteLine(Program.Add(DateTimeOne, TimeSpanOne));
    }

    public static dynamic Add(dynamic Obj1, dynamic Obj2) => Obj1 + Obj2;
}