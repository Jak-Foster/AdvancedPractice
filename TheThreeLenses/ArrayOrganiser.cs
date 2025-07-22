
namespace AdvancedPractice.TheThreeLenses
{
    public static class ArrayOrganiser
    {
        public static List<int> OrderArray1(int[] Arr)
        {
            List<int> EvenNums = new();
            foreach (int I in Arr)
            {
                if (I % 2 == 0) EvenNums.Add(I);
            }

            EvenNums.Sort();

            List<int> Result = new();
            foreach (int I in EvenNums)
            {
                Result.Add(I * 2);
            }

            return Result;
        }

        public static IEnumerable<int> OrderArray2(int[] Arr)
        {
            return from I in Arr
                   where I % 2 == 0
                   orderby I
                   select I * 2;
        }

        public static IEnumerable<int> OrderArray3(int[] Arr)
        {
            return Arr.Where(X => X % 2 == 0)
                      .OrderBy(X => X)
                      .Select(X => X * 2);
        }
    }   
}
