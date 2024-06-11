namespace MageBattle
{
    class Fireball : ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            int damage = caster.MagicLevel * 2;
            Console.WriteLine($"{caster.Name} casts Fireball at {target.Name} for {damage} damage!");
            target.Defend(damage);
        }
    }
}
