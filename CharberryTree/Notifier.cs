
namespace AdvancedPractice.CharberryTree
{
    public class Notifier
    {
        public Notifier (CharberryTree CharberryTree)
        {
            CharberryTree.Ripened += Notify;
        }
        
        public void Notify()
        {
            Console.WriteLine("A charberry fruit has ripened!");
        }
    }
}
