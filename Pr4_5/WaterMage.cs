namespace MageBattle
{
    public class WaterMage : Mage
    {
        public WaterMage(string name, int magicLevel) : base(name, magicLevel, 100) { }

        private ISpell attackSpell = new Fireball();
        private ISpell defendSpell = new Shield();

        public override void Attack(Mage target)
        {
            RaiseAttackEvent(target);
            attackSpell.Cast(this, target);
        }

        public override void Defend(int damage)
        {
            RaiseDefendEvent(damage);
            if (damage > 0)
            {
                Health -= damage;
                Console.WriteLine($"{Name} takes {damage} damage. Health is now {Health}.");
            }
            else
            {
                Console.WriteLine($"{Name} defends with {Math.Abs(damage)} points.");
            }
        }
    }
}
