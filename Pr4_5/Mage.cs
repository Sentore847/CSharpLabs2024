using System;

namespace MageBattle
{
    public abstract class Mage
    {
        public string Name { get; private set; }
        public int MagicLevel { get; private set; }
        public int Health { get; protected set; }

        public delegate void MageEventHandler(object sender, MageEventArgs e);
        public event MageEventHandler OnAttack;
        public event MageEventHandler OnDefend;

        protected Mage(string name, int magicLevel, int health)
        {
            Name = name;
            MagicLevel = magicLevel;
            Health = health;
        }

        public abstract void Attack(Mage target);
        public abstract void Defend(int damage);

        protected virtual void RaiseAttackEvent(Mage target)
        {
            OnAttack?.Invoke(this, new MageEventArgs(this, target));
        }

        protected virtual void RaiseDefendEvent(int damage)
        {
            OnDefend?.Invoke(this, new MageEventArgs(this, damage));
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
