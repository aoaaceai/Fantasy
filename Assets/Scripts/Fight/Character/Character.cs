using JetBrains.Annotations;

namespace Fight.Character
{
    public class Character : LivingThing.LivingThing
    {
      public Character(string name, int attack, int defense, int speed, int hp) : base(name, attack, defense, speed, hp)
        {
            
        }
    }
}