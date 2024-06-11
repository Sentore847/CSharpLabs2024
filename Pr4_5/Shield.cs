namespace MageBattle
{
    class Shield : ISpell
    {
        public void Cast(Mage caster, Mage target)
        {
            int defense = caster.MagicLevel;
            Console.WriteLine($"{caster.Name} uses Shield and reduces damage by {defense}!");
            target.Defend(-defense);
        }
    }
}
