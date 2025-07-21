
namespace AdvancedPractice.PatternPotions
{
    public class PotionCreator
    {
        public static Potion DeterminePotion(Potion UserPotion, IngredientType Ingredient)
        {
            return (UserPotion, Ingredient) switch
            {
                (Potion.Water, IngredientType.Stardust) => Potion.Elixir,
                (Potion.Elixir, IngredientType.SnakeVenom) => Potion.PoisonPotion,
                (Potion.Elixir, IngredientType.DragonBreath) => Potion.FlyingPotion,
                (Potion.Elixir, IngredientType.ShadowGlass) => Potion.InvisibilityPotion,
                (Potion.Elixir, IngredientType.EyeshineGem) => Potion.NightSightPotion,
                (Potion.NightSightPotion, IngredientType.ShadowGlass) => Potion.CloudyBrew,
                (Potion.InvisibilityPotion, IngredientType.EyeshineGem) => Potion.CloudyBrew,
                (Potion.CloudyBrew, IngredientType.Stardust) => Potion.WraithPotion,
                _ => Potion.RuinedPotion
            };
        }
    }
}
