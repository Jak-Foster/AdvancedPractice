
namespace AdvancedPractice.The_Sieve
{
    public class Sieve (NumberDelegate NumberDelegate)
    { 
        private readonly NumberDelegate NumberDelegate = NumberDelegate;        
        public bool IsGood(int Number)
        {
            return NumberDelegate(Number);
        }       
    }

    public delegate bool NumberDelegate(int Number);
}

