
namespace AdvancedPractice.CharberryTree
{
    public class CharberryTree()
    {
        private readonly Random Random = new();
        public bool Ripe { get; set; }  

        public event Action Ripened = () => { };
        public void MaybeGrow()
        {
            if (Random.NextDouble() < 0.000000001 && !Ripe)
            {
                Ripe = true;
                Ripened();
            }
        }
    }
}
