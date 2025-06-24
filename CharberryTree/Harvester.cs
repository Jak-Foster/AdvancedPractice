
namespace AdvancedPractice.CharberryTree
{
    public class Harvester
    {
        private readonly CharberryTree CharberryTree;
        public Harvester(CharberryTree CharberryTree) 
        {
            this.CharberryTree = CharberryTree;
            CharberryTree.Ripened += Harvest;
        }

        private void Harvest()
        {
            CharberryTree.Ripe = false;
            Console.WriteLine("Fruit has been harvested!");
        }
    }
}
